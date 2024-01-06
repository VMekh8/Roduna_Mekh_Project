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

namespace Roduna_Mekh_Project.PigWindows
{
    public partial class PregnantPigWindow : Form
    {
        DataBase db = new DataBase();
        DataTable table = new DataTable();
        public PregnantPigWindow()
        {
            InitializeComponent();
            FillDataGrid();
            FillLabelInfo();
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, date_Birth, breed, date_pregnancy, DATEADD(month, 9, date_pregnancy) AS end_pregnancy, pigration.idration FROM pig
                    JOIN pigration ON pig.id = pigration.idpig WHERE pig.date_pregnancy IS NOT NULL";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    adapter.Fill(table);
                    pigDataGrid.DataSource = table;
                }

                pigDataGrid.Columns[0].HeaderText = "ID";
                pigDataGrid.Columns[1].HeaderText = "Дата народження";
                pigDataGrid.Columns[2].HeaderText = "Порода";
                pigDataGrid.Columns[3].HeaderText = "Дата вагітності";
                pigDataGrid.Columns[4].HeaderText = "Дата родів";
                pigDataGrid.Columns[5].HeaderText = "Номер раціону";

                pigDataGrid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                pigDataGrid.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                pigDataGrid.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці ration i pig виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При вибірці даних виникла помилка\n\tСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillLabelInfo()
        {
            label7.Text = table.Rows.Count.ToString();

            table.DefaultView.Sort = "end_pregnancy DESC";
            DateTime date = new DateTime();
            date = Convert.ToDateTime(table.Rows[0]["end_pregnancy"]);
            label6.Text = date.ToString("dd/MM/yyyy");

        }

    }
}
