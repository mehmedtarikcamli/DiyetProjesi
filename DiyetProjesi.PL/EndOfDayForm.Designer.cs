namespace DiyetProjesi.PL.User
{
    partial class EndOfDayForm
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
            dgvProduct = new DataGridView();
            dtpDate = new DateTimePicker();
            lblCal = new Label();
            lblCar = new Label();
            lblTarget = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 65);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(710, 239);
            dgvProduct.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(522, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // lblCal
            // 
            lblCal.AutoSize = true;
            lblCal.Location = new Point(12, 316);
            lblCal.Name = "lblCal";
            lblCal.Size = new Size(77, 15);
            lblCal.TabIndex = 2;
            lblCal.Text = "Alınan Kalori:";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(12, 344);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(116, 15);
            lblCar.TabIndex = 3;
            lblCar.Text = "Alınan Karbonhidrat:";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(12, 375);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(105, 15);
            lblTarget.TabIndex = 4;
            lblTarget.Text = "Kalori Gereksinimi:";
            // 
            // EndOfDayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 418);
            Controls.Add(lblTarget);
            Controls.Add(lblCar);
            Controls.Add(lblCal);
            Controls.Add(dtpDate);
            Controls.Add(dgvProduct);
            Name = "EndOfDayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gün Sonu Raporu";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private DateTimePicker dtpDate;
        private Label lblCal;
        private Label lblCar;
        private Label lblTarget;
    }
}