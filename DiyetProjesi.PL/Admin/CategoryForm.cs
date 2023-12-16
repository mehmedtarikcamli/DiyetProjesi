using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProjesi.PL.Admin
{
    public partial class CategoryForm : Form
    {
        Repository<Category> repository = new Repository<Category>();
        Category category;

        public CategoryForm()
        {
            InitializeComponent();
            GetInfo();
        }

        private void GetInfo()
        {
            lstCategory.DataSource = repository.GetAll();
            lstCategory.DisplayMember = "Name";
            lstCategory.SelectedIndex = -1;
            txtName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Alanı doldurunuz!");
                return;
            }

            Category category = new Category()
            {
                Name = name,
            };

            repository.Add(category);
            GetInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }
            repository.Remove(category);
            GetInfo();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }

            string name = txtName.Text.Trim();

            if (name == null)
            {
                MessageBox.Show("Kategori adı giriniz");
            }
            category.Name = name;
            GetInfo();
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = (Category)lstCategory.SelectedItem;

            if (category == null)
            {
                return;
            }

            txtName.Text = category.Name;
        }
    }
}
