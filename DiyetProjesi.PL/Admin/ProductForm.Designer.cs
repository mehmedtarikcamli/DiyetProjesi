namespace DiyetProjesi.PL
{
    partial class ProductForm
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
            nudCar = new NumericUpDown();
            btnUpdate = new Button();
            btnAdd = new Button();
            label6 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            nudCal = new NumericUpDown();
            lstProduct = new ListBox();
            btnRemove = new Button();
            cmbCategory = new ComboBox();
            label1 = new Label();
            btnAddPicture = new Button();
            pcbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // nudCar
            // 
            nudCar.Location = new Point(109, 143);
            nudCar.Name = "nudCar";
            nudCar.Size = new Size(164, 23);
            nudCar.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(198, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(117, 189);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 145);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 12;
            label6.Text = "Karbonhidrat";
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 23);
            txtName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 14;
            label4.Text = "Kalori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 19);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 15;
            label3.Text = "Ad";
            // 
            // nudCal
            // 
            nudCal.Location = new Point(109, 101);
            nudCal.Name = "nudCal";
            nudCal.Size = new Size(164, 23);
            nudCal.TabIndex = 2;
            // 
            // lstProduct
            // 
            lstProduct.FormattingEnabled = true;
            lstProduct.ItemHeight = 15;
            lstProduct.Location = new Point(306, 22);
            lstProduct.Name = "lstProduct";
            lstProduct.Size = new Size(378, 184);
            lstProduct.TabIndex = 7;
            lstProduct.SelectedIndexChanged += lstProduct_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(306, 212);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(108, 58);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(165, 23);
            cmbCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Kategori";
            // 
            // btnAddPicture
            // 
            btnAddPicture.Location = new Point(690, 212);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(88, 23);
            btnAddPicture.TabIndex = 4;
            btnAddPicture.Text = "RESİM YÜKLE";
            btnAddPicture.UseVisualStyleBackColor = true;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(690, 22);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(184, 184);
            pcbImage.TabIndex = 16;
            pcbImage.TabStop = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 243);
            Controls.Add(pcbImage);
            Controls.Add(cmbCategory);
            Controls.Add(lstProduct);
            Controls.Add(nudCal);
            Controls.Add(nudCar);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAddPicture);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekranı";
            ((System.ComponentModel.ISupportInitialize)nudCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCar;
        private ComboBox cmbCinsiyet;
        private Button btnUpdate;
        private Button btnIptal;
        private Button btnAdd;
        private TextBox txtSifre;
        private Label label6;
        private TextBox txtSoyad;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private NumericUpDown nudCal;
        private ListBox lstProduct;
        private Label Label2;
        private Label label1;
        private Button btnRemove;
        private ComboBox cmbCategory;
        private Button btnAddPicture;
        private PictureBox pcbImage;
    }
}