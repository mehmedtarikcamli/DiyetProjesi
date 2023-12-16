namespace DiyetProjesi.PL.Admin
{
    partial class ReportForm
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
            cmbUser1 = new ComboBox();
            cmbUser2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnCompare = new Button();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            lblUser2Car = new Label();
            lblUser1Car = new Label();
            label5 = new Label();
            label4 = new Label();
            lblUser2Cal = new Label();
            lblUser2Activity = new Label();
            lblUser1Cal = new Label();
            lblUser1Activity = new Label();
            dtpProductDate = new DateTimePicker();
            dgvProduct = new DataGridView();
            label3 = new Label();
            cmbProduct = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // cmbUser1
            // 
            cmbUser1.FormattingEnabled = true;
            cmbUser1.Location = new Point(83, 48);
            cmbUser1.Name = "cmbUser1";
            cmbUser1.Size = new Size(176, 23);
            cmbUser1.TabIndex = 0;
            // 
            // cmbUser2
            // 
            cmbUser2.FormattingEnabled = true;
            cmbUser2.Location = new Point(443, 48);
            cmbUser2.Name = "cmbUser2";
            cmbUser2.Size = new Size(171, 23);
            cmbUser2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "1. Kullanıcı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "2. Kullanıcı";
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(443, 11);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(92, 22);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "Kıyasla";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 23);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(dtpDate);
            splitContainer1.Panel1.Controls.Add(lblUser2Car);
            splitContainer1.Panel1.Controls.Add(lblUser1Car);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(lblUser2Cal);
            splitContainer1.Panel1.Controls.Add(btnCompare);
            splitContainer1.Panel1.Controls.Add(lblUser2Activity);
            splitContainer1.Panel1.Controls.Add(lblUser1Cal);
            splitContainer1.Panel1.Controls.Add(lblUser1Activity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(cmbUser1);
            splitContainer1.Panel1.Controls.Add(cmbUser2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel2.Controls.Add(dtpProductDate);
            splitContainer1.Panel2.Controls.Add(dgvProduct);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(cmbProduct);
            splitContainer1.Size = new Size(666, 479);
            splitContainer1.SplitterDistance = 238;
            splitContainer1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 142);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 13;
            label6.Text = "Alınan Karbonhidrat";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(226, 11);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 10;
            // 
            // lblUser2Car
            // 
            lblUser2Car.Location = new Point(402, 128);
            lblUser2Car.Name = "lblUser2Car";
            lblUser2Car.Size = new Size(241, 43);
            lblUser2Car.TabIndex = 12;
            lblUser2Car.Text = "0";
            lblUser2Car.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUser1Car
            // 
            lblUser1Car.Location = new Point(19, 128);
            lblUser1Car.Name = "lblUser1Car";
            lblUser1Car.Size = new Size(240, 43);
            lblUser1Car.TabIndex = 11;
            lblUser1Car.Text = "0";
            lblUser1Car.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 93);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Alınan Kalori";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 194);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 9;
            label4.Text = "Kalori İhtiyacı";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser2Cal
            // 
            lblUser2Cal.Location = new Point(402, 79);
            lblUser2Cal.Name = "lblUser2Cal";
            lblUser2Cal.Size = new Size(241, 43);
            lblUser2Cal.TabIndex = 8;
            lblUser2Cal.Text = "0";
            lblUser2Cal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUser2Activity
            // 
            lblUser2Activity.Location = new Point(402, 182);
            lblUser2Activity.Name = "lblUser2Activity";
            lblUser2Activity.Size = new Size(241, 39);
            lblUser2Activity.TabIndex = 7;
            lblUser2Activity.Text = "0";
            lblUser2Activity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUser1Cal
            // 
            lblUser1Cal.Location = new Point(19, 79);
            lblUser1Cal.Name = "lblUser1Cal";
            lblUser1Cal.Size = new Size(240, 43);
            lblUser1Cal.TabIndex = 6;
            lblUser1Cal.Text = "0";
            lblUser1Cal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser1Activity
            // 
            lblUser1Activity.Location = new Point(19, 182);
            lblUser1Activity.Name = "lblUser1Activity";
            lblUser1Activity.Size = new Size(240, 39);
            lblUser1Activity.TabIndex = 5;
            lblUser1Activity.Text = "0";
            lblUser1Activity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpProductDate
            // 
            dtpProductDate.Location = new Point(279, 16);
            dtpProductDate.Name = "dtpProductDate";
            dtpProductDate.Size = new Size(200, 23);
            dtpProductDate.TabIndex = 11;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(19, 57);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(629, 162);
            dgvProduct.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 21);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Yemek";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(70, 16);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 23);
            cmbProduct.TabIndex = 0;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 533);
            Controls.Add(splitContainer1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rapor Ekranı";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbUser1;
        private ComboBox cmbUser2;
        private Label label1;
        private Label label2;
        private Button btnCompare;
        private SplitContainer splitContainer1;
        private Label label3;
        private ComboBox cmbProduct;
        private DataGridView dgvProduct;
        private Label lblUser2Cal;
        private Label lblUser2Activity;
        private Label lblUser1Cal;
        private Label lblUser1Activity;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpProductDate;
        private Label label6;
        private Label lblUser2Car;
        private Label lblUser1Car;
    }
}