namespace BookStoreForms
{
    partial class EmployeeMenu
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
            this.lblDisplayBooks = new System.Windows.Forms.LinkLabel();
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            this.lblremoveclient = new System.Windows.Forms.LinkLabel();
            this.lblNewClient = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.LinkColor = System.Drawing.Color.Black;
            this.lblAddBook.Location = new System.Drawing.Point(55, 88);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(76, 13);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.TabStop = true;
            this.lblAddBook.Text = "Add new book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processes";
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.AutoSize = true;
            this.lblRemoveBook.LinkColor = System.Drawing.Color.Black;
            this.lblRemoveBook.Location = new System.Drawing.Point(55, 127);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Size = new System.Drawing.Size(74, 13);
            this.lblRemoveBook.TabIndex = 2;
            this.lblRemoveBook.TabStop = true;
            this.lblRemoveBook.Text = "Remove book";
            this.lblRemoveBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemoveBook_LinkClicked);
            // 
            // lblDisplayClients
            // 
            this.lblDisplayClients.AutoSize = true;
            this.lblDisplayClients.LinkColor = System.Drawing.Color.Black;
            this.lblDisplayClients.Location = new System.Drawing.Point(55, 171);
            this.lblDisplayClients.Name = "lblDisplayClients";
            this.lblDisplayClients.Size = new System.Drawing.Size(87, 13);
            this.lblDisplayClients.TabIndex = 3;
            this.lblDisplayClients.TabStop = true;
            this.lblDisplayClients.Text = "Display all clients";
            // 
            // lblDisplayBooks
            // 
            this.lblDisplayBooks.AutoSize = true;
            this.lblDisplayBooks.LinkColor = System.Drawing.Color.Black;
            this.lblDisplayBooks.Location = new System.Drawing.Point(55, 216);
            this.lblDisplayBooks.Name = "lblDisplayBooks";
            this.lblDisplayBooks.Size = new System.Drawing.Size(86, 13);
            this.lblDisplayBooks.TabIndex = 4;
            this.lblDisplayBooks.TabStop = true;
            this.lblDisplayBooks.Text = "Display all books";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.LinkColor = System.Drawing.Color.Black;
            this.lblRemove.Location = new System.Drawing.Point(55, 261);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(75, 13);
            this.lblRemove.TabIndex = 5;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove Book";
            // 
            // lblremoveclient
            // 
            this.lblremoveclient.AutoSize = true;
            this.lblremoveclient.LinkColor = System.Drawing.Color.Black;
            this.lblremoveclient.Location = new System.Drawing.Point(55, 307);
            this.lblremoveclient.Name = "lblremoveclient";
            this.lblremoveclient.Size = new System.Drawing.Size(75, 13);
            this.lblremoveclient.TabIndex = 6;
            this.lblremoveclient.TabStop = true;
            this.lblremoveclient.Text = "Remove client";
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.LinkColor = System.Drawing.Color.Black;
            this.lblNewClient.Location = new System.Drawing.Point(55, 354);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(77, 13);
            this.lblNewClient.TabIndex = 7;
            this.lblNewClient.TabStop = true;
            this.lblNewClient.Text = "Add new client";
            this.lblNewClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewClient_LinkClicked);
            // 
            // EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 409);
            this.Controls.Add(this.lblNewClient);
            this.Controls.Add(this.lblremoveclient);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblDisplayBooks);
            this.Controls.Add(this.lblDisplayClients);
            this.Controls.Add(this.lblRemoveBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeMenu";
            this.Text = "UserProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRemoveBook;
        private System.Windows.Forms.LinkLabel lblDisplayClients;
        private System.Windows.Forms.LinkLabel lblDisplayBooks;
        private System.Windows.Forms.LinkLabel lblRemove;
        private System.Windows.Forms.LinkLabel lblremoveclient;
        private System.Windows.Forms.LinkLabel lblNewClient;
    }
}