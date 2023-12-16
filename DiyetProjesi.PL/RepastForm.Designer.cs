namespace DiyetProjesi.PL.User
{
    partial class RepastForm
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
            cmbRepast = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            nudPortion = new NumericUpDown();
            cmbProduct = new ComboBox();
            label9 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            dtpListDate = new DateTimePicker();
            lblTotal = new Label();
            dgvProducts = new DataGridView();
            pcbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudPortion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // cmbRepast
            // 
            cmbRepast.FormattingEnabled = true;
            cmbRepast.Location = new Point(122, 63);
            cmbRepast.Name = "cmbRepast";
            cmbRepast.Size = new Size(198, 23);
            cmbRepast.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 66);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğün";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 157);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 1;
            label5.Text = "Adet/Porsiyon";
            // 
            // nudPortion
            // 
            nudPortion.Location = new Point(122, 155);
            nudPortion.Name = "nudPortion";
            nudPortion.Size = new Size(198, 23);
            nudPortion.TabIndex = 2;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(122, 112);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(198, 23);
            cmbProduct.TabIndex = 0;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 115);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 1;
            label9.Text = "Ürün";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(164, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(342, 258);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(245, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpListDate
            // 
            dtpListDate.Location = new Point(461, 24);
            dtpListDate.Margin = new Padding(3, 2, 3, 2);
            dtpListDate.Name = "dtpListDate";
            dtpListDate.Size = new Size(194, 23);
            dtpListDate.TabIndex = 6;
            dtpListDate.ValueChanged += dtpListDate_ValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(481, 258);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label2";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(342, 62);
            dgvProducts.Margin = new Padding(3, 2, 3, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(313, 183);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(661, 62);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(183, 183);
            pcbImage.TabIndex = 9;
            pcbImage.TabStop = false;
            // 
            // RepastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 302);
            Controls.Add(pcbImage);
            Controls.Add(dgvProducts);
            Controls.Add(lblTotal);
            Controls.Add(dtpListDate);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(nudPortion);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(cmbProduct);
            Controls.Add(label1);
            Controls.Add(cmbRepast);
            Name = "RepastForm";
            Text = "Öğün Ekranı";
            ((System.ComponentModel.ISupportInitialize)nudPortion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRepast;
        private Label label1;
        private Label label5;
        private NumericUpDown nudPortion;
        private ComboBox cmbProduct;
        private Label label9;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private DateTimePicker dtpListDate;
        private Label lblTotal;
        private DataGridView dgvProducts;
        private PictureBox pcbImage;
    }
}