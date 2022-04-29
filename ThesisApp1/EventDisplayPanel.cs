using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisApp1
{
    class EventDisplayPanel : Panel
    {
        private System.Drawing.Color backgroundColor = System.Drawing.SystemColors.Control;

        public AnalysisEvent EventDisplayed { get; set; }
        public TextBox EventRunNumberDisplay { get; set; }
        public TextBox LastKnownPathDisplay { get; set; }
        public TextBox ElectronPtDisplay { get; set; }
        public TextBox ElectronEtaDisplay { get; set; }
        public TextBox MuonPtDisplay { get; set; }
        public TextBox MuonEtaDisplay { get; set; }
        public TextBox EtMissingDisplay { get; set; }

        public EventDisplayPanel()
        {
            this.BackColor = backgroundColor;
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;

            EventRunNumberDisplay = new TextBox();
            setupTextDisplay(EventRunNumberDisplay);
            EventRunNumberDisplay.Text = "Run number: Event number: ";
            
            LastKnownPathDisplay = new TextBox();
            setupTextDisplay(LastKnownPathDisplay);
            LastKnownPathDisplay.Text = "Last known file path: ";

            ElectronPtDisplay = new TextBox();
            setupTextDisplay(ElectronPtDisplay);
            ElectronPtDisplay.Text = "Electron transverse momenta: ";

            ElectronEtaDisplay = new TextBox();
            setupTextDisplay(ElectronEtaDisplay);
            ElectronEtaDisplay.Text = "Electron pseudorapidities: ";

            MuonPtDisplay = new TextBox();
            setupTextDisplay(MuonPtDisplay);
            MuonPtDisplay.Text = "Muon transverse momenta: ";

            MuonEtaDisplay = new TextBox();
            setupTextDisplay(MuonEtaDisplay);
            MuonEtaDisplay.Text = "Muon pseudorapidities: ";

            EtMissingDisplay = new TextBox();
            setupTextDisplay(EtMissingDisplay);
            EtMissingDisplay.Text = "Missing energy: ";
        }

        public EventDisplayPanel(AnalysisEvent newEvent)
        {
            this.BackColor = backgroundColor;
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.FixedSingle;

            EventDisplayed = newEvent;

            EventRunNumberDisplay = new TextBox();
            setupTextDisplay(EventRunNumberDisplay);
            EventRunNumberDisplay.Text = "Run number: " + EventDisplayed.RunNumber + "Event number: " + EventDisplayed.EventNumber;

            LastKnownPathDisplay = new TextBox();
            setupTextDisplay(LastKnownPathDisplay);
            LastKnownPathDisplay.Text = "Last known file path: " + EventDisplayed.LastKnownFilePath;

            ElectronPtDisplay = new TextBox();
            setupTextDisplay(ElectronPtDisplay);
            ElectronPtDisplay.Text = String.Empty;

            ElectronEtaDisplay = new TextBox();
            setupTextDisplay(ElectronEtaDisplay);
            ElectronEtaDisplay.Text = String.Empty;

            if (EventDisplayed.HasElectrons)
            {
                ElectronPtDisplay.Text = "Electron transverse momenta: [";
                ElectronEtaDisplay.Text = "Electron pseudorapidities: [";
                ElectronPtDisplay.Text = fillList(ElectronPtDisplay.Text, EventDisplayed.ElectronPTs);
                ElectronEtaDisplay.Text = fillList(ElectronEtaDisplay.Text, EventDisplayed.ElectronEtas);
            }

            MuonPtDisplay = new TextBox();
            setupTextDisplay(MuonPtDisplay);
            MuonPtDisplay.Text = String.Empty;

            MuonEtaDisplay = new TextBox();
            setupTextDisplay(MuonEtaDisplay);
            MuonEtaDisplay.Text = String.Empty;

            if (EventDisplayed.HasMuons)
            {
                MuonPtDisplay.Text = "Muon transverse momenta: [";
                MuonEtaDisplay.Text = "Muon pseudorapidities: ";
                MuonPtDisplay.Text = fillList(MuonPtDisplay.Text, EventDisplayed.MuonPTs);
                MuonEtaDisplay.Text = fillList(MuonEtaDisplay.Text, EventDisplayed.MuonEtas);
            }
            
            EtMissingDisplay = new TextBox();
            setupTextDisplay(EtMissingDisplay);
            EtMissingDisplay.Text = "Missing energy: " + EventDisplayed.EtMissing;
        }

        //here

        private string fillList(string baseString, double[] valuesToAdd)
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

        private void setupTextDisplay(TextBox displayToSetup)
        {
            displayToSetup.ReadOnly = true;
            displayToSetup.BorderStyle = BorderStyle.None;
            displayToSetup.BackColor = this.BackColor;
        }
    }
}
