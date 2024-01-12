using Bunifu.Framework.UI;
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

namespace Roduna_Mekh_Project.BeeWindows.BeeStateWindow
{
    public partial class HiveWindow : Form
    {
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        DataBase db = new DataBase();
        public HiveWindow()
        {
            InitializeComponent();
            FillDataGrid();
            FillIntoDropDown();
            Create_Button();

            RepairCostTextBox.Enter += TextBox_Enter;
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

        private void FillIntoDropDown()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT id FROM bee WHERE hive_state < 50";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ElementID.AddItem(Convert.ToString(reader["id"]));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних в таблицю виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var ActionRes = MessageBox.Show("Ви впевненні, що хочете додати цю інформацію?", "Відправлення інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ActionRes == DialogResult.Yes)
            {
                if (ElementID.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали ідентифікатор тварини\nЗаповніть, будь ласка, це поле", "Помилка відправлення даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(RepairCostTextBox.Text) || int.Parse(RepairCostTextBox.Text) < 0)
                {
                    MessageBox.Show("Неправильний формат даних\nСпробуйте, будь ласка, знову", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();

                        string query = "UPDATE bee SET repairextendes = @repair, hive_state = 100 WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(ElementID.selectedValue));
                            cmd.Parameters.AddWithValue("@repair", int.Parse(RepairCostTextBox.Text));

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Дані успішно відправленні", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("При відправленні даних в таблицю виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                        FillDataGrid();
                        FillIntoDropDown();
                    }
                }
            }
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT id, hive_state, install_date FROM bee WHERE hive_state < 50";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    beeDataGrid.DataSource = dataTable;

                    beeDataGrid.Columns[0].HeaderText = "ID";
                    beeDataGrid.Columns[1].HeaderText = "Стан вулику (%)";
                    beeDataGrid.Columns[2].HeaderText = "Дата вставнолення";

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних в таблицю виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
