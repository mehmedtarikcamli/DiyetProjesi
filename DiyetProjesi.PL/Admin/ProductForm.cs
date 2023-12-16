using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProjesi.PL
{
    public partial class ProductForm : Form
    {
        Repository<Product> products;
        Repository<Category> categories;
        Product product;

        byte[] image;
        public ProductForm()
        {
            InitializeComponent();
            products = new Repository<Product>();
            categories = new Repository<Category>();

            nudCal.Maximum = 10000;
            nudCar.Maximum = 10000;

            GetInfo();
        }

        private void GetInfo()
        {
            lstProduct.DataSource = products.GetAll();
            lstProduct.DisplayMember = "Name";
            lstProduct.SelectedIndex = -1;

            cmbCategory.DataSource = categories.GetAll();
            cmbCategory.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Ürün adı giriniz");
                return;
            }

            int catId = ((Category)cmbCategory.SelectedItem).Id;

            Product product = new Product()
            {
                Name = name,
                CategoryId = catId,
                Calories = nudCal.Value,
                Carbohydrate = nudCar.Value,
                Image = image
            };

            products.Add(product);
            GetInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (product == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }
            products.Remove(product);
            GetInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (product == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }

            string name = txtName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Ürün adı giriniz");
            }

            int catId = ((Category)cmbCategory.SelectedItem).Id;

            product.Name = name;
            product.CategoryId = catId;
            product.Calories = (int)nudCal.Value;
            product.Carbohydrate = (int)nudCar.Value;
            product.Image = image;
            products.Update();
            MessageBox.Show("Başarılı");
            GetInfo();
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            product = (Product)lstProduct.SelectedItem;

            if (product == null)
                return;

            txtName.Text = product.Name;
            nudCal.Value = product.Calories;
            nudCar.Value = product.Carbohydrate;
            cmbCategory.SelectedItem = categories.GetAll().FirstOrDefault(x => x.Id == product.CategoryId);

            if (product != null)
            {
                if (product.Image == null)
                {
                    return;
                }

                using (MemoryStream ms = new MemoryStream(product.Image))
                {
                    pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imageWindow = new OpenFileDialog())
            {
                if (imageWindow.ShowDialog() == DialogResult.OK)
                {
                    image = File.ReadAllBytes(imageWindow.FileName);
                }
            }
        }
    }
}
