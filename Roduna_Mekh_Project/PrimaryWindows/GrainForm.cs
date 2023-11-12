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

namespace Roduna_Mekh_Project
{
    public partial class GrainForm : Form
    {
        DataTable dataTable = new DataTable();

        private bool isPanelExpanded = false;

        public GrainForm()
        {
            InitializeComponent();
            PrintIntoDataGrid();
            PrintGeneralInfo();
        }

        private void PrintIntoDataGrid()
        {
            
            DataBase db = new DataBase();
            db.OpenConnection();

            string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity FROM grain";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection());
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
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
            }
        }

        private void PrintGeneralInfo()
        {
            double generalArea = 0, generalProductivity = 0, generalIncome = 0, generalExpenses = 0;
            DataBase db = new DataBase();
            db.OpenConnection();
            string query = "SELECT area_field, productivity, price_for_ton, fuel_consumption FROM grain";
            string query1 = "UPDATE costsflow SET incomes = @incomes, extendes = @extendes WHERE id = @id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection());
            dataTable.Clear();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                for(int i=0; i<dataTable.Rows.Count; i++)
                {
                    generalArea += double.Parse(dataTable.Rows[i]["area_field"].ToString());
                    generalProductivity += double.Parse(dataTable.Rows[i]["productivity"].ToString());
                    generalIncome += double.Parse(dataTable.Rows[i]["area_field"].ToString()) * double.Parse(dataTable.Rows[i]["productivity"].ToString()) * double.Parse(dataTable.Rows[i]["price_for_ton"].ToString());
                    generalExpenses += double.Parse(dataTable.Rows[i]["fuel_consumption"].ToString());

                }
                generalIncome *= 1000;
                generalExpenses *= 51;
                label8.Text = generalExpenses.ToString();
                label7.Text = generalArea.ToString();
                label6.Text = generalProductivity.ToString();
                label5.Text = generalIncome.ToString();
                SqlCommand command = new SqlCommand(query1, db.getConnection());
                command.Parameters.AddWithValue("@incomes", generalIncome);
                command.Parameters.AddWithValue("@extendes", generalExpenses);
                command.Parameters.AddWithValue("@id", 4);
                command.ExecuteNonQuery();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;
            int targetHeight = 0;

            if (timer1.Tag.ToString() == "Expand")
            {
                targetHeight = panel2.MaximumSize.Height;
            }
            else if (timer1.Tag.ToString() == "Collapse")
            {
                targetHeight = panel2.MinimumSize.Height;
            }

            if (panel2.Height != targetHeight)
            {
                int step = (targetHeight - panel2.Height > 0) ? animationSpeed : -animationSpeed;
                panel2.Height += step;

                if ((step > 0 && panel2.Height > targetHeight) || (step < 0 && panel2.Height < targetHeight))
                {
                    panel2.Height = targetHeight;
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isPanelExpanded)
            {
                timer1.Tag = "Expand";
                timer1.Start();
            }
            else
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }

            isPanelExpanded = !isPanelExpanded;
        }

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Ви не вибрали ніяких параметрів для пошуку.\nВиберіть один з параметрів біля рядка пошуку", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataBase db = new DataBase();
                if (radioButton1.Checked)
                {
                    db.OpenConnection();
                    string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity FROM grain WHERE id = @id";
                    int desiredId = int.Parse(SearchTextBox.Text);
                    SqlCommand command = new SqlCommand(query, db.getConnection());
                    command.Parameters.AddWithValue("@id", desiredId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable.Clear();
                    grainDataGrid.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {

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
                    }
                    else
                    {
                        MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PrintIntoDataGrid();
                        SearchTextBox.Clear();
                    }
                    db.CloseConnection();
                }
                if (radioButton2.Checked)
                {
                    db.OpenConnection();
                    string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity FROM grain WHERE name_field = @name_field";
                    string desiredId = SearchTextBox.Text;
                    SqlCommand command = new SqlCommand(query, db.getConnection());
                    command.Parameters.AddWithValue("@name_field", desiredId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable.Clear();
                    grainDataGrid.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {

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
                    }
                    else
                    {
                        MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PrintIntoDataGrid();
                        SearchTextBox.Clear();
                    }
                    db.CloseConnection();
                }
                if (radioButton3.Checked)
                {
                    db.OpenConnection();
                    string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity FROM grain WHERE type_culture = @type_culture";
                    string desiredId = SearchTextBox.Text;
                    SqlCommand command = new SqlCommand(query, db.getConnection());
                    command.Parameters.AddWithValue("@type_culture", desiredId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable.Clear();
                    grainDataGrid.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {

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
                    }
                    else
                    {
                        MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PrintIntoDataGrid();
                        SearchTextBox.Clear();
                    }
                    db.CloseConnection();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            grainDataGrid.Rows.Clear();
            dataTable.Clear();
            PrintIntoDataGrid();
        }
    }
}
