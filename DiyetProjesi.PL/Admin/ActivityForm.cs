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

namespace DiyetProjesi.PL.Admin 
{
    public partial class ActivityForm : Form
    {
        Repository<DAL.Classes.Activity> repository;
        DAL.Classes.Activity activity;

        public ActivityForm()
        {
            InitializeComponent();
            repository = new Repository<DAL.Classes.Activity>();
            GetInfo();
        }

        private void GetInfo()
        {
            lstActivity.DataSource = repository.GetAll();
            lstActivity.DisplayMember = "Name";
            lstActivity.SelectedIndex = -1;
            txtName.Text = "";
            nudCalPerMin.Value = 0;
            nudCalPerMin.Maximum = 10000;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (name == null)
            {
                MessageBox.Show("Bir öğe giriniz");
                return;
            }

            int cal = (int)nudCalPerMin.Value;

            DAL.Classes.Activity activity = new DAL.Classes.Activity()
            {
                Name = name,
                CalariesPerMinute = cal
            };

            repository.Add(activity);
            GetInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (activity == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }
            repository.Remove(activity);
            GetInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (activity == null)
            {
                MessageBox.Show("Bir öğe seçiniz");
                return;
            }

            string name = txtName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Kategori adı giriniz");
            }
            activity.Name = name;
            activity.CalariesPerMinute = (int)nudCalPerMin.Value;
            GetInfo();
        }

        private void lstActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            activity = (DAL.Classes.Activity)lstActivity.SelectedItem;

            if (activity == null)
            {
                return;
            }

            txtName.Text = activity.Name;
            nudCalPerMin.Value = activity.CalariesPerMinute;
        }
    }
}
