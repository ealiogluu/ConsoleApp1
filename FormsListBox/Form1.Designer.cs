namespace FormsListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Isim = new System.Windows.Forms.TextBox();
            this.EklemeButonu = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelIsim = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "EMİNE",
            "YARWN",
            "FATMA"});
            this.listBox1.Location = new System.Drawing.Point(25, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Isim
            // 
            this.Isim.Location = new System.Drawing.Point(51, 256);
            this.Isim.Name = "Isim";
            this.Isim.Size = new System.Drawing.Size(267, 22);
            this.Isim.TabIndex = 1;
            // 
            // EklemeButonu
            // 
            this.EklemeButonu.Location = new System.Drawing.Point(131, 313);
            this.EklemeButonu.Name = "EklemeButonu";
            this.EklemeButonu.Size = new System.Drawing.Size(89, 36);
            this.EklemeButonu.TabIndex = 2;
            this.EklemeButonu.Text = "Ekle";
            this.EklemeButonu.UseVisualStyleBackColor = true;
            this.EklemeButonu.Click += new System.EventHandler(this.EklemeButonu_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(533, 256);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(0, 16);
            this.labelIndex.TabIndex = 3;
            // 
            // labelIsim
            // 
            this.labelIsim.AutoSize = true;
            this.labelIsim.Location = new System.Drawing.Point(533, 313);
            this.labelIsim.Name = "labelIsim";
            this.labelIsim.Size = new System.Drawing.Size(0, 16);
            this.labelIsim.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(493, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ahmet";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(493, 179);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mehmet";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(493, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Celil";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 420);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelIsim);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.EklemeButonu);
            this.Controls.Add(this.Isim);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Isim;
        private System.Windows.Forms.Button EklemeButonu;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelIsim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

