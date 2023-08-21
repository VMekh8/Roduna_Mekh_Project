using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace Roduna_Mekh_Project.InformationWindows
{
    public partial class AddBee : Form
    {
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public AddBee()
        {
            InitializeComponent();
            Create_Button();

            NumberOfFamily.Enter += TextBox_Enter;
            HoneyAverage.Enter += TextBox_Enter;
            HoneyPrice.Enter += TextBox_Enter;

        }

        private void Create_Button()
        {
            Incrementbutton = new Button();
            Incrementbutton.Text = "+";
            Incrementbutton.Click += IncrementButton_Click;

            Decrementbutton = new Button();
            Decrementbutton.Text = "—";
            Decrementbutton.Click += DecrementButton_Click;

            Incrementbutton.Visible = false;
            Decrementbutton.Visible = false;

            

            Incrementbutton.Size = new Size(25, 20);
            Decrementbutton.Size = new Size(25, 20);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = (BunifuMaterialTextbox)sender;

            int x = activeTextBox.Location.X + activeTextBox.Width;
            int y = activeTextBox.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

            Incrementbutton.Visible = true;
            Decrementbutton.Visible = true;
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            currentValue++;
            activeTextBox.Text = currentValue.ToString();
        }


        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                currentValue--;
                activeTextBox.Text = currentValue.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NumberOfFamily.Text == "" || PowerOfFamily.selectedValue == null || HiveState.selectedValue == null || HoneyAverage.Text == "" || HoneyPrice.Text == "")
            {
                MessageBox.Show("Не всі обов'язкові поля були заповнені\nБудь ласка, заповніть всю інформацію", "Віправлення даних неможливе",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (int.Parse(NumberOfFamily.Text) < 0 || int.Parse(HiveState.selectedValue.ToString()) < 0 || int.Parse(HoneyAverage.Text) < 0 || int.Parse(HoneyPrice.Text.ToString()) < 0)
            {
                MessageBox.Show("Значення не можуть бути від'ємними\nБудь ласка, заповність поле коректно", "Віправлення даних неможливе",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                try
                {
                    DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=farmdatabase"))
                        {
                            connection.Open();

                            string insertQuery = "INSERT INTO bee (numbers_of_family, power_of_family, hive_state, honey_average, install_date, honey_price) " +
                                                 "VALUES (@NumberOfFamily, @PowerOfFamily, @HiveState, @HoneyAverage, @InstallDate, @HoneyPrice)";

                            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@NumberOfFamily", int.Parse(NumberOfFamily.Text));
                                command.Parameters.AddWithValue("@PowerOfFamily", PowerOfFamily.selectedValue.ToString());
                                command.Parameters.AddWithValue("@HiveState", int.Parse(HiveState.selectedValue.ToString()));
                                command.Parameters.AddWithValue("@HoneyAverage", int.Parse(HoneyAverage.Text));
                                command.Parameters.AddWithValue("@InstallDate", DateTime.Parse(InstallDate.Value.ToString()));
                                command.Parameters.AddWithValue("@HoneyPrice", int.Parse(HoneyPrice.Text.ToString()));

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine("Дані успішно додані до бази даних");
                                }
                                else
                                {
                                    Console.WriteLine("Дані не були додані до бази даних");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка при відправленні даних про вулик у базу даних");
                    Console.WriteLine("Код помилки: " + ex.Message);
                }
            }
        }
    }
}