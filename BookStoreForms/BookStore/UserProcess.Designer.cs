namespace BookStoreForms
{
    partial class UserProcess
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
            this.lblAddBook = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemoveBook = new System.Windows.Forms.LinkLabel();
            this.lblDisplayClients = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.LinkColor = System.Drawing.Color.Black;
            this.lblAddBook.Location = new System.Drawing.Point(55, 88);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(93, 16);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.TabStop = true;
            this.lblAddBook.Text = "Add new book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select that you want to do !";
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.AutoSize = true;
            this.lblRemoveBook.LinkColor = System.Drawing.Color.Black;
            this.lblRemoveBook.Location = new System.Drawing.Point(55, 127);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Size = new System.Drawing.Size(93, 16);
            this.lblRemoveBook.TabIndex = 2;
            this.lblRemoveBook.TabStop = true;
            this.lblRemoveBook.Text = "Remove book";
            // 
            // lblDisplayClients
            // 
            this.lblDisplayClients.AutoSize = true;
            this.lblDisplayClients.LinkColor = System.Drawing.Color.Black;
            this.lblDisplayClients.Location = new System.Drawing.Point(55, 171);
            this.lblDisplayClients.Name = "lblDisplayClients";
            this.lblDisplayClients.Size = new System.Drawing.Size(111, 16);
            this.lblDisplayClients.TabIndex = 3;
            this.lblDisplayClients.TabStop = true;
            this.lblDisplayClients.Text = "Display all clients";
            this.lblDisplayClients.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDisplayClients_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(55, 216);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(68, 16);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(55, 261);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(68, 16);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel5";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(55, 307);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(68, 16);
            this.linkLabel6.TabIndex = 6;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "linkLabel6";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(55, 354);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(68, 16);
            this.linkLabel7.TabIndex = 7;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "linkLabel7";
            // 
            // UserProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 409);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.lblDisplayClients);
            this.Controls.Add(this.lblRemoveBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProcess";
            this.Text = "UserProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRemoveBook;
        private System.Windows.Forms.LinkLabel lblDisplayClients;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
    }
}