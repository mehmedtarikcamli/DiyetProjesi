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
    public partial class AddActivityForm : Form
    {
        Repository<DAL.Classes.Activity> repository;
        Repository<DailyActivity> dailyActivity;
        DAL.Classes.User _user;
        DailyActivity _dailyActivity;

        public AddActivityForm(DAL.Classes.User user)
        {
            InitializeComponent();

            repository = new Repository<DAL.Classes.Activity>();
            dailyActivity = new Repository<DailyActivity>();

            _user = user;
            GetInfo();
        }

        private void GetInfo()
        {
            cmbActivity.DataSource = repository.GetAll();
            cmbActivity.DisplayMember = "Name";
            dtpAddActivity.Value = DateTime.Today;
            dgvAddActivity.DataSource = dailyActivity.GetAll().Where(x => x.UserId == _user.Id)
                .Select(x => new
                {
                    x.Id,
                    Tarih = x.Date,
                    Aktivite = x.Activity.Name,
                    Süre = x.ActivityTime
                }).ToList();

            dgvAddActivity.Columns[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dtpAddActivity.Value.Date;

            DailyActivity da = new DailyActivity()
            {
                UserId = _user.Id,
                ActivityId = ((DAL.Classes.Activity)cmbActivity.SelectedItem).Id,
                Date = date,
                ActivityTime = (int)nudTime.Value
            };

            dailyActivity.Add(da);

            MessageBox.Show("Aktivite kaydedilmiştir");

            GetInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _dailyActivity = (DailyActivity)dgvAddActivity.SelectedRows[0].DataBoundItem;
                DateTime date = dtpAddActivity.Value.Date;
                _dailyActivity.Date = date;
                _dailyActivity.ActivityId = ((DAL.Classes.Activity)cmbActivity.SelectedItem).Id;
                _dailyActivity.ActivityTime = (int)nudTime.Value;
                dailyActivity.Update();
                GetInfo();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir SeçimYapın");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _dailyActivity = (DailyActivity)dgvAddActivity.SelectedRows[0].DataBoundItem;

                dailyActivity.Remove(_dailyActivity);

                MessageBox.Show("Başarılı");

                GetInfo();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir SeçimYapın");
            }
        }

        private void dgvAddActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAddActivity.SelectedRows.Count > 0)
            {
                int rowIndex = dgvAddActivity.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < dgvAddActivity.Rows.Count)
                {
                    int idValue = Convert.ToInt32(dgvAddActivity.Rows[rowIndex].Cells[0].Value);
                    DailyActivity selectedActivity = dailyActivity.GetAll().FirstOrDefault(x => x.Id == idValue);

                    if (selectedActivity != null)
                    {
                        cmbActivity.SelectedItem = repository.GetAll().FirstOrDefault(x => x.Id == selectedActivity.ActivityId);
                        nudTime.Value = selectedActivity.ActivityTime;
                        dtpAddActivity.Value = selectedActivity.Date;
                    }
                }
            }
        }
    }
}
