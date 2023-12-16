namespace DiyetProjesi.PL.Admin
{
    partial class AddRepastForm
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
            btnUpDate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            lstRepast = new ListBox();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpDate
            // 
            btnUpDate.Location = new Point(93, 73);
            btnUpDate.Name = "btnUpDate";
            btnUpDate.Size = new Size(75, 23);
            btnUpDate.TabIndex = 2;
            btnUpDate.Text = "GÜNCELLE";
            btnUpDate.UseVisualStyleBackColor = true;
            btnUpDate.Click += btnUpDate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(183, 291);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstRepast
            // 
            lstRepast.FormattingEnabled = true;
            lstRepast.ItemHeight = 15;
            lstRepast.Location = new Point(183, 9);
            lstRepast.Name = "lstRepast";
            lstRepast.Size = new Size(250, 274);
            lstRepast.TabIndex = 4;
            lstRepast.SelectedIndexChanged += lstRepast_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Öğün Ad";
            // 
            // AddRepastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 326);
            Controls.Add(btnUpDate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstRepast);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AddRepastForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğün Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpDate;
        private Button btnRemove;
        private Button btnAdd;
        private ListBox lstRepast;
        private TextBox txtName;
        private Label label1;
    }
}