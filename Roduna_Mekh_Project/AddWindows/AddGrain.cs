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
    public partial class AddGrain : Form
    {
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;

        public AddGrain()
        {
            InitializeComponent();
            Create_Button();


            areaField.Enter += TextBox_Enter;
            FuelConsumption.Enter += TextBox_Enter;
            ProductivityTextBox.Enter += TextBox_Enter;
            PriceForTon.Enter += TextBox_Enter;
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
            double currentValue = double.Parse(activeTextBox.Text);
            if (activeTextBox == areaField)
            {
                currentValue += 0.05;
                activeTextBox.Text = currentValue.ToString();
            }
            else if (activeTextBox == FuelConsumption)
            {
                currentValue++;
                activeTextBox.Text = currentValue.ToString();
            }
            else if (activeTextBox == PriceForTon)
            {
                currentValue += 0.5;
                activeTextBox.Text = currentValue.ToString();
            }
            else if (activeTextBox == ProductivityTextBox)
            {
                currentValue += 0.5;
                activeTextBox.Text = currentValue.ToString();
            }
        }

      
        private void DecrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                if (activeTextBox == areaField)
                {
                    currentValue -= 0.05;
                    activeTextBox.Text = currentValue.ToString();
                }
                else if (activeTextBox == FuelConsumption)
                {
                    currentValue--;
                    activeTextBox.Text = currentValue.ToString();
                }
                else if (activeTextBox == PriceForTon)
                {
                    currentValue -= 0.5;
                    activeTextBox.Text = currentValue.ToString();
                }
                else if (activeTextBox == ProductivityTextBox)
                {
                    currentValue -= 0.5;
                    activeTextBox.Text = currentValue.ToString();
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string querty = "INSERT INTO grain (name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity, price_for_ton) " +
                "VALUES (@NameField, @areaField, @CultureType, @dateSowing, @FuelConsumption, @productivity, @price_for_ton)";
            try
            {
                    if (NameField.Text == "" || areaField.Text == "" || CultureType.Text == "" || FuelConsumption.Text == "" || ProductivityTextBox.Text == "" || PriceForTon.Text == "")
                    {
                        MessageBox.Show("Не всі обов'язкові поля були заповнені\nБудь ласка, заповніть всю інформацію", "Віправлення даних неможливе",
                       MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                    else if (double.Parse(areaField.Text) < 0 || int.Parse(FuelConsumption.Text) < 0 || double.Parse(ProductivityTextBox.Text) < 0 || double.Parse(PriceForTon.Text) < 0)
                    {
                        MessageBox.Show("Значення не можуть бути від'ємними\nБудь ласка, заповність поле коректно", "Віправлення даних неможливе",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                        db.OpenConnection();
                        using (MySqlCommand command = new MySqlCommand(querty, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@NameField", NameField.Text);
                            command.Parameters.AddWithValue("@areaField", double.Parse(areaField.Text));
                            command.Parameters.AddWithValue("@CultureType", CultureType.Text);
                            command.Parameters.AddWithValue("@dateSowing", DateTime.Parse(dateSowing.Value.ToString()));
                            command.Parameters.AddWithValue("@FuelConsumption", int.Parse(FuelConsumption.Text));
                            command.Parameters.AddWithValue("@productivity", double.Parse(ProductivityTextBox.Text));
                            command.Parameters.AddWithValue("@price_for_ton", double.Parse(PriceForTon.Text));
                            

                            command.ExecuteNonQuery();

                        }
                        Console.WriteLine("Відправлення даних пройшло успішно");
                        MessageBox.Show("Дані успішно додані до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("При додаванні даних у таблицю grain виникла помилка");
                Console.WriteLine($"Помилка: {ex.Message}");
                MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                db.CloseConnection();
            }
        }

    }

}