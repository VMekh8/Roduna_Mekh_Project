using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.GrainWindows.ChemistsWindows
{
    public partial class MainChemistWindow : Form
    {
        private bool isPanelExpanded = false;
        MainWindow mainWindow;
        DataBase db = new DataBase();
        public MainChemistWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            GetInfoFromDB();

            this.mainWindow = mainWindow;
            SetLoadColor();
        }


        private void SearchInDB(string tag, string value) 
        {
            try
            {
                db.OpenConnection();

                string query = $"SELECT * FROM chemists WHERE {tag} LIKE @{value}";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@" + value, "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        SetDataGrid(ref table);
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

        private void GetInfoFromDB()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT * FROM chemists";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        SetDataGrid(ref table);
                    }
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

        private void SetDataGrid(ref DataTable table)
        {
            ChemistDataGrid.DataSource = table;

            ChemistDataGrid.Columns[0].HeaderText = "ID";
            ChemistDataGrid.Columns[1].HeaderText = "Назва препарату";
            ChemistDataGrid.Columns[2].HeaderText = "Тип препарату";
            ChemistDataGrid.Columns[3].HeaderText = "Для яких культур";
            ChemistDataGrid.Columns[4].HeaderText = "Ціна";
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

        private void SetLoadColor()
        {
            mainWindow.panel1.BackColor = Color.MediumAquamarine;
            mainWindow.TopPanelDesign.BackColor = Color.MediumAquamarine;
            mainWindow.panel3.BackColor = Color.MediumAquamarine;
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

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.PanelForm(new GrainForm(mainWindow));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            GetInfoFromDB();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SearchInDB("id", SearchTextBox.Text);
            }
            else if (radioButton2.Checked)
            {
                SearchInDB("name_chemist", SearchTextBox.Text);
            }
            else if (radioButton3.Checked)
            {
                SearchInDB("type_chemist", SearchTextBox.Text);
            }
            else
            {
                MessageBox.Show("Ви не вибрали категорію пошуку\nОберіть критерій та спробуйте знову", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nav2_Click(object sender, EventArgs e) => mainWindow.PanelForm(new AddChemistWindow());
        private void nav3_Click(object sender, EventArgs e) => mainWindow.PanelForm(new DeleteChemistWindow());
    }
}
