namespace BookStoreForms
{
    partial class AddNewBookSystem
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
            this.components = new System.ComponentModel.Container();
            this.bookName = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.writer = new System.Windows.Forms.Label();
            this.pageCount = new System.Windows.Forms.Label();
            this.exitAddNewBook = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttnAdd = new System.Windows.Forms.Button();
            this.labelNewBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName.Location = new System.Drawing.Point(54, 79);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(57, 18);
            this.bookName.TabIndex = 0;
            this.bookName.Text = "Name ";
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.publisher.Location = new System.Drawing.Point(54, 171);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(83, 18);
            this.publisher.TabIndex = 1;
            this.publisher.Text = "Publisher ";
            // 
            // writer
            // 
            this.writer.AutoSize = true;
            this.writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.writer.Location = new System.Drawing.Point(54, 122);
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(59, 18);
            this.writer.TabIndex = 2;
            this.writer.Text = "Writer ";
            // 
            // pageCount
            // 
            this.pageCount.AutoSize = true;
            this.pageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageCount.Location = new System.Drawing.Point(54, 216);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(101, 18);
            this.pageCount.TabIndex = 3;
            this.pageCount.Text = "Page Count ";
            // 
            // exitAddNewBook
            // 
            this.exitAddNewBook.BackgroundImage = global::BookStoreForms.Properties.Resources.çarpı;
            this.exitAddNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitAddNewBook.Location = new System.Drawing.Point(318, 0);
            this.exitAddNewBook.Name = "exitAddNewBook";
            this.exitAddNewBook.Size = new System.Drawing.Size(28, 28);
            this.exitAddNewBook.TabIndex = 4;
            this.exitAddNewBook.UseVisualStyleBackColor = true;
            this.exitAddNewBook.Click += new System.EventHandler(this.exitAddNewBook_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 79);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(167, 122);
            this.txtWriter.Multiline = true;
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(100, 22);
            this.txtWriter.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(167, 171);
            this.txtPublisher.Multiline = true;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 22);
            this.txtPublisher.TabIndex = 7;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(167, 215);
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 22);
            this.txtPage.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnAdd.Location = new System.Drawing.Point(119, 274);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 10;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // labelNewBook
            // 
            this.labelNewBook.AutoSize = true;
            this.labelNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNewBook.Location = new System.Drawing.Point(92, 30);
            this.labelNewBook.Name = "labelNewBook";
            this.labelNewBook.Size = new System.Drawing.Size(100, 18);
            this.labelNewBook.TabIndex = 12;
            this.labelNewBook.Text = "NEW BOOK";
            // 
            // AddNewBookSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 323);
            this.Controls.Add(this.labelNewBook);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.exitAddNewBook);
            this.Controls.Add(this.pageCount);
            this.Controls.Add(this.writer);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.bookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewBookSystem";
            this.Text = "AddNewBookSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.Label writer;
        private System.Windows.Forms.Label pageCount;
        private System.Windows.Forms.Button exitAddNewBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label labelNewBook;
    }
}