using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ReportForm : Form
    {
        Repository<DAL.Classes.User> users;
        Repository<DAL.Classes.DailyActivity> dailyActivities;
        Repository<DAL.Classes.Process> processes;
        Repository<DAL.Classes.Product> products;

        public ReportForm()
        {
            InitializeComponent();
            users = new Repository<DAL.Classes.User>();
            dailyActivities = new Repository<DAL.Classes.DailyActivity>();
            processes = new Repository<DAL.Classes.Process>();
            products = new Repository<DAL.Classes.Product>();
            GetInfo();
        }

        private void GetInfo()
        {
            cmbUser1.DataSource = users.GetAll();
            cmbUser2.DataSource = users.GetAll();
            cmbProduct.DataSource = products.GetAll();
            cmbProduct.DisplayMember = "Name";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value.Date;
            DAL.Classes.User user1 = (DAL.Classes.User)cmbUser1.SelectedItem;
            DAL.Classes.User user2 = (DAL.Classes.User)cmbUser2.SelectedItem;

            int user1Activity = dailyActivities.GetAll().Where(a => a.UserId == user1.Id && a.Date == date).Sum(x => x.ActivityTime * x.Activity.CalariesPerMinute);
            int user2Activity = dailyActivities.GetAll().Where(a => a.UserId == user2.Id && a.Date == date).Sum(x => x.ActivityTime * x.Activity.CalariesPerMinute);

            decimal daily;
            decimal daily2;

            if (user1.Gender == "Erkek")
            {
                daily = (66.5M + (13.8M * user1.Weigth) + (5 * 176) - (6.77M * user1.Age)) * 1.35M;
            }
            else
            {
                daily = (666.5M + (9.6M * user1.Weigth) + (1.7M * 162) - (4.7M * user1.Age)) * 1.35M;
            }


            if (user2.Gender == "Erkek")
            {
                daily2 = (66.5M + (13.8M * user2.Weigth) + (5 * 176) - (6.77M * user2.Age)) * 1.35M;
            }
            else
            {
                daily2 = (666.5M + (9.6M * user2.Weigth) + (1.7M * 162) - (4.7M * user2.Age)) * 1.35M;
            }

            lblUser1Activity.Text = (daily + user1Activity).ToString();
            lblUser2Activity.Text = (daily2 + user2Activity).ToString();

            decimal user1Eat = processes.GetAll().Where(a => a.UserId == user1.Id && a.Date == date).Sum(x => x.Product.Calories * x.Portion);
            decimal user2Eat = processes.GetAll().Where(a => a.UserId == user2.Id && a.Date == date).Sum(x => x.Product.Calories * x.Portion);

            lblUser1Cal.Text = user1Eat.ToString();
            lblUser2Cal.Text = user2Eat.ToString();

            decimal user1EatCar = processes.GetAll().Where(a => a.UserId == user1.Id && a.Date == date).Sum(x => x.Product.Carbohydrate * x.Portion);
            decimal user2EatCar = processes.GetAll().Where(a => a.UserId == user2.Id && a.Date == date).Sum(x => x.Product.Carbohydrate * x.Portion);

            lblUser1Car.Text = user1EatCar.ToString();
            lblUser2Car.Text = user2EatCar.ToString();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = ((Product)cmbProduct.SelectedItem);
            if (product == null)
                return;

            DateTime date = dtpProductDate.Value.Date;

            dgvProduct.DataSource = processes.GetAll().Where(x => x.ProductId == product.Id && x.Date == date).ToList();
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[1].Visible = false;
            dgvProduct.Columns[3].Visible = false;
            dgvProduct.Columns[4].Visible = false;
            dgvProduct.Columns[6].Visible = false;
            dgvProduct.Columns[7].Visible = false;
            dgvProduct.Columns[8].Visible = false;
        }
    }
}
