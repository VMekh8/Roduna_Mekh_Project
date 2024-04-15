using Roduna_Mekh_Project.GrainWindows;
using Roduna_Mekh_Project.GrainWindows.ChemistsWindows;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class GrainForm : Form
    {
        DataBase db = new DataBase();
        private bool isPanelExpanded = false;
        MainWindow mainWindow;

        public GrainForm(MainWindow mainWindow)
        {
            InitializeComponent();
            GetInfoFromDB();

            this.mainWindow = mainWindow;
            LoadColors();
        }

        private void NavBarHover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Gray;
        }

        private void NavBarMouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }
        }


        private void LoadColors()
        {
            mainWindow.panel1.BackColor = Color.FromArgb(23, 177, 10);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(23, 177, 10);
            mainWindow.panel3.BackColor = Color.FromArgb(23, 177, 10);
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchInDB("id", SearchTextBox.Text);
            }
            else if (radioButton2.Checked)
            {
                SearchInDB("name_field", SearchTextBox.Text);
            }
            else if (radioButton3.Checked)
            {
                SearchInDB("culture", SearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Ви не вибрали категорію пошуку\nОберіть критерій та спробуйте знову", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetInfoFromDB()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM grain";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    SetDataGridCol(ref table);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Виникла помилка при завантаженні даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SearchInDB(string tag, string value)
        {
            try
            {
                db.OpenConnection();

                string query = $"SELECT * FROM grain WHERE {tag} LIKE @{value}";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@" + value, "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        SetDataGridCol(ref table);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Виникла помилка при пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SetDataGridCol(ref DataTable table)
        {
            grainDataGrid.DataSource = table;

            grainDataGrid.Columns[0].HeaderText = "ID";
            grainDataGrid.Columns[1].HeaderText = "Назва поля";
            grainDataGrid.Columns[2].HeaderText = "Площа (Га)";
            grainDataGrid.Columns[3].HeaderText = "Тип культури";
            grainDataGrid.Columns[4].HeaderText = "Культура";
            grainDataGrid.Columns[5].HeaderText = "Врожайність";
            grainDataGrid.Columns[6].HeaderText = "Витрати палива";
            grainDataGrid.Columns[7].HeaderText = "Дата посіву";

            grainDataGrid.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            GetInfoFromDB();
        }

        private void Nav1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.PanelForm(new MainChemistWindow(mainWindow));
        }

        private void nav2_Click(object sender, EventArgs e) => mainWindow.PanelForm(new AddChemistGrainWindow());
    

        private void nav3_Click(object sender, EventArgs e) => mainWindow.PanelForm(new ChemistGrainWindow());
    }
}
