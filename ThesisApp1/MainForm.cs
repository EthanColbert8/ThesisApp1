using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ThesisApp1
{
    public partial class MainForm : Form
    {

        private AnalysisList currentAnalysis;

        public MainForm()
        {
            InitializeComponent();
        }

        //defines what is done if an error is encountered
        //use to ensure uniform error handling behavior across all buttons
        private void StandardErrorResponse(Exception e)
        {
            outputLabel.Text = "Results will appear here.";
            execTimeLabel.Text = "Analysis execution time will appear here.";
            //outputLabel.Text = e.InnerException.Message;
            MessageBox.Show(e.Message);
        }

        private void newAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog loadDialog = new FolderBrowserDialog();
                loadDialog.RootFolder = Environment.SpecialFolder.UserProfile;
                loadDialog.Description = "Select Folder Containing Data";
                loadDialog.ShowDialog();

                if (!(loadDialog.SelectedPath.Equals("")))
                {
                    Stopwatch timer = new Stopwatch();
                    timer.Start();

                    AnalysisList analysis = new AnalysisList(loadDialog.SelectedPath);
                    analysis.RunAnalysis();
                    currentAnalysis = analysis;

                    timer.Stop();

                    outputLabel.Text = currentAnalysis.ToString();
                    execTimeLabel.Text = "Analysis execution time: " + (((double)timer.ElapsedMilliseconds) / 1000.0) + " seconds";
                }

            }
            catch (Exception ex)
            {
                StandardErrorResponse(ex);
            }
        }

        private void openAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog loadDialog = new OpenFileDialog();
                loadDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                loadDialog.Filter = "XML File|*.xml|All Files|*.*";
                loadDialog.Title = "Open Analysis";
                loadDialog.ShowDialog();

                if (!(loadDialog.FileName.Equals("")))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(AnalysisList));
                    StreamReader fileToRead = new StreamReader(loadDialog.FileName);

                    currentAnalysis = (AnalysisList)reader.Deserialize(fileToRead);

                    fileToRead.Close();

                    outputLabel.Text = currentAnalysis.ToString();
                }
            }
            catch (Exception ex)
            {
                StandardErrorResponse(ex);
            }
        }

        private void saveAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(currentAnalysis.FileSavedIn.Equals("")))
                {
                    XmlSerializer writer = new XmlSerializer(typeof(AnalysisList));
                    FileStream fileToSave = File.Create(currentAnalysis.FileSavedIn);

                    writer.Serialize(fileToSave, currentAnalysis);

                    fileToSave.Close();
                }
                else
                {
                    saveAnalysisAsToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                StandardErrorResponse(ex);
            }
        }

        private void saveAnalysisAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XML File|*.xml|All Files|*.*";
                saveDialog.Title = "Save Analysis As";
                saveDialog.ShowDialog();

                if (!(saveDialog.FileName.Equals("")))
                {
                    XmlSerializer writer = new XmlSerializer(typeof(AnalysisList));
                    FileStream fileToSave = (FileStream)saveDialog.OpenFile();

                    writer.Serialize(fileToSave, currentAnalysis);

                    fileToSave.Close();
                }
                else
                {
                    MessageBox.Show("Oops! Please enter a valid file name to save.");
                }

            }
            catch (Exception ex)
            {
                StandardErrorResponse(ex);
            }
        }

        private void mergeAnalysesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function has not yet been implemented.");
        }

        private void runAnalysisButton_Click(object sender, EventArgs e)
        {
            newAnalysisToolStripMenuItem_Click(sender, e);
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            mergeAnalysesToolStripMenuItem_Click(sender, e);
        }
    }
}
