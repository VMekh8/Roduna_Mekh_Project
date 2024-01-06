using MySql.Data.MySqlClient;
using Roduna_Mekh_Project.DiseaseWindows.Disesase;
using Roduna_Mekh_Project.PigWindows;
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
    public partial class PigForm : Form
    {
        DataBase db = new DataBase();
        private bool isPanelExpanded = false;
        MainWindow mainWindow;
        public PigForm(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();

            this.mainWindow = mainWindow;
            ChangePanelsColor();
        }

        private void OpenDiseaseWindow()
        {
            var diseaseWindow = new DiseaseMainWindow(mainWindow);
            diseaseWindow.OnClosedWindow += OnClosed;
            mainWindow.PanelForm(diseaseWindow);
        }

        private void OnClosed()
        {
            mainWindow.PanelForm(this);
            ChangePanelsColor();
        }

        private void OpenRationWindow()
        {
            var rationWindow = new RationMainWindow(mainWindow);
            rationWindow.OnClosedWindow += OnClosed;
            mainWindow.PanelForm(rationWindow);
        }

        private void ChangePanelsColor()
        {
            mainWindow.panel1.BackColor = Color.FromArgb(223, 85, 179);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(223, 85, 179);
            mainWindow.panel3.BackColor = Color.FromArgb(223, 85, 179);
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

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, diseaseid, pigration.idration 
                                    FROM pig 
                                    JOIN pigration ON pig.id = pigration.idpig";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    pigDataGrid.DataSource = dataTable;
                }

                pigDataGrid.Columns[0].HeaderText = "ID";
                pigDataGrid.Columns[1].HeaderText = "Порода";
                pigDataGrid.Columns[2].HeaderText = "Стать";
                pigDataGrid.Columns[3].HeaderText = "Дата народження";
                pigDataGrid.Columns[4].HeaderText = "Вага";
                pigDataGrid.Columns[5].HeaderText = "Кількість їжі";
                pigDataGrid.Columns[6].HeaderText = "Дата вагітності";
                pigDataGrid.Columns[7].HeaderText = "Номер хвороби";
                pigDataGrid.Columns[8].HeaderText = "Номер раціону";

                pigDataGrid.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                pigDataGrid.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";


            }
            catch (SqlException ex)
            {
                MessageBox.Show("При завантаженні даних у таблицю виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public void SearchInDB(string tag, string value)
        {
            try
            {
                db.OpenConnection();

                string query = @"
                    SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, diseaseid, pigration.idration 
                    FROM pig 
                    JOIN pigration ON pig.id = pigration.idpig
                    WHERE pig." + tag + " LIKE @" + value;



                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@" + value, "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        pigDataGrid.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("За даними введеними в пошуку нічого не знайдено", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                pigDataGrid.Columns[0].HeaderText = "ID";
                pigDataGrid.Columns[1].HeaderText = "Порода";
                pigDataGrid.Columns[2].HeaderText = "Стать";
                pigDataGrid.Columns[3].HeaderText = "Дата народження";
                pigDataGrid.Columns[4].HeaderText = "Вага";
                pigDataGrid.Columns[5].HeaderText = "Кількість їжі";
                pigDataGrid.Columns[6].HeaderText = "Дата вагітності";
                pigDataGrid.Columns[7].HeaderText = "Номер хвороби";
                pigDataGrid.Columns[8].HeaderText = "Номер раціону";

                pigDataGrid.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                pigDataGrid.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Виникла помилка при зчитуванні даних з бази даних");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchInDB("id", SearchTextBox.Text);
            }
            else if (radioButton2.Checked)
            {
                SearchInDB("breed", SearchTextBox.Text);
            }
            else if (radioButton3.Checked)
            {
                SearchInDB("gender", SearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Ви не вибрали категорію пошуку\nОберіть критерій та спробуйте знову", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tag = "Collapse";
            timer1.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tag = "Collapse";
            timer1.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tag = "Collapse";
            timer1.Start();
        }

        private void Nav1_MouseHover(object sender, EventArgs e) => Nav1.ForeColor = Color.Gray;
        private void Nav1_MouseLeave(object sender, EventArgs e) => Nav1.ForeColor = Color.FromArgb(64, 64, 64);
        private void nav2_MouseHover(object sender, EventArgs e) => nav2.ForeColor = Color.Gray;
        private void nav2_MouseLeave(object sender, EventArgs e) => nav2.ForeColor = Color.FromArgb(64, 64, 64);
        private void nav3_MouseHover(object sender, EventArgs e) => nav3.ForeColor = Color.Gray;
        private void nav3_MouseLeave(object sender, EventArgs e) => nav3.ForeColor = Color.FromArgb(64, 64, 64);
        private void nav4_MouseHover(object sender, EventArgs e) => nav4.ForeColor = Color.Gray;
        private void nav4_MouseLeave(object sender, EventArgs e) => nav4.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav2_Click(object sender, EventArgs e) => OpenDiseaseWindow();
        private void Nav1_Click(object sender, EventArgs e) => OpenRationWindow();
        private void nav3_Click(object sender, EventArgs e) => mainWindow.PanelForm(new PregnantPigWindow());
        private void nav4_Click(object sender, EventArgs e) => mainWindow.PanelForm(new PigCostFlowWindow());

    }
}

