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
    public partial class AddRepastForm : Form
    {
        Repository<Repast> repository = new Repository<Repast>();
        Repast repast;
        public AddRepastForm()
        {
            InitializeComponent();
            GetInfo();
        }

        private void GetInfo()
        {
            lstRepast.DataSource = repository.GetAll();
            lstRepast.DisplayMember = "Name";
            lstRepast.SelectedIndex = -1;
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

            Repast repast = new Repast()
            {
                Name = name,
            };

            repository.Add(repast);
            GetInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (repast == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }
            repository.Remove(repast);
            GetInfo();
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (repast == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }

            string name= txtName.Text.Trim();

            if (name == null)
            {
                MessageBox.Show("Kategori adı giriniz");
            }
                repast.Name = txtName.Text.Trim();
                GetInfo();
        }

        private void lstRepast_SelectedIndexChanged(object sender, EventArgs e)
        {
            repast = (Repast)lstRepast.SelectedItem;

            if (repast == null)
            {
                return;
            }

            txtName.Text = repast.Name;
        }
    }
}
