namespace DiyetProjesi.PL.User
{
    partial class UserHomeForm
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
            btnRepast = new Button();
            btnReport = new Button();
            btnUserUpdate = new Button();
            lblUser = new Label();
            btnAddActivity = new Button();
            SuspendLayout();
            // 
            // btnRepast
            // 
            btnRepast.Location = new Point(120, 140);
            btnRepast.Margin = new Padding(3, 4, 3, 4);
            btnRepast.Name = "btnRepast";
            btnRepast.Size = new Size(150, 31);
            btnRepast.TabIndex = 1;
            btnRepast.Text = "ÖĞÜN EKLE";
            btnRepast.UseVisualStyleBackColor = true;
            btnRepast.Click += btnRepast_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(120, 253);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 31);
            btnReport.TabIndex = 3;
            btnReport.Text = "GÜN SONU RAPORU";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnUserUpdate
            // 
            btnUserUpdate.Location = new Point(120, 84);
            btnUserUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUserUpdate.Name = "btnUserUpdate";
            btnUserUpdate.Size = new Size(150, 31);
            btnUserUpdate.TabIndex = 0;
            btnUserUpdate.Text = "PROFİL GÜNCELLE";
            btnUserUpdate.UseVisualStyleBackColor = true;
            btnUserUpdate.Click += btnUserUpdate_Click;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(104, 31);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(181, 31);
            lblUser.TabIndex = 1;
            lblUser.Text = "label1";
            // 
            // btnAddActivity
            // 
            btnAddActivity.Location = new Point(120, 196);
            btnAddActivity.Margin = new Padding(3, 4, 3, 4);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Size = new Size(150, 31);
            btnAddActivity.TabIndex = 2;
            btnAddActivity.Text = "AKTİVİTE EKLE";
            btnAddActivity.UseVisualStyleBackColor = true;
            btnAddActivity.Click += btnAddActivity_Click;
            // 
            // UserHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 316);
            Controls.Add(lblUser);
            Controls.Add(btnUserUpdate);
            Controls.Add(btnReport);
            Controls.Add(btnAddActivity);
            Controls.Add(btnRepast);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRepast;
        private Button btnReport;
        private Button btnUserUpdate;
        private Label lblUser;
        private Button btnAddActivity;
    }
}