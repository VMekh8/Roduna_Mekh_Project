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

namespace Roduna_Mekh_Project.CowWindows
{
    public partial class AboutCowWithPreg : Form
    {
        DataBase db = new DataBase();
        DataTable table = new DataTable();
        MainWindow mainWindow;
        public AboutCowWithPreg(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid(); 
            FillInfoLabel();

            this.mainWindow = mainWindow;
        }

        private void FillInfoLabel()
        {
            label7.Text = table.Rows.Count.ToString();
            int milk = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                milk += Convert.ToInt32(table.Rows[i]["milkcount"]);
            }
            label5.Text = milk.ToString();
        }


        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, date_Birth, breed, date_pregnancy, milkcount, cowration.idration FROM cow
                                JOIN cowration ON cow.id = cowration.idcow WHERE cow.date_pregnancy IS NOT NULL";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    
                    adapter.Fill(table);

                    cowDataGrid.DataSource = table;
                    
                }

                cowDataGrid.Columns[0].HeaderText = "ID";
                cowDataGrid.Columns[1].HeaderText = "Дата народження";
                cowDataGrid.Columns[2].HeaderText = "Порода";
                cowDataGrid.Columns[3].HeaderText = "Дата вагітності";
                cowDataGrid.Columns[4].HeaderText = "Середня кількість молока";
                cowDataGrid.Columns[5].HeaderText = "Номер раціону";

            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці ration i cow виникла помилка");
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
            mainWindow.PanelForm(new CowForm(mainWindow));
        }
    }
}
