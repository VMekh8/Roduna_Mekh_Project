using Roduna_Mekh_Project.RationWindows;
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
    public partial class RationMainWindow : Form
    {
        MainWindow mainWindow;
        DataBase db = new DataBase();
        public RationMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();


            this.mainWindow = mainWindow;
            ChangeWindowColors();
        }

        private void ChangeWindowColors()
        {
            mainWindow.panel1.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.panel3.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(177, 122, 162);
        }

        public delegate void OnClosedWindowDelegate();
        public event OnClosedWindowDelegate OnClosedWindow;

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            OnClosedWindow?.Invoke();
        }

        private void AddRationButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddRationWindow(mainWindow));
        }

        private void DeleteRationButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteRationWindow(mainWindow));
        }
        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM ration";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    RationDataGrid.DataSource = table;
                }

                RationDataGrid.Columns[0].HeaderText = "Id";
                RationDataGrid.Columns[1].HeaderText = "Опис раціону";
                RationDataGrid.Columns[2].HeaderText = "Вартість раціону";
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

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
