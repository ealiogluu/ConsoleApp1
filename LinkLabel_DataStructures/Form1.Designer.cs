namespace LinkLabel_DataStructures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cDriveLinkLabel = new LinkLabel();
            deitelLinkLabel = new LinkLabel();
            notepadLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // cDriveLinkLabel
            // 
            cDriveLinkLabel.AutoSize = true;
            cDriveLinkLabel.Location = new Point(64, 54);
            cDriveLinkLabel.Name = "cDriveLinkLabel";
            cDriveLinkLabel.Size = new Size(76, 20);
            cDriveLinkLabel.TabIndex = 0;
            cDriveLinkLabel.TabStop = true;
            cDriveLinkLabel.Text = "linkLabel1";
            cDriveLinkLabel.LinkClicked += cDriveLinkLabel_LinkClicked;
            // 
            // deitelLinkLabel
            // 
            deitelLinkLabel.AutoSize = true;
            deitelLinkLabel.Location = new Point(104, 166);
            deitelLinkLabel.Name = "deitelLinkLabel";
            deitelLinkLabel.Size = new Size(76, 20);
            deitelLinkLabel.TabIndex = 1;
            deitelLinkLabel.TabStop = true;
            deitelLinkLabel.Text = "linkLabel2";
            deitelLinkLabel.LinkClicked += deitelLinkLabel_LinkClicked;
            // 
            // notepadLinkLabel
            // 
            notepadLinkLabel.AutoSize = true;
            notepadLinkLabel.Location = new Point(129, 252);
            notepadLinkLabel.Name = "notepadLinkLabel";
            notepadLinkLabel.Size = new Size(76, 20);
            notepadLinkLabel.TabIndex = 2;
            notepadLinkLabel.TabStop = true;
            notepadLinkLabel.Text = "linkLabel3";
            notepadLinkLabel.LinkClicked += notepadLinkLabel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notepadLinkLabel);
            Controls.Add(deitelLinkLabel);
            Controls.Add(cDriveLinkLabel);
            Name = "Form1";
            Text = "ödev";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel cDriveLinkLabel;
        private LinkLabel deitelLinkLabel;
        private LinkLabel notepadLinkLabel;
    }
}
