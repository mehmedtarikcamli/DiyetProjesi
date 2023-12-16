using DiyetProjesi.BL.Repository;
using DiyetProjesi.DAL.Classes;
using DiyetProjesi.DAL.Context;
using DiyetProjesi.PL.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using System.Text;

namespace DiyetProjesi.PL
{
    public partial class Form1 : Form
    {
        Repository<DAL.Classes.User> repository = new Repository<DAL.Classes.User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void VeriYukle()
        {
            Repository<Category> repository = new Repository<Category>();
            repository.Add(new Category() { Name = "Ana Yemek" });
            repository.Add(new Category() { Name = "Meyve/Kuruyemiþ" });
            repository.Add(new Category() { Name = "Ýçecek" });

            Repository<Repast> repository2 = new Repository<Repast>();
            repository2.Add(new Repast() { Name = "Kahvaltý" });
            repository2.Add(new Repast() { Name = "Öðle Yemeði" });
            repository2.Add(new Repast() { Name = "Akþam Yemeði" });

            Repository<Activity> repository3 = new Repository<Activity>();
            repository3.Add(new Activity { Name = "Koþu", CalariesPerMinute = 50 });
            repository3.Add(new Activity { Name = "Yürüyüþ", CalariesPerMinute = 20 });
            repository3.Add(new Activity { Name = "Yüzme", CalariesPerMinute = 30 });

            Repository<Product> repository4 = new Repository<Product>();
            repository4.Add(new Product() { Name = "Omlet", CategoryId = 1, Calories = 250, Carbohydrate = 20 });
            repository4.Add(new Product() { Name = "Limonata", CategoryId = 3, Calories = 750, Carbohydrate = 15 });
            repository4.Add(new Product() { Name = "Elma", CategoryId = 3, Calories = 20, Carbohydrate = 5 });

            Repository<DAL.Classes.User> repository5 = new Repository<DAL.Classes.User>();
            repository5.Add(new DAL.Classes.User() { FirstName = "Ahmet", LastName = "Yýlmaz", Age = 56, Gender = "Erkek", Weigth = 77, Email = "ay", Key = "11" });
            repository5.Add(new DAL.Classes.User() { FirstName = "Ayþe", LastName = "Dürüst", Age = 37, Gender = "Kadýn", Weigth = 54, Email = "ad", Key = "12" });
            repository5.Add(new DAL.Classes.User() { FirstName = "Fatma", LastName = "Yalan", Age = 46, Gender = "Kadýn", Weigth = 60, Email = "fy", Key = "13" });

            Repository<Process> repository6 = new Repository<Process>();
            repository6.Add(new Process() { UserId = 2, Date = new DateTime(2023, 12, 6), RepastId = 1, ProductId = 1, Portion = 2 });
            repository6.Add(new Process() { UserId = 2, Date = new DateTime(2023, 12, 6), RepastId = 1, ProductId = 2, Portion = 2 });
            repository6.Add(new Process() { UserId = 2, Date = new DateTime(2023, 12, 7), RepastId = 1, ProductId = 2, Portion = 2 });
            repository6.Add(new Process() { UserId = 1, Date = new DateTime(2023, 12, 7), RepastId = 2, ProductId = 3, Portion = 1 });
            repository6.Add(new Process() { UserId = 3, Date = new DateTime(2023, 12, 6), RepastId = 3, ProductId = 1, Portion = 3 });

            Repository<DailyActivity> repository7 = new Repository<DailyActivity>();
            repository7.Add(new DailyActivity { UserId = 1, Date = new DateTime(2023, 12, 6), ActivityId = 1, ActivityTime = 30 });
            repository7.Add(new DailyActivity { UserId = 1, Date = new DateTime(2023, 12, 6), ActivityId = 2, ActivityTime = 40 });
            repository7.Add(new DailyActivity { UserId = 2, Date = new DateTime(2023, 12, 6), ActivityId = 3, ActivityTime = 30 });
            repository7.Add(new DailyActivity { UserId = 2, Date = new DateTime(2023, 12, 7), ActivityId = 3, ActivityTime = 30 });
            repository7.Add(new DailyActivity { UserId = 3, Date = new DateTime(2023, 12, 7), ActivityId = 2, ActivityTime = 60 });

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtKey.Text;

            if (email == "admin" && password == "admin")
            {
                AdminHomeForm adminHomeForm = new AdminHomeForm();
                adminHomeForm.ShowDialog();
            }
            else
            {
                DAL.Classes.User user = repository.GetAll().FirstOrDefault(x => x.Email == email);

                if (user == null)
                {
                    MessageBox.Show("Email veya þifre hatalý!");
                    return;
                }
                if (user.Key != sha256_hash(password))
                {
                    MessageBox.Show("Email veya þifre hatalý!");
                    return;
                }

                UserHomeForm userHomeForm = new UserHomeForm(user);
                userHomeForm.ShowDialog();
            }
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(repository);
            profileForm.ShowDialog();
        }
    }
}
