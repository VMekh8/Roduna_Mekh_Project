using Roduna_Mekh_Project.DiseaseWindows.Disesase;
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

namespace Roduna_Mekh_Project.DiseaseWindows.Medicine
{
    public partial class MedicineMainWindow : Form
    {
        MainWindow mainWindow;
        DataBase db = new DataBase();
        public MedicineMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();

            this.mainWindow = mainWindow;
         
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddMedicineWindow(mainWindow));
        }

        private void DeleteMedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteMedicineWindow(mainWindow));
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM medicine";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        MedicineDataGrid.DataSource = table;
                    }
                }

                MedicineDataGrid.Columns[0].HeaderText = "Id";
                MedicineDataGrid.Columns[1].HeaderText = "Назва препарату";
                MedicineDataGrid.Columns[2].HeaderText = "Тип препарату";
                MedicineDataGrid.Columns[3].HeaderText = "Для якого захворювання";
                MedicineDataGrid.Columns[4].HeaderText = "Ціна препарату";


            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці medicine виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При вибірці даних виникла помилка\n\tСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DiseaseMainWindow(mainWindow));


            mainWindow.panel1.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.panel3.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(112, 132, 231);
        }
    }
}
