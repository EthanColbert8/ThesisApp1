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
                fillDisplay();
            }
        }

        public EventDisplayPanel()
        {
            BackColor = backgroundColor;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;

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
            BackColor = backgroundColor;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;

            EventRunNumberDisplay = new TextBox();
            setupTextDisplay(EventRunNumberDisplay);

            LastKnownPathDisplay = new TextBox();
            setupTextDisplay(LastKnownPathDisplay);

            ElectronPtDisplay = new TextBox();
            setupTextDisplay(ElectronPtDisplay);

            ElectronEtaDisplay = new TextBox();
            setupTextDisplay(ElectronEtaDisplay);

            MuonPtDisplay = new TextBox();
            setupTextDisplay(MuonPtDisplay);

            MuonEtaDisplay = new TextBox();
            setupTextDisplay(MuonEtaDisplay);
            
            EtMissingDisplay = new TextBox();
            setupTextDisplay(EtMissingDisplay);

            EventDisplayed = newEvent;
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

        private void fillDisplay()
        {
            EventRunNumberDisplay.Text = "Run number: " + EventDisplayed.RunNumber + "Event number: " + EventDisplayed.EventNumber;

            LastKnownPathDisplay.Text = "Last known file path: " + EventDisplayed.LastKnownFilePath;

            ElectronPtDisplay.Text = String.Empty;
            ElectronEtaDisplay.Text = String.Empty;
            if (EventDisplayed.HasElectrons)
            {
                ElectronPtDisplay.Text = "Electron transverse momenta: [";
                ElectronEtaDisplay.Text = "Electron pseudorapidities: [";
                ElectronPtDisplay.Text = fillList(ElectronPtDisplay.Text, EventDisplayed.ElectronPTs);
                ElectronEtaDisplay.Text = fillList(ElectronEtaDisplay.Text, EventDisplayed.ElectronEtas);
            }

            MuonPtDisplay.Text = String.Empty;
            MuonEtaDisplay.Text = String.Empty;
            if (EventDisplayed.HasMuons)
            {
                MuonPtDisplay.Text = "Muon transverse momenta: [";
                MuonEtaDisplay.Text = "Muon pseudorapidities: ";
                MuonPtDisplay.Text = fillList(MuonPtDisplay.Text, EventDisplayed.MuonPTs);
                MuonEtaDisplay.Text = fillList(MuonEtaDisplay.Text, EventDisplayed.MuonEtas);
            }

            EtMissingDisplay.Text = "Missing energy: " + EventDisplayed.EtMissing;
        }
    }
}
