using Bunifu.Framework.UI;
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

namespace Roduna_Mekh_Project.InformationWindows
{
    public partial class AddCow : Form
    {
        private BunifuMaterialTextbox activeTextBox;
        private Button Incrementbutton, Decrementbutton;

        public AddCow()
        {
            InitializeComponent();
            Create_Button();


            WeightTextBox.Enter += TextBox_Enter;
            AverageFood.Enter += TextBox_Enter;
        }
        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            currentValue += 10;
            activeTextBox.Text = currentValue.ToString();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                currentValue -= 10;
                activeTextBox.Text = currentValue.ToString();
            }
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



            Incrementbutton.Size = new Size(25, 23);
            Decrementbutton.Size = new Size(25, 22);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);

            int x = WeightTextBox.Location.X + WeightTextBox.Width;
            int y = WeightTextBox.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BreedTextBox.Text == "" || WeightTextBox.Text == "" || AverageFood.Text == "")
            {
                MessageBox.Show("Не всі обов'язкові поля були заповнені\nБудь ласка, заповніть всю інформацію", "Віправлення даних неможливе",
                   MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (Convert.ToInt32(WeightTextBox.Text) < 0 || Convert.ToInt32(AverageFood.Text) < 0)
            {
                MessageBox.Show("Значення при не можуть бути від'ємними\nБудь ласка, заповність поле коректно", "Віправлення даних неможливе",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                DataBase db = new DataBase();
                try
                {
                    DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        db.OpenConnection();
                        string query = "INSERT INTO cow (gender, date_birth, breed, weight, average_food) " +
                                       "VALUES (@GenderTextBox, @DateBirth, @BreedTextBox, @WeightTextBox, @AverageFood)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@GenderTextBox", GenderTextBox.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@DateBirth", DateTime.Parse(DateBirth.Value.ToString()));
                            cmd.Parameters.AddWithValue("@BreedTextBox", BreedTextBox.Text);
                            cmd.Parameters.AddWithValue("@WeightTextBox", int.Parse(WeightTextBox.Text));
                            cmd.Parameters.AddWithValue("@AverageFood", int.Parse(AverageFood.Text));

                            cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("Відправлення даних пройшло успішно");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Під час додавання інформацію про худобу виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }


    }

}


