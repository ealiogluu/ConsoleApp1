namespace BookStoreForms
{
    partial class FormSignUp
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.exitSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(116, 101);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 31);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "User Name";
            this.txtUserName.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.txtUserName.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(116, 261);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "*";
            this.txtPassword.Text = "Password";
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Silver;
            this.txtPhoneNumber.Location = new System.Drawing.Point(116, 205);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(121, 31);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.MouseEnter += new System.EventHandler(this.txtPhoneNumber_MouseEnter);
            this.txtPhoneNumber.MouseLeave += new System.EventHandler(this.txtPhoneNumber_MouseLeave);
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdress.ForeColor = System.Drawing.Color.Silver;
            this.txtAdress.Location = new System.Drawing.Point(116, 155);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(121, 30);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.Text = "Adress";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.Location = new System.Drawing.Point(137, 316);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(82, 48);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(116, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 30);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Name";
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // exitSignUp
            // 
            this.exitSignUp.BackgroundImage = global::BookStoreForms.Properties.Resources.çarpı;
            this.exitSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitSignUp.Location = new System.Drawing.Point(346, 0);
            this.exitSignUp.Name = "exitSignUp";
            this.exitSignUp.Size = new System.Drawing.Size(28, 28);
            this.exitSignUp.TabIndex = 6;
            this.exitSignUp.UseVisualStyleBackColor = true;
            this.exitSignUp.Click += new System.EventHandler(this.exitSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sign Up";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitSignUp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button exitSignUp;
        private System.Windows.Forms.Label label2;
    }
}