namespace BookStoreForms.UserForms
{
    partial class Main
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblBookStore = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtBasket = new System.Windows.Forms.TextBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Basket = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkNovel = new System.Windows.Forms.CheckBox();
            this.chkPoem = new System.Windows.Forms.CheckBox();
            this.chkStory = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(404, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(616, 47);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "g";
            // 
            // lblBookStore
            // 
            this.lblBookStore.AutoSize = true;
            this.lblBookStore.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStore.Location = new System.Drawing.Point(16, 16);
            this.lblBookStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookStore.Name = "lblBookStore";
            this.lblBookStore.Size = new System.Drawing.Size(227, 49);
            this.lblBookStore.TabIndex = 1;
            this.lblBookStore.Text = "Book Store";
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 16;
            this.listBooks.Location = new System.Drawing.Point(159, 194);
            this.listBooks.Margin = new System.Windows.Forms.Padding(4);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(519, 452);
            this.listBooks.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(1177, 16);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(133, 62);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(1319, 16);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(133, 62);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtBasket
            // 
            this.txtBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasket.ForeColor = System.Drawing.Color.Silver;
            this.txtBasket.Location = new System.Drawing.Point(1507, 274);
            this.txtBasket.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasket.Multiline = true;
            this.txtBasket.Name = "txtBasket";
            this.txtBasket.Size = new System.Drawing.Size(81, 19);
            this.txtBasket.TabIndex = 9;
            this.txtBasket.Text = "0";
            this.txtBasket.TextChanged += new System.EventHandler(this.txtBasket_TextChanged);
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblGenres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenres.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.White;
            this.lblGenres.Location = new System.Drawing.Point(25, 194);
            this.lblGenres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(69, 27);
            this.lblGenres.TabIndex = 16;
            this.lblGenres.Text = "Genre";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAccount.Location = new System.Drawing.Point(1477, 142);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(119, 20);
            this.lblAccount.TabIndex = 17;
            this.lblAccount.Text = "     Account   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookStoreForms.Properties.Resources.indir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1507, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Basket
            // 
            this.Basket.BackgroundImage = global::BookStoreForms.Properties.Resources.basket;
            this.Basket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Basket.Location = new System.Drawing.Point(1507, 203);
            this.Basket.Margin = new System.Windows.Forms.Padding(4);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(81, 59);
            this.Basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Basket.TabIndex = 8;
            this.Basket.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::BookStoreForms.Properties.Resources.çarpı;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1571, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::BookStoreForms.Properties.Resources.images__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(1029, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 48);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkNovel
            // 
            this.chkNovel.AutoSize = true;
            this.chkNovel.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNovel.Location = new System.Drawing.Point(25, 241);
            this.chkNovel.Margin = new System.Windows.Forms.Padding(4);
            this.chkNovel.Name = "chkNovel";
            this.chkNovel.Size = new System.Drawing.Size(66, 22);
            this.chkNovel.TabIndex = 19;
            this.chkNovel.Text = "Novel";
            this.chkNovel.UseVisualStyleBackColor = true;
            // 
            // chkPoem
            // 
            this.chkPoem.AutoSize = true;
            this.chkPoem.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPoem.Location = new System.Drawing.Point(25, 276);
            this.chkPoem.Margin = new System.Windows.Forms.Padding(4);
            this.chkPoem.Name = "chkPoem";
            this.chkPoem.Size = new System.Drawing.Size(65, 22);
            this.chkPoem.TabIndex = 20;
            this.chkPoem.Text = "Poem";
            this.chkPoem.UseVisualStyleBackColor = true;
            // 
            // chkStory
            // 
            this.chkStory.AutoSize = true;
            this.chkStory.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStory.Location = new System.Drawing.Point(25, 315);
            this.chkStory.Margin = new System.Windows.Forms.Padding(4);
            this.chkStory.Name = "chkStory";
            this.chkStory.Size = new System.Drawing.Size(66, 22);
            this.chkStory.TabIndex = 21;
            this.chkStory.Text = "Story";
            this.chkStory.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 780);
            this.Controls.Add(this.chkStory);
            this.Controls.Add(this.chkPoem);
            this.Controls.Add(this.chkNovel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.txtBasket);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBookStore);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "DisplayAllBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblBookStore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox Basket;
        private System.Windows.Forms.TextBox txtBasket;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkNovel;
        private System.Windows.Forms.CheckBox chkPoem;
        private System.Windows.Forms.CheckBox chkStory;
    }
}