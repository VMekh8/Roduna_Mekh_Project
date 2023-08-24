using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class BeeForm : Form
    {
        DataTable dataTable = new DataTable();

        private bool isPanelExpanded = false;
        public BeeForm()
        {
            InitializeComponent();
            UpdateSeasonLabel();
            WhatPlants();
            PrintIntoDataGrid();
            PrintGeneralInfo();



        }

        private void PrintIntoDataGrid()
        {
            DataBase db = new DataBase();
            db.OpenConnection();

            string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            dataTable.Clear();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");


                    beeDataGrid.Rows.Add(
                       dataTable.Rows[i]["id"],
                       dataTable.Rows[i]["numbers_of_family"],
                       dataTable.Rows[i]["power_of_family"],
                       dataTable.Rows[i]["hive_state"],
                       dataTable.Rows[i]["honey_average"],
                       formattedDate,
                       dataTable.Rows[i]["honey_price"]
                   );
                }
            }
        }
    


        private void PrintGeneralInfo()
        {
            Dictionary<string, int> RepairCost = new Dictionary<string, int>();
            string[] keys = {"90", "80", "70", "60", "50", "40", "30", "20", "10", "0" };
            double startPrice = 100;
            foreach (var k in keys)
            {
                RepairCost.Add(k, Convert.ToInt32(startPrice));
                startPrice *= 1.2;
            }
            int generalHoney = 0, hiveCounter = 0, generalIncome = 0, generalExpenses = 0;
            DataBase db = new DataBase();
            db.OpenConnection();
            string query = "SELECT hive_state, honey_average, honey_price FROM bee";
            string query1 = "UPDATE costsflow SET incomes = @incomes, extendes = @extendes WHERE id = @id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            dataTable.Clear();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0 )
            {
                hiveCounter = dataTable.Rows.Count;
                label7.Text = hiveCounter.ToString();

                for (int i =0; i<dataTable.Rows.Count; i++)
                {
                    generalHoney += Convert.ToInt32(dataTable.Rows[i]["honey_average"]);
                    generalIncome += generalHoney * Convert.ToInt32(dataTable.Rows[i]["honey_price"]);
                    if(RepairCost.ContainsKey(dataTable.Rows[i]["hive_state"].ToString()))
                    {
                        generalExpenses += RepairCost[dataTable.Rows[i]["hive_state"].ToString()];
                    }
                }
                label8.Text = generalHoney.ToString();
                label6.Text = generalIncome.ToString();
                label9.Text = generalExpenses.ToString();
                
            }
            MySqlCommand command = new MySqlCommand(query1, db.getConnection());
            command.Parameters.AddWithValue("@incomes", generalIncome);
            command.Parameters.AddWithValue("@extendes", generalExpenses);
            command.Parameters.AddWithValue("@id", 1);
            command.ExecuteNonQuery();
        }


        private void WhatPlants()
        {
            DateTime now = DateTime.Now;
            int month = now.Month;
            if (month >= 3 && month <= 5)
            {
                WhatPlantsLabel.Text = "● Проліски\n● Вишневі та яблуневі дереваn\n● Підсніжники\n● Жовте горицвіт\n● Крокуси";
            }
            else if (month >= 6 && month <= 8)
            {
                WhatPlantsLabel.Text = "● Бджолинець\n● Соняшник\n● Ромашка\n● Кульбаба\n● Липа";
            }
            else if (month >= 9 && month <= 11)
            {
                WhatPlantsLabel.Text = "● Чорнобривці\n● Горіхи\n● Таволга\n● Айстри\n● Герань";
            }
            else WhatPlantsLabel.Text = "● Зараз холодно\n Тому бджоли відпочивають.";
        }


        private void UpdateSeasonLabel()
        {
            DateTime now = DateTime.Now;
            int month = now.Month;

            string season = "";
            if (month >= 3 && month <= 5)
                season = "Весна";
            else if (month >= 6 && month <= 8)
                season = "Літо";
            else if (month >= 9 && month <= 11)
                season = "Осінь";
            else
                season = "Зима";

            SeasonLabel.Text = "Пора року: " + season;
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
                    string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee WHERE id = @id";
                    int desiredId = int.Parse(SearchTextBox.Text);
                    MySqlCommand command = new MySqlCommand(query, db.getConnection());
                    command.Parameters.AddWithValue("@id", desiredId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    dataTable.Clear();
                    beeDataGrid.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {


                            DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                            string formattedDate = installDate.ToString("yyyy-MM-dd");


                            beeDataGrid.Rows.Add(
                               dataTable.Rows[i]["id"],
                               dataTable.Rows[i]["numbers_of_family"],
                               dataTable.Rows[i]["power_of_family"],
                               dataTable.Rows[i]["hive_state"],
                               dataTable.Rows[i]["honey_average"],
                               formattedDate,
                               dataTable.Rows[i]["honey_price"]
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
                    string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee WHERE numbers_of_family = @numbers_of_family";
                    int desiredNumber = int.Parse(SearchTextBox.Text);
                    MySqlCommand command = new MySqlCommand(query, db.getConnection());
                    command.Parameters.AddWithValue("@numbers_of_family", desiredNumber);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    dataTable.Clear();
                    beeDataGrid.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {


                            DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                            string formattedDate = installDate.ToString("yyyy-MM-dd");


                            beeDataGrid.Rows.Add(
                               dataTable.Rows[i]["id"],
                               dataTable.Rows[i]["numbers_of_family"],
                               dataTable.Rows[i]["power_of_family"],
                               dataTable.Rows[i]["hive_state"],
                               dataTable.Rows[i]["honey_average"],
                               formattedDate,
                               dataTable.Rows[i]["honey_price"]
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
                    string inputDate = SearchTextBox.Text.Trim();
                    if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        db.OpenConnection();
                        string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee WHERE install_date = @install_date";
                        string desiredDate = SearchTextBox.Text;
                        MySqlCommand command = new MySqlCommand(query, db.getConnection());
                        command.Parameters.AddWithValue("@install_date", desiredDate);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        dataTable.Clear();
                        beeDataGrid.Rows.Clear();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {


                                DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                                string formattedDate = installDate.ToString("yyyy-MM-dd");


                                beeDataGrid.Rows.Add(
                                   dataTable.Rows[i]["id"],
                                   dataTable.Rows[i]["numbers_of_family"],
                                   dataTable.Rows[i]["power_of_family"],
                                   dataTable.Rows[i]["hive_state"],
                                   dataTable.Rows[i]["honey_average"],
                                   formattedDate,
                                   dataTable.Rows[i]["honey_price"]
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
                    else
                    {
                        MessageBox.Show("Ви ввели неправильний формат дати,\nПравильний формат: yyyy-MM-dd", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            beeDataGrid.Rows.Clear();
            PrintIntoDataGrid();   
        }
    }
}
