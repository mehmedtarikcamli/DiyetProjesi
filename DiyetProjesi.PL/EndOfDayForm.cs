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

namespace DiyetProjesi.PL.User
{
    public partial class EndOfDayForm : Form
    {
        Repository<Process> processes;
        Repository<DailyActivity> dailyActivities;
        DAL.Classes.User _user;
        public EndOfDayForm(DAL.Classes.User user)
        {
            InitializeComponent();
            processes = new Repository<Process>();
            dailyActivities = new Repository<DailyActivity>();
            _user = user;
            dtpDate.Value = DateTime.Today;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value.Date;
            dgvProduct.DataSource = processes.GetAll().Where(x => x.UserId == _user.Id && x.Date == date).ToList();
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[1].Visible = false;
            dgvProduct.Columns[2].Visible = false;
            dgvProduct.Columns[3].Visible = false;
            dgvProduct.Columns[4].Visible = false;
            dgvProduct.Columns[7].Visible = false;
            dgvProduct.Columns[8].Visible = false;

            int userActivity = dailyActivities.GetAll().Where(a => a.UserId == _user.Id && a.Date == date).Sum(x => x.ActivityTime * x.Activity.CalariesPerMinute);
            
            decimal daily;

            if (_user.Gender == "Erkek")
            {
                daily = (66.5M + (13.8M * _user.Weigth) + (5 * 176) - (6.77M * _user.Age)) * 1.35M;
            }
            else
            {
                daily = (666.5M + (9.6M * _user.Weigth) + (1.7M * 162) - (4.7M * _user.Age)) * 1.35M;
            }

            lblCal.Text = "Alınan Kalori: " + processes.GetAll().Where(x => x.UserId == _user.Id && x.Date == date).ToList().Sum(x => x.Product.Calories * x.Portion).ToString();
            lblCar.Text = "Alınan Karbonhidrat: " + processes.GetAll().Where(x => x.UserId == _user.Id && x.Date == date).ToList().Sum(x => x.Product.Carbohydrate * x.Portion).ToString();
            lblTarget.Text = "Kalori İhtiyacı: " + (daily + userActivity).ToString();
        }
    }
}
