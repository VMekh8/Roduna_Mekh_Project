using Bunifu.Framework.UI;
using System;
using System.Data.SqlClient;
using System.Drawing;
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

            Incrementbutton.Location = new Point(x, y);
            Decrementbutton.Location = new Point(x, y + Incrementbutton.Height);

            Incrementbutton.Visible = true;
            Decrementbutton.Visible = true;
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(activeTextBox.Text);
            if (activeTextBox == FuelConsumption)
            {
                currentValue++;
                activeTextBox.Text = currentValue.ToString();
            }
            else
            {
                currentValue += 0.5;
                activeTextBox.Text = currentValue.ToString();
            }
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(activeTextBox.Text);
            if (activeTextBox == FuelConsumption)
            {
                currentValue--;
                activeTextBox.Text = currentValue.ToString();
            }
            else
            {
                currentValue -= 0.5;
                activeTextBox.Text = currentValue.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            if (string.IsNullOrEmpty(NameField.Text) || string.IsNullOrEmpty(NameCultureTextBox.Text))
            {
                MessageBox.Show("Не введено поля з назвою поля або культурою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(areaField.Text) < 0 || double.Parse(PriceForTon.Text) < 0
                || double.Parse(FuelConsumption.Text) < 0 || double.Parse(ProductivityTextBox.Text) < 0)
            {
                MessageBox.Show("Числові поля введено з помилкою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете відправити ці дані?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.OpenConnection();

                        string query = @"INSERT INTO grain (name_field, area, type_culture, culture, productivity, fuel_consumption, date_sowing) 
                                VALUES (@name_field, @area, @type_culture, @culture, @productivity, @fuel_consumption, @date_sowing)";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@name_field", NameField.Text);
                            cmd.Parameters.AddWithValue("@area", double.Parse(areaField.Text));
                            cmd.Parameters.AddWithValue("@type_culture", CultureType.Text);
                            cmd.Parameters.AddWithValue("@culture", NameCultureTextBox.Text);
                            cmd.Parameters.AddWithValue("@productivity", double.Parse(ProductivityTextBox.Text));
                            cmd.Parameters.AddWithValue("@fuel_consumption", double.Parse(FuelConsumption.Text));
                            cmd.Parameters.AddWithValue("@date_sowing", Convert.ToDateTime(dateSowing.Value));

                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Success");
                            MessageBox.Show("Дані успішно відправленні", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("При відправленні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
