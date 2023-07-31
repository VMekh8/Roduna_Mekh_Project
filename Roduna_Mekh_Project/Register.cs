using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private Login login = new Login();
        Register register;
        private void label6_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login.Visible = false; 
            }

            
            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;

            
            Timer timer = new Timer();
            timer.Interval = 30;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep; 
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop(); 
                    this.Hide(); 
                    login.Opacity = 0; 
                    login.Show(); 
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        login.Opacity = stepSize * currentFadeInStep; 
                        currentFadeInStep++;
                        if (currentFadeInStep > totalSteps)
                        {
                            fadeInTimer.Stop(); 
                        }
                    };
                    fadeInTimer.Start(); 
                }
            };
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;


        
            Timer timer = new Timer();
            timer.Interval = 30;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep;
                currentStep++;
                if (this.Opacity == 0)
                {
                    timer.Stop();
                    Application.Exit();
                }

            };
            timer.Start();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UsernameField.Text == "" || PasswordField.Text == "" || ConfirmField.Text == "")
            {
                MessageBox.Show("Не всі обов'язкові поля були заповнені\nБудь ласка, заповніть всю інформацію", "Авторизація неможлива",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string loginUser = UsernameField.Text;
            string passwordUser = PasswordField.Text;
            string confirmpassword = ConfirmField.Text;
            if (confirmpassword == passwordUser)
            {
                DataBase db = new DataBase();
                try
                {
                    db.OpenConnection();
                    string query = "INSERT INTO `users` (login, password) VALUES (@login, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@login", loginUser);
                        cmd.Parameters.AddWithValue("@password", passwordUser);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Реєстрація пройшла успішно.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                    MessageBox.Show("Під час реєстрації сталася помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Введені паролі не співпадають\n           Спробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UsernameField.Clear();
            PasswordField.Clear();
            ConfirmField.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PasswordField.PasswordChar = '\0';
                ConfirmField.PasswordChar = '\0';
            }
            else
            {
                PasswordField.PasswordChar = '•';
                ConfirmField.PasswordChar = '•';
            }
        }
    }
}
