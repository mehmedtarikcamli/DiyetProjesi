namespace DiyetProjesi.PL.Admin
{
    partial class CategoryForm
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
            label1 = new Label();
            txtName = new TextBox();
            lstCategory = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpDate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Ad";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 23);
            txtName.TabIndex = 0;
            // 
            // lstCategory
            // 
            lstCategory.FormattingEnabled = true;
            lstCategory.ItemHeight = 15;
            lstCategory.Location = new Point(174, 20);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(250, 274);
            lstCategory.TabIndex = 4;
            lstCategory.SelectedIndexChanged += lstCategory_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(174, 300);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpDate
            // 
            btnUpDate.Location = new Point(84, 84);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(75, 23);
            btnUpDate.TabIndex = 2;
            btnUpDate.Text = "GÜNCELLE";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 336);
            Controls.Add(btnUpDate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstCategory);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private ListBox lstCategory;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpDate;
    }
}