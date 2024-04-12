using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
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

namespace Roduna_Mekh_Project.EditingWindows
{
    public partial class EditGrain : Form
    {
        DataBase db = new DataBase();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditGrain()
        {
            InitializeComponent();
            Create_Button();
            GetItemId();



            areaField.Enter += TextBox_Enter;
            FuelConsumption.Enter += TextBox_Enter;
            ProductivityTextBox.Enter += TextBox_Enter;
        }

       
        private void GetItemId()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT id FROM grain";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ElementID.AddItem(reader["id"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }


        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM grain WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(ElementID.selectedValue));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NameField.Text = reader["name_field"].ToString();
                            areaField.Text = reader["area"].ToString();
                            CultureType.Text = reader["type_culture"].ToString();
                            NameCultureTextBox.Text = reader["culture"].ToString();
                            ProductivityTextBox.Text = reader["productivity"].ToString();
                            FuelConsumption.Text = reader["fuel_consumption"].ToString();
                            dateSowing.Value = Convert.ToDateTime(reader["date_sowing"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                db.CloseConnection();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ElementID.selectedIndex == -1)
            {
                MessageBox.Show("Ви не вибрали поля для зміни", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Ви впевненні що хочете відправити ці дані?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {




                        db.OpenConnection();
                        string query = @"UPDATE grain SET name_field = @name_field, area = @area, 
                                     type_culture = @type_culture, culture = @culture, 
                                     productivity = @productivity, fuel_consumption = @fuel,
                                     date_sowing = @date_sowing WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(ElementID.selectedValue));
                            cmd.Parameters.AddWithValue("@name_field", NameField.Text);
                            cmd.Parameters.AddWithValue("@area", double.Parse(areaField.Text));
                            cmd.Parameters.AddWithValue("@type_culture", CultureType.Text);
                            cmd.Parameters.AddWithValue("@culture", NameCultureTextBox.Text);
                            cmd.Parameters.AddWithValue("@productivity", double.Parse(ProductivityTextBox.Text));
                            cmd.Parameters.AddWithValue("@fuel", double.Parse(FuelConsumption.Text));
                            cmd.Parameters.AddWithValue("@date_sowing", Convert.ToDateTime(dateSowing.Value));

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Success");
                        MessageBox.Show("Дані успішно зміненні", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("При змінні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
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
            if (activeTextBox == areaField)
            {
                currentValue += 0.05;
                activeTextBox.Text = currentValue.ToString();
            }
            else
            {
                currentValue++;
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
                else
                {
                    currentValue--;
                    activeTextBox.Text = currentValue.ToString();
                }

            }
        } 
    }
}
