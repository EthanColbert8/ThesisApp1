using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisApp1
{
    public class EventDisplayPanel : Panel
    {
        private Color backgroundColor = SystemColors.Control;
        
        private TextBox EventRunNumberDisplay;
        private TextBox LastKnownPathDisplay;
        private TextBox ElectronPtDisplay;
        private TextBox ElectronEtaDisplay;
        private TextBox MuonPtDisplay;
        private TextBox MuonEtaDisplay;
        private TextBox EtMissingDisplay;

        private AnalysisEvent _eventDisplayed;
        public AnalysisEvent EventDisplayed
        {
            get { return _eventDisplayed; }
            set
            {
                _eventDisplayed = value;
                FillDisplay();
            }
        }

        public EventDisplayPanel()
        {
            BackColor = backgroundColor;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(500, 100);

            EventRunNumberDisplay = new TextBox();
            SetupTextDisplay(EventRunNumberDisplay);
            EventRunNumberDisplay.Text = "Run number: Event number: ";
            
            LastKnownPathDisplay = new TextBox();
            SetupTextDisplay(LastKnownPathDisplay);
            LastKnownPathDisplay.Text = "Last known file path: ";

            ElectronPtDisplay = new TextBox();
            SetupTextDisplay(ElectronPtDisplay);
            ElectronPtDisplay.Text = "Electron transverse momenta: ";

            ElectronEtaDisplay = new TextBox();
            SetupTextDisplay(ElectronEtaDisplay);
            ElectronEtaDisplay.Text = "Electron pseudorapidities: ";

            MuonPtDisplay = new TextBox();
            SetupTextDisplay(MuonPtDisplay);
            MuonPtDisplay.Text = "Muon transverse momenta: ";

            MuonEtaDisplay = new TextBox();
            SetupTextDisplay(MuonEtaDisplay);
            MuonEtaDisplay.Text = "Muon pseudorapidities: ";

            EtMissingDisplay = new TextBox();
            SetupTextDisplay(EtMissingDisplay);
            EtMissingDisplay.Text = "Missing energy: ";

            SetLocations();

            Controls.Add(EventRunNumberDisplay);
            Controls.Add(LastKnownPathDisplay);
            Controls.Add(ElectronPtDisplay);
            Controls.Add(ElectronEtaDisplay);
            Controls.Add(MuonPtDisplay);
            Controls.Add(MuonEtaDisplay);
            Controls.Add(EtMissingDisplay);
        }

        public EventDisplayPanel(AnalysisEvent newEvent)
        {
            BackColor = backgroundColor;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(500, 100);

            EventRunNumberDisplay = new TextBox();
            SetupTextDisplay(EventRunNumberDisplay);

            LastKnownPathDisplay = new TextBox();
            SetupTextDisplay(LastKnownPathDisplay);

            ElectronPtDisplay = new TextBox();
            SetupTextDisplay(ElectronPtDisplay);

            ElectronEtaDisplay = new TextBox();
            SetupTextDisplay(ElectronEtaDisplay);

            MuonPtDisplay = new TextBox();
            SetupTextDisplay(MuonPtDisplay);

            MuonEtaDisplay = new TextBox();
            SetupTextDisplay(MuonEtaDisplay);
            
            EtMissingDisplay = new TextBox();
            SetupTextDisplay(EtMissingDisplay);

            EventDisplayed = newEvent;

            SetLocations();

            Controls.Add(EventRunNumberDisplay);
            Controls.Add(LastKnownPathDisplay);
            Controls.Add(ElectronPtDisplay);
            Controls.Add(ElectronEtaDisplay);
            Controls.Add(MuonPtDisplay);
            Controls.Add(MuonEtaDisplay);
            Controls.Add(EtMissingDisplay);
        }

        public EventDisplayPanel(AnalysisEvent newEvent, Point location) : this(newEvent)
        {
            Location = location;
        }

        //here
        
        private void SetupTextDisplay(TextBox displayToSetup)
        {
            displayToSetup.ReadOnly = true;
            displayToSetup.BorderStyle = BorderStyle.None;
            displayToSetup.BackColor = this.BackColor;
            displayToSetup.Font = new Font("Segoe UI", 12);
            displayToSetup.Size = new Size(450, 30);
        }

        private void FillDisplay()
        {
            EventRunNumberDisplay.Text = "Run number: " + EventDisplayed.RunNumber + ", Event number: " + EventDisplayed.EventNumber;

            LastKnownPathDisplay.Text = "Last known file path: " + EventDisplayed.LastKnownFilePath;

            ElectronPtDisplay.Text = String.Empty;
            ElectronEtaDisplay.Text = String.Empty;
            if (EventDisplayed.HasElectrons)
            {
                ElectronPtDisplay.Text = "Electron transverse momenta: [";
                ElectronEtaDisplay.Text = "Electron pseudorapidities: [";
                ElectronPtDisplay.Text = FillList(ElectronPtDisplay.Text, EventDisplayed.ElectronPTs);
                ElectronEtaDisplay.Text = FillList(ElectronEtaDisplay.Text, EventDisplayed.ElectronEtas);
            }

            MuonPtDisplay.Text = String.Empty;
            MuonEtaDisplay.Text = String.Empty;
            if (EventDisplayed.HasMuons)
            {
                MuonPtDisplay.Text = "Muon transverse momenta: [";
                MuonEtaDisplay.Text = "Muon pseudorapidities: [";
                MuonPtDisplay.Text = FillList(MuonPtDisplay.Text, EventDisplayed.MuonPTs);
                MuonEtaDisplay.Text = FillList(MuonEtaDisplay.Text, EventDisplayed.MuonEtas);
            }

            EtMissingDisplay.Text = "Missing energy: " + EventDisplayed.EtMissing;
        }

        private string FillList(string baseString, double[] valuesToAdd)
        {
            foreach (double value in valuesToAdd)
            {
                baseString += value + ", ";
            }
            baseString = baseString.TrimEnd(' ');
            baseString = baseString.TrimEnd(',');
            baseString += "]";

            return baseString;
        }

        private void SetLocations()
        {
            EventRunNumberDisplay.Location = new Point(6, 5);
            LastKnownPathDisplay.Location = new Point(6, 40);

            if (!(EventDisplayed is null))
            {
                if (EventDisplayed.HasElectrons)
                {
                    ElectronPtDisplay.Location = new Point(6, 75);
                    ElectronEtaDisplay.Location = new Point(6, 110);

                    if (EventDisplayed.HasMuons)
                    {
                        MuonPtDisplay.Location = new Point(6, 145);
                        MuonEtaDisplay.Location = new Point(6, 180);
                        EtMissingDisplay.Location = new Point(6, 215);

                        Size = new Size(500, 260);
                    }
                    else
                    {
                        EtMissingDisplay.Location = new Point(6, 145);

                        Size = new Size(500, 190);
                    }
                }
                else
                {
                    MuonPtDisplay.Location = new Point(6, 75);
                    MuonEtaDisplay.Location = new Point(6, 110);
                    EtMissingDisplay.Location = new Point(6, 145);

                    Size = new Size(500, 190);
                }
            }
            else
            {
                ElectronPtDisplay.Location = new Point(6, 75);
                ElectronEtaDisplay.Location = new Point(6, 110);
                MuonPtDisplay.Location = new Point(6, 145);
                MuonEtaDisplay.Location = new Point(6, 180);
                EtMissingDisplay.Location = new Point(6, 215);

                Size = new Size(500, 260);
            }
        }
    }
}
