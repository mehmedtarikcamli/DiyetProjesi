namespace DiyetProjesi.PL
{
    partial class AdminHomeForm
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
            btnProduct = new Button();
            btnReport = new Button();
            btnActivity = new Button();
            btnCategory = new Button();
            btnRepast = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(144, 155);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(118, 47);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Ürün Ekranı";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(144, 291);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(118, 47);
            btnReport.TabIndex = 4;
            btnReport.Text = "Raporlar Ekranı";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnActivity
            // 
            btnActivity.Location = new Point(144, 223);
            btnActivity.Margin = new Padding(3, 4, 3, 4);
            btnActivity.Name = "btnActivity";
            btnActivity.Size = new Size(118, 47);
            btnActivity.TabIndex = 3;
            btnActivity.Text = "Aktivite Ekranı";
            btnActivity.UseVisualStyleBackColor = true;
            btnActivity.Click += btnActivity_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(144, 85);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(118, 47);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Kategori Ekranı";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnRepast
            // 
            btnRepast.Location = new Point(144, 16);
            btnRepast.Margin = new Padding(3, 4, 3, 4);
            btnRepast.Name = "btnRepast";
            btnRepast.Size = new Size(118, 47);
            btnRepast.TabIndex = 0;
            btnRepast.Text = "Öğün Ekranı";
            btnRepast.UseVisualStyleBackColor = true;
            btnRepast.Click += btnRepast_Click;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 351);
            Controls.Add(btnCategory);
            Controls.Add(btnReport);
            Controls.Add(btnActivity);
            Controls.Add(btnRepast);
            Controls.Add(btnProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnReport;
        private Button btnActivity;
        private Button btnCategory;
        private Button btnRepast;
    }
}