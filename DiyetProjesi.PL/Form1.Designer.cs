namespace DiyetProjesi.PL
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
            label1 = new Label();
            txtEmail = new TextBox();
            Label2 = new Label();
            txtKey = new TextBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 23);
            txtEmail.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(24, 79);
            Label2.Name = "Label2";
            Label2.Size = new Size(30, 15);
            Label2.TabIndex = 0;
            Label2.Text = "Şifre";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(81, 76);
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '*';
            txtKey.Size = new Size(165, 23);
            txtKey.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(81, 123);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(59, 23);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "GİRİŞ";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(146, 123);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(100, 23);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "YENİ ÜYELİK";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 174);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtKey);
            Controls.Add(txtEmail);
            Controls.Add(Label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label Label2;
        private TextBox txtKey;
        private Button btnSignIn;
        private Button btnSignUp;
    }
}
