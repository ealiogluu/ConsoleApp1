namespace LinkLabelDataStructures
{
    partial class Form1
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
            this.cDriveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notepadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cDriveLinkLabel
            // 
            this.cDriveLinkLabel.AutoSize = true;
            this.cDriveLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDriveLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cDriveLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.cDriveLinkLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cDriveLinkLabel.Name = "cDriveLinkLabel";
            this.cDriveLinkLabel.Size = new System.Drawing.Size(224, 29);
            this.cDriveLinkLabel.TabIndex = 0;
            this.cDriveLinkLabel.TabStop = true;
            this.cDriveLinkLabel.Text = "Click to browse C:\\";
            this.cDriveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cDriveLinkLabel_LinkClicked);
            // 
            // deitelLinkLabel
            // 
            this.deitelLinkLabel.AutoSize = true;
            this.deitelLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deitelLinkLabel.Location = new System.Drawing.Point(0, 67);
            this.deitelLinkLabel.Name = "deitelLinkLabel";
            this.deitelLinkLabel.Size = new System.Drawing.Size(334, 29);
            this.deitelLinkLabel.TabIndex = 1;
            this.deitelLinkLabel.TabStop = true;
            this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
            this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);
            // 
            // notepadLinkLabel
            // 
            this.notepadLinkLabel.AutoSize = true;
            this.notepadLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notepadLinkLabel.Location = new System.Drawing.Point(0, 136);
            this.notepadLinkLabel.Name = "notepadLinkLabel";
            this.notepadLinkLabel.Size = new System.Drawing.Size(242, 29);
            this.notepadLinkLabel.TabIndex = 2;
            this.notepadLinkLabel.TabStop = true;
            this.notepadLinkLabel.Text = "Click to run Notepad";
            this.notepadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notepadLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.notepadLinkLabel);
            this.Controls.Add(this.deitelLinkLabel);
            this.Controls.Add(this.cDriveLinkLabel);
            this.Name = "Form1";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel cDriveLinkLabel;
        private System.Windows.Forms.LinkLabel deitelLinkLabel;
        private System.Windows.Forms.LinkLabel notepadLinkLabel;
    }
}

