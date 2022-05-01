namespace ThesisApp1
{
    partial class cutSelectionForm
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
            this.muonPtSelectOptionBox = new System.Windows.Forms.CheckBox();
            this.muonPtInputBox = new System.Windows.Forms.TextBox();
            this.muonEtaSelectOptionBox = new System.Windows.Forms.CheckBox();
            this.muonEtaInputBox = new System.Windows.Forms.TextBox();
            this.muonLabel = new System.Windows.Forms.Label();
            this.electronLabel = new System.Windows.Forms.Label();
            this.electronEtaInputBox = new System.Windows.Forms.TextBox();
            this.electronEtaSelectOptionBox = new System.Windows.Forms.CheckBox();
            this.electronPtInputBox = new System.Windows.Forms.TextBox();
            this.electronPtSelectOptionBox = new System.Windows.Forms.CheckBox();
            this.eventLabel = new System.Windows.Forms.Label();
            this.etMissingSelectOptionBox = new System.Windows.Forms.CheckBox();
            this.etMissingInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // muonPtSelectOptionBox
            // 
            this.muonPtSelectOptionBox.AutoSize = true;
            this.muonPtSelectOptionBox.Location = new System.Drawing.Point(41, 74);
            this.muonPtSelectOptionBox.Name = "muonPtSelectOptionBox";
            this.muonPtSelectOptionBox.Size = new System.Drawing.Size(143, 17);
            this.muonPtSelectOptionBox.TabIndex = 0;
            this.muonPtSelectOptionBox.Text = "Transverse Momentum >";
            this.muonPtSelectOptionBox.UseVisualStyleBackColor = true;
            // 
            // muonPtInputBox
            // 
            this.muonPtInputBox.Enabled = false;
            this.muonPtInputBox.Location = new System.Drawing.Point(181, 74);
            this.muonPtInputBox.Name = "muonPtInputBox";
            this.muonPtInputBox.Size = new System.Drawing.Size(100, 20);
            this.muonPtInputBox.TabIndex = 1;
            this.muonPtInputBox.Text = "0.0";
            // 
            // muonEtaSelectOptionBox
            // 
            this.muonEtaSelectOptionBox.AutoSize = true;
            this.muonEtaSelectOptionBox.Location = new System.Drawing.Point(41, 114);
            this.muonEtaSelectOptionBox.Name = "muonEtaSelectOptionBox";
            this.muonEtaSelectOptionBox.Size = new System.Drawing.Size(104, 17);
            this.muonEtaSelectOptionBox.TabIndex = 2;
            this.muonEtaSelectOptionBox.Text = "Pseudorapidity <";
            this.muonEtaSelectOptionBox.UseVisualStyleBackColor = true;
            // 
            // muonEtaInputBox
            // 
            this.muonEtaInputBox.Enabled = false;
            this.muonEtaInputBox.Location = new System.Drawing.Point(181, 114);
            this.muonEtaInputBox.Name = "muonEtaInputBox";
            this.muonEtaInputBox.Size = new System.Drawing.Size(100, 20);
            this.muonEtaInputBox.TabIndex = 3;
            this.muonEtaInputBox.Text = "0.0";
            // 
            // muonLabel
            // 
            this.muonLabel.AutoSize = true;
            this.muonLabel.Location = new System.Drawing.Point(131, 40);
            this.muonLabel.Name = "muonLabel";
            this.muonLabel.Size = new System.Drawing.Size(76, 13);
            this.muonLabel.TabIndex = 4;
            this.muonLabel.Text = "Muon Channel";
            // 
            // electronLabel
            // 
            this.electronLabel.AutoSize = true;
            this.electronLabel.Location = new System.Drawing.Point(443, 40);
            this.electronLabel.Name = "electronLabel";
            this.electronLabel.Size = new System.Drawing.Size(88, 13);
            this.electronLabel.TabIndex = 9;
            this.electronLabel.Text = "Electron Channel";
            // 
            // electronEtaInputBox
            // 
            this.electronEtaInputBox.Enabled = false;
            this.electronEtaInputBox.Location = new System.Drawing.Point(493, 114);
            this.electronEtaInputBox.Name = "electronEtaInputBox";
            this.electronEtaInputBox.Size = new System.Drawing.Size(100, 20);
            this.electronEtaInputBox.TabIndex = 8;
            this.electronEtaInputBox.Text = "0.0";
            // 
            // electronEtaSelectOptionBox
            // 
            this.electronEtaSelectOptionBox.AutoSize = true;
            this.electronEtaSelectOptionBox.Location = new System.Drawing.Point(353, 114);
            this.electronEtaSelectOptionBox.Name = "electronEtaSelectOptionBox";
            this.electronEtaSelectOptionBox.Size = new System.Drawing.Size(104, 17);
            this.electronEtaSelectOptionBox.TabIndex = 7;
            this.electronEtaSelectOptionBox.Text = "Pseudorapidity <";
            this.electronEtaSelectOptionBox.UseVisualStyleBackColor = true;
            // 
            // electronPtInputBox
            // 
            this.electronPtInputBox.Enabled = false;
            this.electronPtInputBox.Location = new System.Drawing.Point(493, 74);
            this.electronPtInputBox.Name = "electronPtInputBox";
            this.electronPtInputBox.Size = new System.Drawing.Size(100, 20);
            this.electronPtInputBox.TabIndex = 6;
            this.electronPtInputBox.Text = "0.0";
            // 
            // electronPtSelectOptionBox
            // 
            this.electronPtSelectOptionBox.AutoSize = true;
            this.electronPtSelectOptionBox.Location = new System.Drawing.Point(353, 74);
            this.electronPtSelectOptionBox.Name = "electronPtSelectOptionBox";
            this.electronPtSelectOptionBox.Size = new System.Drawing.Size(143, 17);
            this.electronPtSelectOptionBox.TabIndex = 5;
            this.electronPtSelectOptionBox.Text = "Transverse Momentum >";
            this.electronPtSelectOptionBox.UseVisualStyleBackColor = true;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Location = new System.Drawing.Point(320, 215);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(35, 13);
            this.eventLabel.TabIndex = 10;
            this.eventLabel.Text = "Event";
            // 
            // etMissingSelectOptionBox
            // 
            this.etMissingSelectOptionBox.AutoSize = true;
            this.etMissingSelectOptionBox.Location = new System.Drawing.Point(228, 259);
            this.etMissingSelectOptionBox.Name = "etMissingSelectOptionBox";
            this.etMissingSelectOptionBox.Size = new System.Drawing.Size(106, 17);
            this.etMissingSelectOptionBox.TabIndex = 11;
            this.etMissingSelectOptionBox.Text = "Missing Energy <";
            this.etMissingSelectOptionBox.UseVisualStyleBackColor = true;
            // 
            // etMissingInputBox
            // 
            this.etMissingInputBox.Enabled = false;
            this.etMissingInputBox.Location = new System.Drawing.Point(353, 259);
            this.etMissingInputBox.Name = "etMissingInputBox";
            this.etMissingInputBox.Size = new System.Drawing.Size(100, 20);
            this.etMissingInputBox.TabIndex = 12;
            this.etMissingInputBox.Text = "0.0";
            // 
            // cutSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.etMissingInputBox);
            this.Controls.Add(this.etMissingSelectOptionBox);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.electronLabel);
            this.Controls.Add(this.electronEtaInputBox);
            this.Controls.Add(this.electronEtaSelectOptionBox);
            this.Controls.Add(this.electronPtInputBox);
            this.Controls.Add(this.electronPtSelectOptionBox);
            this.Controls.Add(this.muonLabel);
            this.Controls.Add(this.muonEtaInputBox);
            this.Controls.Add(this.muonEtaSelectOptionBox);
            this.Controls.Add(this.muonPtInputBox);
            this.Controls.Add(this.muonPtSelectOptionBox);
            this.Name = "cutSelectionForm";
            this.Text = "Select Cuts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox muonPtSelectOptionBox;
        private System.Windows.Forms.TextBox muonPtInputBox;
        private System.Windows.Forms.CheckBox muonEtaSelectOptionBox;
        private System.Windows.Forms.TextBox muonEtaInputBox;
        private System.Windows.Forms.Label muonLabel;
        private System.Windows.Forms.Label electronLabel;
        private System.Windows.Forms.TextBox electronEtaInputBox;
        private System.Windows.Forms.CheckBox electronEtaSelectOptionBox;
        private System.Windows.Forms.TextBox electronPtInputBox;
        private System.Windows.Forms.CheckBox electronPtSelectOptionBox;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.CheckBox etMissingSelectOptionBox;
        private System.Windows.Forms.TextBox etMissingInputBox;
    }
}