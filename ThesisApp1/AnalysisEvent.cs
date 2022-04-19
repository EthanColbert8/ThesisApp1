using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ThesisApp1
{
    public class AnalysisEvent
    {

        //The filter parameters for transverse momentum for the electron and muon channels.
        public const double MUON_PT_CUT = 10.0;
        public const double ELECTRON_PT_CUT = 20.0;

        //Data from inside zipped archives is provided as a Stream. This allows us to handle it.
        private Stream dataStream = null;

        public int RunNumber { get; set; }
        public int EventNumber { get; set; }
        public string LastKnownFilePath { get; set; }
        public bool HasElectrons { get; set; }
        public bool HasMuons { get; set; }

        private double[] _muonPTs;
        public double[] MuonPTs
        {
            get { return _muonPTs; }
            set
            {
                if (value.Length >= 2) { _muonPTs = value; }
            }
        }

        private double[] _muonEtas;
        public double[] MuonEtas
        {
            get { return _muonEtas; }
            set
            {
                if (value.Length >= 2) { _muonEtas = value; }
            }
        }

        private double[] _electronPTs;
        public double[] ElectronPTs
        {
            get { return _electronPTs; }
            set
            {
                if (value.Length >= 2) { _electronPTs = value; }
            }
        }

        private double[] _electronEtas;
        public double[] ElectronEtas
        {
            get { return _electronEtas; }
            set
            {
                if (value.Length >= 2) { _electronEtas = value; }
            }
        }

        private double _etMissing;
        public double EtMissing
        {
            get { return _etMissing; }
            set
            {
                if (value >= 0.0) { _etMissing = value; }
            }
        }

        /*
        private double _centralMass;
        public double CentralMass
        {
            get { return _centralMass; }
            set
            {
                if (value >= 0.0) { _centralMass = value; }
            }
        }
        */

        //parameterless constructor - initializes arrays, but gives no values.
        public AnalysisEvent() { }

        //preferred constructor
        public AnalysisEvent(string filePath)
        {
            LastKnownFilePath = filePath;
        }

        public AnalysisEvent(string filePath, Stream inputData)
        {
            LastKnownFilePath = filePath;
            dataStream = inputData;
        }

        public void SearchForParticles()
        {
            string muonPTValues = "", muonEtaValues = "";
            string electronPTValues = "", electronEtaValues = "";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Ignore;
            settings.ValidationType = ValidationType.DTD;

            XmlReader reader;
            if (dataStream is null)
            {
                reader = XmlReader.Create(LastKnownFilePath, settings);
            }
            else
            {
                reader = XmlReader.Create(dataStream, settings);
            }


            reader.MoveToContent();
            reader.MoveToAttribute("runNumber");
            RunNumber = int.Parse(reader.Value);
            reader.MoveToAttribute("eventNumber");
            EventNumber = int.Parse(reader.Value);

            while (reader.Read())
            {
                if (reader.Name.Equals("ETMis"))
                {
                    XmlReader inner = reader.ReadSubtree();
                    inner.Read(); //places the inner reader on the main element node

                    inner.MoveToAttribute("storeGateKey");
                    if (inner.Value.Equals("MET_RefFinal"))
                    {
                        inner.ReadToFollowing("etx");
                        double xComponent = double.Parse(inner.ReadElementContentAsString());
                        inner.ReadToFollowing("ety");
                        double yComponent = double.Parse(inner.ReadElementContentAsString());

                        EtMissing = Math.Sqrt(Math.Pow(xComponent, 2) + Math.Pow(yComponent, 2));
                    }

                    inner.Close();
                }
                else if (reader.Name.Equals("Muon"))
                {
                    XmlReader inner = reader.ReadSubtree();
                    inner.Read();

                    inner.MoveToAttribute("storeGateKey");
                    if (inner.Value.Equals("StacoMuonCollection"))
                    {
                        inner.ReadToFollowing("eta");
                        muonEtaValues += inner.ReadElementContentAsString();

                        inner.ReadToFollowing("pt");
                        muonPTValues += inner.ReadElementContentAsString();
                    }

                    inner.Close();
                }
                else if (reader.Name.Equals("Electron"))
                {
                    XmlReader inner = reader.ReadSubtree();
                    inner.Read();

                    inner.MoveToAttribute("storeGateKey");
                    if (inner.Value.Equals("ElectronAODCollection"))
                    {
                        inner.ReadToFollowing("eta");
                        electronEtaValues += inner.ReadElementContentAsString();

                        inner.ReadToFollowing("pt");
                        electronPTValues += inner.ReadElementContentAsString();
                    }

                    inner.Close();
                }
            }
            reader.Close();

            double[] muonPTs = ConvertStringToDoubles(muonPTValues);
            if (ParticlesMeetCut(MUON_PT_CUT, muonPTs))
            {
                HasMuons = true;

                double[] muonEtas = ConvertStringToDoubles(muonEtaValues);
                List<double> largePTs = new List<double>();
                List<double> correspondingEtas = new List<double>();

                for (int j = 0; j < muonPTs.Length; j++)
                {
                    if (muonPTs[j] >= MUON_PT_CUT)
                    {
                        largePTs.Add(muonPTs[j]);
                        correspondingEtas.Add(muonEtas[j]);
                    }
                }
                MuonPTs = largePTs.ToArray();
                MuonEtas = correspondingEtas.ToArray();
            }
            else
            {
                HasMuons = false;
            }

            double[] electronPTs = ConvertStringToDoubles(electronPTValues);
            if (ParticlesMeetCut(ELECTRON_PT_CUT, electronPTs))
            {
                HasElectrons = true;

                double[] electronEtas = ConvertStringToDoubles(electronEtaValues);
                List<double> largePTs = new List<double>();
                List<double> correspondingEtas = new List<double>();

                for (int j = 0; j < electronPTs.Length; j++)
                {
                    if (electronPTs[j] >= ELECTRON_PT_CUT)
                    {
                        largePTs.Add(electronPTs[j]);
                        correspondingEtas.Add(electronEtas[j]);
                    }
                }
                ElectronPTs = largePTs.ToArray();
                ElectronEtas = correspondingEtas.ToArray();
            }
            else
            {
                HasElectrons = false;
            }

        }

        //support method to convert a string listing numeric values,
        //separated by spaces, into floats
        private double[] ConvertStringToDoubles(string numList)
        {
            List<double> doubleList = new List<double>();

            foreach (string value in numList.Split(' '))
            {
                try
                {
                    doubleList.Add(double.Parse(value));
                }
                catch (FormatException e)
                {
                    //Console.WriteLine(e.Message)
                    continue;
                }
            }

            return doubleList.ToArray();
        }

        private bool ParticlesMeetCut(double cutValue, double[] ptList)
        {
            int countMet = 0;

            foreach (double particle in ptList)
            {
                if (particle >= cutValue)
                {
                    countMet++;
                }
            }

            if (countMet >= 2)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string outputString = "Event: run number " + RunNumber + ", event number " + EventNumber + "\nLast known file path: " + LastKnownFilePath + "\n";

            if (HasMuons)
            {
                outputString += "Muon pair(s) found. Pt values: " + ListArrayContents(MuonPTs) + ", Eta values: " + ListArrayContents(MuonEtas) + "\n";
            }

            if (HasElectrons)
            {
                outputString += "Electron pair(s) found. Pt values: " + ListArrayContents(ElectronPTs) + ", Eta values: " + ListArrayContents(ElectronEtas) + "\n";
            }

            outputString += "Missing energy: " + EtMissing + "\n";

            return outputString;
        }

        private string ListArrayContents(double[] input)
        {
            string outputString = "[";

            foreach (double value in input)
            {
                outputString += value + ", ";
            }
            
            outputString.TrimEnd(' ', ',');
            outputString += "]";

            return outputString;
        }

    } //end AnalysisEvent class

    //This is an implementation of the IComparer interface, allowing instances of the
    //AnalysisEvent class to be ordered.
    public class EventComparison : IComparer<AnalysisEvent>
    {
        public int Compare(AnalysisEvent x, AnalysisEvent y)
        {
            int runNumComparison = x.RunNumber.CompareTo(y.RunNumber);

            if (runNumComparison == 0)
            {
                return x.EventNumber.CompareTo(y.EventNumber);
            }

            return runNumComparison;
        }
    }
}
