namespace DiyetProjesi.PL.Admin
{
    partial class ActivityForm
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
            lstActivity = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            nudCalPerMin = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCalPerMin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // txtName
            // 
            txtName.Location = new Point(84, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 23);
            txtName.TabIndex = 0;
            // 
            // lstActivity
            // 
            lstActivity.FormattingEnabled = true;
            lstActivity.ItemHeight = 15;
            lstActivity.Location = new Point(290, 21);
            lstActivity.Name = "lstActivity";
            lstActivity.Size = new Size(210, 154);
            lstActivity.TabIndex = 5;
            lstActivity.SelectedIndexChanged += lstActivity_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(116, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(290, 181);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(197, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // nudCalPerMin
            // 
            nudCalPerMin.Location = new Point(84, 72);
            nudCalPerMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCalPerMin.Name = "nudCalPerMin";
            nudCalPerMin.Size = new Size(188, 23);
            nudCalPerMin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "Birim Kalori";
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 220);
            Controls.Add(nudCalPerMin);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstActivity);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aktivite Ekranı";
            ((System.ComponentModel.ISupportInitialize)nudCalPerMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private ListBox lstActivity;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private NumericUpDown nudCalPerMin;
        private Label label2;
    }
}