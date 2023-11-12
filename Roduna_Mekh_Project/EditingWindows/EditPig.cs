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
    public partial class EditPig : Form
    {
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditPig()
        {
            InitializeComponent();
            RefreshData();


            Create_Button();

            WeightTextBox.Enter += TextBox_Enter;
            AverageFood.Enter += TextBox_Enter;
        }

        private void RefreshData()
        {
            DataBase db = new DataBase();

            db.OpenConnection();

            string query = "SELECT id, gender, date_birth, breed, weight, average_food FROM pig";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection());
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_birth"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");

                    pigDataGrid.Rows.Add(
                       dataTable.Rows[i]["id"],
                       dataTable.Rows[i]["gender"],
                       formattedDate,
                       dataTable.Rows[i]["breed"],
                       dataTable.Rows[i]["weight"],
                       dataTable.Rows[i]["average_food"]
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
            for (int i = 0; i < 2; i++)
            {
                if (GenderDropDown.selectedValue == dataTable.Rows[ElementID.selectedIndex]["gender"].ToString())
                {
                    GenderDropDown.selectedIndex = i - 1; break;
                }
                else
                {
                    GenderDropDown.selectedIndex = i;
                }
            }
            DateBirth.Value = Convert.ToDateTime(dataTable.Rows[ElementID.selectedIndex]["date_birth"]);
            BreedTextBox.Text = dataTable.Rows[ElementID.selectedIndex]["breed"].ToString();
            WeightTextBox.Text = dataTable.Rows[ElementID.selectedIndex]["weight"].ToString();
            AverageFood.Text = dataTable.Rows[ElementID.selectedIndex]["average_food"].ToString();

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
                    DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити ці зміни?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        db.OpenConnection();
                        string query = "UPDATE pig SET gender = @gender, date_birth = @date_birth, " +
                            "breed = @breed, weight = @weight, average_food = @average_food WHERE id = @id";

                        using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@gender", GenderDropDown.selectedValue.ToString());
                            command.Parameters.AddWithValue("@date_birth", DateTime.Parse(DateBirth.Value.ToString()));
                            command.Parameters.AddWithValue("@breed", BreedTextBox.Text);
                            command.Parameters.AddWithValue("@weight", int.Parse(WeightTextBox.Text));
                            command.Parameters.AddWithValue("@average_food", int.Parse(AverageFood.Text));
                            command.Parameters.AddWithValue("@id", ID[ElementID.selectedIndex]);

                            pigDataGrid.Rows.Clear();
                            dataTable.Clear();
                            ElementID.Clear();
                            ID.Clear();

                            command.ExecuteNonQuery();
                            Console.Write("Зміни успішно відправлені");
                            RefreshData();
                            MessageBox.Show("Зміни успішно відправлені до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Під час додавання інформацію про худобу виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
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
    }
}
