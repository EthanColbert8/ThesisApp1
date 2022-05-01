
namespace ThesisApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAnalysisAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeAnalysesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.mergeButton = new System.Windows.Forms.Button();
            this.runAnalysisButton = new System.Windows.Forms.Button();
            this.mainTabSpace = new System.Windows.Forms.TabControl();
            this.analysisTab = new System.Windows.Forms.TabPage();
            this.execTimeLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.mainDisplayPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.mainTabSpace.SuspendLayout();
            this.analysisTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Main Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAnalysisToolStripMenuItem,
            this.openAnalysisToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAnalysisToolStripMenuItem,
            this.saveAnalysisAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newAnalysisToolStripMenuItem
            // 
            this.newAnalysisToolStripMenuItem.Name = "newAnalysisToolStripMenuItem";
            this.newAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newAnalysisToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.newAnalysisToolStripMenuItem.Text = "New Analysis";
            this.newAnalysisToolStripMenuItem.Click += new System.EventHandler(this.newAnalysisToolStripMenuItem_Click);
            // 
            // openAnalysisToolStripMenuItem
            // 
            this.openAnalysisToolStripMenuItem.Name = "openAnalysisToolStripMenuItem";
            this.openAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openAnalysisToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openAnalysisToolStripMenuItem.Text = "Open Analysis";
            this.openAnalysisToolStripMenuItem.Click += new System.EventHandler(this.openAnalysisToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // saveAnalysisToolStripMenuItem
            // 
            this.saveAnalysisToolStripMenuItem.Name = "saveAnalysisToolStripMenuItem";
            this.saveAnalysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAnalysisToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveAnalysisToolStripMenuItem.Text = "Save Analysis";
            this.saveAnalysisToolStripMenuItem.Click += new System.EventHandler(this.saveAnalysisToolStripMenuItem_Click);
            // 
            // saveAnalysisAsToolStripMenuItem
            // 
            this.saveAnalysisAsToolStripMenuItem.Name = "saveAnalysisAsToolStripMenuItem";
            this.saveAnalysisAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAnalysisAsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveAnalysisAsToolStripMenuItem.Text = "Save Analysis As";
            this.saveAnalysisAsToolStripMenuItem.Click += new System.EventHandler(this.saveAnalysisAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeAnalysesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mergeAnalysesToolStripMenuItem
            // 
            this.mergeAnalysesToolStripMenuItem.Name = "mergeAnalysesToolStripMenuItem";
            this.mergeAnalysesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mergeAnalysesToolStripMenuItem.Text = "Merge Analyses";
            this.mergeAnalysesToolStripMenuItem.Click += new System.EventHandler(this.mergeAnalysesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolsPanel.Controls.Add(this.mergeButton);
            this.toolsPanel.Controls.Add(this.runAnalysisButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(150, 426);
            this.toolsPanel.TabIndex = 1;
            // 
            // mergeButton
            // 
            this.mergeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mergeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeButton.Location = new System.Drawing.Point(25, 100);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(100, 50);
            this.mergeButton.TabIndex = 1;
            this.mergeButton.Text = "Merge Analyses";
            this.mergeButton.UseVisualStyleBackColor = false;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // runAnalysisButton
            // 
            this.runAnalysisButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.runAnalysisButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runAnalysisButton.Location = new System.Drawing.Point(25, 25);
            this.runAnalysisButton.Name = "runAnalysisButton";
            this.runAnalysisButton.Size = new System.Drawing.Size(100, 50);
            this.runAnalysisButton.TabIndex = 0;
            this.runAnalysisButton.Text = "Run New Analysis";
            this.runAnalysisButton.UseVisualStyleBackColor = false;
            this.runAnalysisButton.Click += new System.EventHandler(this.runAnalysisButton_Click);
            // 
            // mainTabSpace
            // 
            this.mainTabSpace.Controls.Add(this.analysisTab);
            this.mainTabSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSpace.Location = new System.Drawing.Point(150, 24);
            this.mainTabSpace.Name = "mainTabSpace";
            this.mainTabSpace.SelectedIndex = 0;
            this.mainTabSpace.Size = new System.Drawing.Size(650, 426);
            this.mainTabSpace.TabIndex = 2;
            // 
            // analysisTab
            // 
            this.analysisTab.AutoScroll = true;
            this.analysisTab.Controls.Add(this.mainDisplayPanel);
            this.analysisTab.Controls.Add(this.execTimeLabel);
            this.analysisTab.Controls.Add(this.outputLabel);
            this.analysisTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisTab.Location = new System.Drawing.Point(4, 22);
            this.analysisTab.Name = "analysisTab";
            this.analysisTab.Padding = new System.Windows.Forms.Padding(3);
            this.analysisTab.Size = new System.Drawing.Size(642, 400);
            this.analysisTab.TabIndex = 0;
            this.analysisTab.Text = "Current Analysis";
            this.analysisTab.UseVisualStyleBackColor = true;
            // 
            // execTimeLabel
            // 
            this.execTimeLabel.AutoSize = true;
            this.execTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execTimeLabel.Location = new System.Drawing.Point(6, 3);
            this.execTimeLabel.Name = "execTimeLabel";
            this.execTimeLabel.Size = new System.Drawing.Size(290, 21);
            this.execTimeLabel.TabIndex = 1;
            this.execTimeLabel.Text = "Analysis execution time will appear here.";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(6, 34);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(178, 21);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Results will appear here.";
            // 
            // mainDisplayPanel
            // 
            this.mainDisplayPanel.AutoScroll = true;
            this.mainDisplayPanel.AutoSize = true;
            this.mainDisplayPanel.Location = new System.Drawing.Point(6, 60);
            this.mainDisplayPanel.Name = "mainDisplayPanel";
            this.mainDisplayPanel.Size = new System.Drawing.Size(600, 300);
            this.mainDisplayPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabSpace);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "ATLAS Automated Analysis";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.mainTabSpace.ResumeLayout(false);
            this.analysisTab.ResumeLayout(false);
            this.analysisTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAnalysisAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeAnalysesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.TabControl mainTabSpace;
        private System.Windows.Forms.TabPage analysisTab;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button runAnalysisButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Label execTimeLabel;
        private System.Windows.Forms.Panel mainDisplayPanel;
    }
}

