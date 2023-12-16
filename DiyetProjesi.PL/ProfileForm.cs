using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProjesi.PL
{
    public partial class ProfileForm : Form
    {
        Repository<DAL.Classes.User> _users;
        DAL.Classes.User _user;
        public int userId;

        public ProfileForm(DAL.Classes.User person)
        {
            InitializeComponent();
            CBoxData();

            btnSignUp.Visible = false;
            this.Text = "Üye Güncelle";
            userId = person.Id;

            _users = new Repository<DAL.Classes.User> ();
            _user = _users.GetById (person.Id);

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtEmail.Text = person.Email;
            nudAge.Value = person.Age;
            nudWeigth.Value = person.Weigth;
            cmbGender.SelectedItem = person.Gender;
        }

        public ProfileForm(Repository<DAL.Classes.User> users)
        {
            InitializeComponent();
            CBoxData();

            _users = users;
            btnUpdate.Visible = false;
            btnSignUp.Location = btnUpdate.Location;

            this.Text = "Yeni Üye";
        }

        private void CBoxData()
        {
            cmbGender.Items.Clear();
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new string[] { "- Seçiniz -", "Erkek", "Kadın" });
            cmbGender.SelectedIndex = 0;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim(),
            lastName = txtLastName.Text.Trim(),
            email = txtEmail.Text.Trim(),
            key = txtKey.Text.Trim();

            if (new string[] { firstName, lastName, email, key }.Contains(""))
            {
                MessageBox.Show("Tüm alanları doldurunuz");
                return;
            }

            if (cmbGender.SelectedIndex == 0)
            {
                MessageBox.Show("Cinsiyet Seçiniz");
                return;
            }

            if(_users.GetAll().FirstOrDefault(x => x.Email == email) != null)
            {
                MessageBox.Show("Email adresi kullanılmaktadır");
                return;
            }

            int age = (int)nudAge.Value;
            decimal weigth = nudWeigth.Value;
            string gender = cmbGender.SelectedItem.ToString();

            DAL.Classes.User user = new DAL.Classes.User()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Email = email,
                Key = sha256_hash(key),
                Gender = gender,
                Weigth = weigth
            };

            _users.Add(user);

            MessageBox.Show("Profil oluşturulmuştur");

            Close();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim(),
            lastName = txtLastName.Text.Trim(),
            email = txtEmail.Text.Trim(),
            key = txtKey.Text.Trim();

            if (new string[] { firstName, lastName, email }.Contains(""))
            {
                MessageBox.Show("Tüm alanları doldurunuz");
                return;
            }

            if (cmbGender.SelectedIndex == 0)
            {
                MessageBox.Show("Cinsiyet Seçiniz");
                return;
            }

            int age = (int)nudAge.Value;
            decimal weigth = nudWeigth.Value;
            string gender = cmbGender.SelectedItem.ToString();

            if (key != "")
            {
                _user.Key = sha256_hash(key);
            }

            _user.FirstName = firstName;
            _user.LastName = lastName;
            _user.Email = email;
            _user.Age = age;
            _user.Gender = gender;
            _user.Weigth = weigth;
            userId = _user.Id;

            _users.Update();

            MessageBox.Show("Başarılı");

            Close();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            string key = txtKey.Text;

            if (key == "")
            {
                lbLDif.Text = "";
                return;
            }

            if (key.Length <= 7)
            {
                lbLDif.ForeColor = Color.Red;
                lbLDif.Text = "Kolay";
            }
            else if (key.Length >= 8 && key.Any(c => !char.IsLetterOrDigit(c)))
            {
                lbLDif.ForeColor = Color.Green;
                lbLDif.Text = "Zor";
            }
            else
            {
                lbLDif.ForeColor = Color.Orange;
                lbLDif.Text = "Orta";
            }
        }
    }
}
