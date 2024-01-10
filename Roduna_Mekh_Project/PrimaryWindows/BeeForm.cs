using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataBase db = new DataBase();
        MainWindow mainWindow;
        private bool isPanelExpanded = false;
        public BeeForm(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();
            
            this.mainWindow = mainWindow;

        }


        private void Nav_MouseHover(object sender, EventArgs e)
        {
            Label Nav = sender as Label;
            Nav.ForeColor = Color.Gray;
        }
        private void Nav_MouseLeave(object sender, EventArgs e)
        {
            Label Nav = sender as Label;
            Nav.ForeColor = Color.FromArgb(64, 64, 64);
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }
        }

        private void SearchInDB(string tag, string value)
        {
            try
            {
                db.OpenConnection();

                string query = $"SELECT * FROM bee WHERE {tag} LIKE @{value}";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@" + value, "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        beeDataGrid.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0) 
                        {
                            MessageBox.Show("За даними введеними в пошуку нічого не знайдено", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                beeDataGrid.Columns[0].HeaderText = "ID";
                beeDataGrid.Columns[1].HeaderText = "К-сть сімей";
                beeDataGrid.Columns[2].HeaderText = "Стан сімей";
                beeDataGrid.Columns[3].HeaderText = "К-сть меду";
                beeDataGrid.Columns[4].HeaderText = "Дата встановлення";
                beeDataGrid.Columns[5].HeaderText = "Дата ост. збору меду";
                beeDataGrid.Columns[6].HeaderText = "Стан вулика (%)";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При пошуку даних виникла помилка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM bee";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    beeDataGrid.DataSource = dataTable;

                    beeDataGrid.Columns[0].HeaderText = "ID";
                    beeDataGrid.Columns[1].HeaderText = "К-сть сімей";
                    beeDataGrid.Columns[2].HeaderText = "Стан сімей";
                    beeDataGrid.Columns[3].HeaderText = "К-сть меду";
                    beeDataGrid.Columns[4].HeaderText = "Дата встановлення";
                    beeDataGrid.Columns[5].HeaderText = "Дата ост. збору меду";
                    beeDataGrid.Columns[6].HeaderText = "Стан вулика (%)";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні таблиці виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            FillDataGrid();
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchInDB("id", SearchTextBox.Text);
            }
            else if (radioButton2.Checked)
            {
                SearchInDB("numbers_of_family", SearchTextBox.Text);
            }
            else if (radioButton3.Checked)
            {
                SearchInDB("date_install", SearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Ви не вибрали категорію пошуку\nОберіть критерій та спробуйте знову", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
