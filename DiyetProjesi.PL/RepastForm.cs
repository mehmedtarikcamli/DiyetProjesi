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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DiyetProjesi.PL.User
{
    public partial class RepastForm : Form
    {
        Repository<Repast> repository;
        Repository<Product> product;
        Repository<Process> process;
        DAL.Classes.User _user;

        Process prs;

        public RepastForm(DAL.Classes.User user)
        {
            InitializeComponent();

            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepast.DropDownStyle = ComboBoxStyle.DropDownList;

            repository = new Repository<Repast>();
            product = new Repository<Product>();
            process = new Repository<Process>();
            _user = user;

            GetInfo();
        }

        private void GetInfo()
        {
            cmbProduct.DataSource = product.GetAll();
            cmbRepast.DataSource = repository.GetAll();
            cmbRepast.DisplayMember = "Name";

            DateTime date = dtpListDate.Value.Date;

            List<Process> list = process.GetAll().Where(x => x.UserId == _user.Id && x.Date == date).ToList();
            dgvProducts.DataSource = process.GetAll().Where(x => x.UserId == _user.Id && x.Date == date)
            .Select(x => new
             {
                 x.Id,
                 Ürün = x.Product,
                 Öğün = x.Repast,
                 Porsiyon = x.Portion
             }).OrderBy(x => x.Öğün.Name).ToList();

            dgvProducts.Columns[0].Visible = false;

            if (list == null)
            {
                return;
            }

            lblTotal.Text = "Toplam Kalori: " + list.Sum(x => x.Product.Calories * x.Portion).ToString() +
                " cal\n" + "Toplam Karbonhidrat: " + list.Sum(x => x.Product.Carbohydrate).ToString() + " gr";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = dtpListDate.Value.Date;

            int repId = ((Repast)cmbRepast.SelectedItem).Id;
            int prodId = ((Product)cmbProduct.SelectedItem).Id;

            Process newprocess = new Process() { UserId = _user.Id, Date = date, RepastId = repId, ProductId = prodId, Portion = (int)nudPortion.Value };

            process.Add(newprocess);

            MessageBox.Show("Başarılı");
            GetInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                process.Remove(prs);
                MessageBox.Show("Başarılı");
                GetInfo();

            }
            catch (Exception)
            {
                MessageBox.Show("Tablodan Seçim Yapın");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpListDate.Value.Date;

                int repId = ((Repast)cmbRepast.SelectedItem).Id;
                int prodId = ((Product)cmbProduct.SelectedItem).Id;

                prs.Date = date;
                prs.RepastId = repId;
                prs.ProductId = prodId;
                prs.Portion = (int)nudPortion.Value;

                process.Update();
                MessageBox.Show("Başarılı");
                GetInfo();
            }
            catch (Exception)
            {

                MessageBox.Show("Tablodan Seçim Yapın");
            }
        }

        private void dtpListDate_ValueChanged(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int rowIndex = dgvProducts.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < dgvProducts.Rows.Count)
                {
                    int idValue = Convert.ToInt32(dgvProducts.Rows[rowIndex].Cells[0].Value);
                    Process selectedProcess = process.GetAll().FirstOrDefault(x => x.Id == idValue);

                    prs = selectedProcess;

                    if (selectedProcess != null)
                    {
                        cmbProduct.SelectedItem = product.GetAll().FirstOrDefault(x => x.Id == selectedProcess.ProductId);
                        cmbRepast.SelectedItem = repository.GetAll().FirstOrDefault(x => x.Id == selectedProcess.RepastId);
                        nudPortion.Value = selectedProcess.Portion;
                    }
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product prd = (Product)cmbProduct.SelectedItem;

            if (prd != null)
            {
                if (prd.Image == null)
                {
                    return;
                }

                using (MemoryStream ms = new MemoryStream(prd.Image))
                {
                    pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbImage.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
