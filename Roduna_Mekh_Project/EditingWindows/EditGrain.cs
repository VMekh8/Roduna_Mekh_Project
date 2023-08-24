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

namespace Roduna_Mekh_Project.EditingWindows
{
    public partial class EditGrain : Form
    {
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditGrain()
        {
            InitializeComponent();
            Create_Button();
            RefreshData();


            areaField.Enter += TextBox_Enter;
            FuelConsumption.Enter += TextBox_Enter;
            ProductivityTextBox.Enter += TextBox_Enter;
            PriceForTon.Enter += TextBox_Enter;
        }

        private void RefreshData()
        {
            DataBase db = new DataBase();

            db.OpenConnection();
            string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity, price_for_ton FROM grain";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_sowing"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");

                    grainDataGrid.Rows.Add(
                        dataTable.Rows[i]["id"],
                        dataTable.Rows[i]["name_field"],
                        dataTable.Rows[i]["area_field"],
                        dataTable.Rows[i]["type_culture"],
                        formattedDate,
                        dataTable.Rows[i]["fuel_consumption"],
                        dataTable.Rows[i]["productivity"]
                        );
                }

                foreach (var s in ID)
                {
                    ElementID.AddItem(s);
                }
            }
        }

        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            NameField.Text = dataTable.Rows[ElementID.selectedIndex]["name_field"].ToString();
            areaField.Text = dataTable.Rows[ElementID.selectedIndex]["area_field"].ToString();
            CultureType.Text = dataTable.Rows[ElementID.selectedIndex]["type_culture"].ToString();
            dateSowing.Value = Convert.ToDateTime(dataTable.Rows[ElementID.selectedIndex]["date_sowing"]);
            FuelConsumption.Text = dataTable.Rows[ElementID.selectedIndex]["fuel_consumption"].ToString();
            ProductivityTextBox.Text = dataTable.Rows[ElementID.selectedIndex]["productivity"].ToString();
            PriceForTon.Text = dataTable.Rows[ElementID.selectedIndex]["productivity"].ToString();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ElementID.selectedIndex == -1)
            {
                MessageBox.Show("Ви не вибрали елемент для редагування\nВиберіть будь ласка елемент та спробуйте знову", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataBase db = new DataBase();
                try
                {
                    db.OpenConnection();
                    string query = "UPDATE grain SET name_field = @name_field, area_field = @area_field, type_culture = @type_culture, date_sowing = @date_sowing, fuel_consumption = @fuel_consumption, " +
                        "productivity = @productivity, price_for_ton = @price_for_ton WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
                    {
                        command.Parameters.AddWithValue("@name_field", NameField.Text);
                        command.Parameters.AddWithValue("@area_field", double.Parse(areaField.Text));
                        command.Parameters.AddWithValue("@type_culture", CultureType.Text);
                        command.Parameters.AddWithValue("@date_sowing", DateTime.Parse(dateSowing.Value.ToString()));
                        command.Parameters.AddWithValue("@fuel_consumption", int.Parse(FuelConsumption.Text));
                        command.Parameters.AddWithValue("@productivity", double.Parse(ProductivityTextBox.Text));
                        command.Parameters.AddWithValue("@price_for_ton", double.Parse(PriceForTon.Text));
                        command.Parameters.AddWithValue("@id", ID[ElementID.selectedIndex]);

                        grainDataGrid.Rows.Clear();
                        dataTable.Clear();
                        ElementID.Clear();
                        ID.Clear();

                        command.ExecuteNonQuery();

                    }
                    Console.WriteLine("Відправлення даних пройшло успішно");
                    RefreshData();
                    MessageBox.Show("Дані успішно додані до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Під час додавання інформацію про поле виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.CloseConnection();
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
