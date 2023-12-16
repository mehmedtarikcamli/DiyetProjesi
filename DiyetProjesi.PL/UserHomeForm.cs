using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserHomeForm : Form
    {
        Repository<DAL.Classes.User> _users;
        DAL.Classes.User _user;
        public UserHomeForm(DAL.Classes.User user)
        {
            InitializeComponent();
            _users = new Repository<DAL.Classes.User>();
            _user = user;

            lblUser.Text = "Merhaba, " + user.FirstName + " " + user.LastName;
        }

        private void btnRepast_Click(object sender, EventArgs e)
        {
            RepastForm repastForm = new RepastForm(_user);
            repastForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            EndOfDayForm endOfDayForm = new EndOfDayForm(_user);
            endOfDayForm.ShowDialog();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityForm addActivityForm = new AddActivityForm(_user);
            addActivityForm.ShowDialog();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(_user);
            profileForm.ShowDialog();

            _user = _users.GetById(profileForm.userId);

            lblUser.Text = "Merhaba, " + _user.FirstName + " " + _user.LastName;


        }
    }
}
