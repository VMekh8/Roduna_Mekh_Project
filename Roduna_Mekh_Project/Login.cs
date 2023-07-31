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
    public partial class Login : Form
    {
        private Register register;
        private Form1 form1;
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (register == null)
            {
                register = new Register();
                register.Visible = false;
            }

            
            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;

            
            Timer timer = new Timer();
            timer.Interval = 10;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep; 
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop(); 
                    this.Hide(); 
                    register.Opacity = 0; 
                    register.Show(); 
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        register.Opacity = stepSize * currentFadeInStep; 
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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "" || PasswordField.Text == "")
            {
                MessageBox.Show("Не всі обов'язкові поля були заповнені\nБудь ласка, заповніть всю інформацію", "Авторизація неможлива",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string loginUser = LoginField.Text;
                string passwordUser = PasswordField.Text;

                DataBase db = new DataBase();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    if (form1 == null)
                    {
                        form1 = new Form1();
                        form1.Visible = false;
                    }


                    int totalSteps = 20;
                    double stepSize = 1.0 / totalSteps;


                    Timer timer = new Timer();
                    timer.Interval = 10;
                    int currentStep = 0;
                    timer.Tick += (s, ev) =>
                    {
                        this.Opacity = 1 - stepSize * currentStep;
                        currentStep++;
                        if (currentStep > totalSteps)
                        {
                            timer.Stop();
                            this.Hide();
                            form1.Opacity = 0;
                            form1.Show();
                            Timer fadeInTimer = new Timer();
                            fadeInTimer.Interval = 30;
                            int currentFadeInStep = 0;
                            fadeInTimer.Tick += (c, av) =>
                            {
                                form1.Opacity = stepSize * currentFadeInStep;
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
                else
                {
                    MessageBox.Show("Невірний логін або пароль\n        Спробуйте знову", "Авторизація неможлива!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginField.Clear();
                    PasswordField.Clear();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LoginField.Clear();
            PasswordField.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordField.PasswordChar = '\0';   
            }
            else
            {
                PasswordField.PasswordChar = '•';
            }
        }
    }
}
