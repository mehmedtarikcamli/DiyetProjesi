namespace DiyetProjesi.PL
{
    partial class AddActivityForm
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
            cmbActivity = new ComboBox();
            nudTime = new NumericUpDown();
            label2 = new Label();
            btnSave = new Button();
            dgvAddActivity = new DataGridView();
            dtpAddActivity = new DateTimePicker();
            btnUpdate = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddActivity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Aktivite";
            // 
            // cmbActivity
            // 
            cmbActivity.FormattingEnabled = true;
            cmbActivity.Location = new Point(79, 58);
            cmbActivity.Name = "cmbActivity";
            cmbActivity.Size = new Size(175, 23);
            cmbActivity.TabIndex = 0;
            // 
            // nudTime
            // 
            nudTime.Location = new Point(79, 100);
            nudTime.Name = "nudTime";
            nudTime.Size = new Size(175, 23);
            nudTime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 103);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Süre:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(79, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvAddActivity
            // 
            dgvAddActivity.AllowUserToDeleteRows = false;
            dgvAddActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddActivity.Location = new Point(288, 23);
            dgvAddActivity.Margin = new Padding(3, 2, 3, 2);
            dgvAddActivity.Name = "dgvAddActivity";
            dgvAddActivity.ReadOnly = true;
            dgvAddActivity.RowHeadersWidth = 51;
            dgvAddActivity.Size = new Size(369, 128);
            dgvAddActivity.TabIndex = 6;
            dgvAddActivity.CellClick += dgvAddActivity_CellClick;
            // 
            // dtpAddActivity
            // 
            dtpAddActivity.Location = new Point(35, 23);
            dtpAddActivity.Margin = new Padding(3, 2, 3, 2);
            dtpAddActivity.Name = "dtpAddActivity";
            dtpAddActivity.Size = new Size(219, 23);
            dtpAddActivity.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(159, 128);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(288, 157);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // AddActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 191);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(dtpAddActivity);
            Controls.Add(dgvAddActivity);
            Controls.Add(btnSave);
            Controls.Add(nudTime);
            Controls.Add(cmbActivity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aktivite Ekranı";
            ((System.ComponentModel.ISupportInitialize)nudTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddActivity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbActivity;
        private NumericUpDown nudTime;
        private Label label2;
        private Button btnSave;
        private DataGridView dgvAddActivity;
        private DateTimePicker dtpAddActivity;
        private Button btnUpdate;
        private Button btnRemove;
    }
}