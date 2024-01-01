using Roduna_Mekh_Project.CowWindows;
using Roduna_Mekh_Project.DiseaseWindows.Disesase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class CowForm : Form
    {


        MainWindow mainWindow;
        DataBase db = new DataBase();
        private bool isPanelExpanded;

        public CowForm(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();

            this.mainWindow = mainWindow;


        }


        public void SearchInDB(string tag, string value)
        {
            try
            {
                db.OpenConnection();

                string query = @"
                    SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, milkcount, diseaseid, cowration.idration 
                    FROM cow 
                    JOIN cowration ON cow.id = cowration.idcow
                    WHERE cow." + tag + " LIKE @" + value;
                


                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@" + value, "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cowDataGrid.DataSource = dataTable;
                    }
                }

                cowDataGrid.Columns[0].HeaderText = "ID";
                cowDataGrid.Columns[1].HeaderText = "Порода";
                cowDataGrid.Columns[2].HeaderText = "Стать";
                cowDataGrid.Columns[3].HeaderText = "Дата народження";
                cowDataGrid.Columns[4].HeaderText = "Вага";
                cowDataGrid.Columns[5].HeaderText = "Кількість їжі";
                cowDataGrid.Columns[6].HeaderText = "Дата вагітності";
                cowDataGrid.Columns[7].HeaderText = "К-сть молока";
                cowDataGrid.Columns[8].HeaderText = "Номер хвороби";
                cowDataGrid.Columns[9].HeaderText = "Номер раціону";
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

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, milkcount, diseaseid, cowration.idration 
                                    FROM cow 
                                    JOIN cowration ON cow.id = cowration.idcow";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cowDataGrid.DataSource = table;
                }


                cowDataGrid.Columns[0].HeaderText = "ID";
                cowDataGrid.Columns[1].HeaderText = "Порода";
                cowDataGrid.Columns[2].HeaderText = "Стать";
                cowDataGrid.Columns[3].HeaderText = "Дата народження";
                cowDataGrid.Columns[4].HeaderText = "Вага";
                cowDataGrid.Columns[5].HeaderText = "Кількість їжі";
                cowDataGrid.Columns[6].HeaderText = "Дата вагітності";
                cowDataGrid.Columns[7].HeaderText = "К-сть молока";
                cowDataGrid.Columns[8].HeaderText = "Номер хвороби";
                cowDataGrid.Columns[9].HeaderText = "Номер раціону";

            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці ration виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При вибірці даних виникла помилка\n\tСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear(); 
            FillDataGrid();
        }

        private void Nav1_MouseHover(object sender, EventArgs e) => Nav1.ForeColor = Color.Gray;

        private void Nav1_MouseLeave(object sender, EventArgs e) => Nav1.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav2_MouseHover(object sender, EventArgs e) => nav2.ForeColor = Color.Gray;

        private void nav2_MouseLeave(object sender, EventArgs e) => nav2.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav3_MouseHover(object sender, EventArgs e) => nav3.ForeColor = Color.Gray;

        private void nav3_MouseLeave(object sender, EventArgs e) => nav3.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav4_MouseHover(object sender, EventArgs e) => nav4.ForeColor = Color.Gray;

        private void nav4_MouseLeave(object sender, EventArgs e) => nav4.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav2_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.panel3.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.PanelForm(new DiseaseMainWindow(mainWindow));
        }

        private void Nav1_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.panel3.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.PanelForm(new RationMainWindow(mainWindow));
        }

        private void nav3_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AboutCowWithPreg(mainWindow));
        }

        private void nav4_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new CostsFlowFromCowWindow(mainWindow));
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                timer1.Tag = "Collapse";
                timer1.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                timer1.Tag = "Collapse";
                timer1.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                timer1.Tag = "Collapse";
                timer1.Start();
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
        }
    }
}

        
    

