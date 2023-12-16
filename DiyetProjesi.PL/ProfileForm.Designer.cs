namespace DiyetProjesi.PL
{
    partial class ProfileForm
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
            btnSignUp = new Button();
            txtKey = new TextBox();
            txtEmail = new TextBox();
            Label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nudWeigth = new NumericUpDown();
            btnUpdate = new Button();
            label7 = new Label();
            nudAge = new NumericUpDown();
            cmbGender = new ComboBox();
            lbLDif = new Label();
            ((System.ComponentModel.ISupportInitialize)nudWeigth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(77, 341);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "KAYDOL";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(68, 276);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(165, 23);
            txtKey.TabIndex = 6;
            txtKey.TextChanged += txtKey_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 23);
            txtEmail.TabIndex = 5;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(15, 279);
            Label2.Name = "Label2";
            Label2.Size = new Size(30, 15);
            Label2.TabIndex = 3;
            Label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 236);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 28);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 4;
            label3.Text = "Ad";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(69, 25);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(165, 23);
            txtFirstName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 68);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Soyad";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(69, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(165, 23);
            txtLastName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 148);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 190);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 4;
            label6.Text = "Kilo";
            // 
            // nudWeigth
            // 
            nudWeigth.Location = new Point(70, 188);
            nudWeigth.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudWeigth.Name = "nudWeigth";
            nudWeigth.Size = new Size(164, 23);
            nudWeigth.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(158, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 107);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 4;
            label7.Text = "Yaş";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(70, 105);
            nudAge.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(164, 23);
            nudAge.TabIndex = 2;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbGender.Location = new Point(69, 145);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(164, 23);
            cmbGender.TabIndex = 3;
            // 
            // lbLDif
            // 
            lbLDif.AutoSize = true;
            lbLDif.BackColor = SystemColors.Control;
            lbLDif.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbLDif.Location = new Point(188, 302);
            lbLDif.Name = "lbLDif";
            lbLDif.Size = new Size(0, 17);
            lbLDif.TabIndex = 9;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 403);
            Controls.Add(lbLDif);
            Controls.Add(cmbGender);
            Controls.Add(nudAge);
            Controls.Add(nudWeigth);
            Controls.Add(btnUpdate);
            Controls.Add(btnSignUp);
            Controls.Add(txtKey);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(Label2);
            Controls.Add(label1);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniUyelikForm";
            ((System.ComponentModel.ISupportInitialize)nudWeigth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignUp;
        private TextBox txtKey;
        private TextBox txtEmail;
        private Label Label2;
        private Label label1;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private NumericUpDown nudWeigth;
        private Button btnUpdate;
        private Label label7;
        private NumericUpDown nudAge;
        private ComboBox cmbGender;
        private Label lbLDif;
    }
}