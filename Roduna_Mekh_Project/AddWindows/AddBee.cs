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
            if (string.IsNullOrEmpty(NumberOfFamily.Text) || string.IsNullOrEmpty(HoneyAverage.Text))
            {
                MessageBox.Show("Поля не можуть бути порожніми\nСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(NumberOfFamily.Text) < 0 || int.Parse(HoneyAverage.Text) < 0)
            {
                MessageBox.Show("Поля не можуть бути від'ємними\nСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataBase db = new DataBase();

                DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"INSERT INTO bee (numbers_of_family, power_of_family, honey_average,
                                install_date, data_honey_collect, hive_state) VALUES (@numbers_of_family, @power_of_family, @honey_average,
                                @install_date, @data_honey_collect, @hive_state)";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@numbers_of_family", int.Parse(NumberOfFamily.Text));
                            cmd.Parameters.AddWithValue("@power_of_family", PowerOfFamily.selectedValue);
                            cmd.Parameters.AddWithValue("@honey_average", int.Parse(HoneyAverage.Text));
                            cmd.Parameters.AddWithValue("@install_date", Convert.ToDateTime(InstallDate.Value));
                            cmd.Parameters.AddWithValue("@data_honey_collect", Convert.ToDateTime(DataCollectHoney.Value));
                            cmd.Parameters.AddWithValue("@hive_state", int.Parse(HiveState.selectedValue));

                            cmd.ExecuteNonQuery();

                        }
                        MessageBox.Show("Відправлення даних відбулося успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("При відправленні даних відбулася помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }

            }
        }
    }
}