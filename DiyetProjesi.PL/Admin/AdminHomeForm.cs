using DiyetProjesi.PL.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProjesi.PL
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e) // tamam
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void btnRepast_Click(object sender, EventArgs e) // tamam
        {
            AddRepastForm addRepastForm = new AddRepastForm();
            addRepastForm.ShowDialog();
        }
    }
}
