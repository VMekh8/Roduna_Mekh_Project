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

namespace Roduna_Mekh_Project.RationWindows
{
    public partial class DeleteRationWindow : Form
    {
        DataBase db = new DataBase();
        List<string> rationId = new List<string>();

        MainWindow mainWindow;
        public DeleteRationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();
            FillDropDown();

            this.mainWindow = mainWindow;
        }

        private void FillDropDown()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM ration";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            rationId.Add(rdr["id"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("При заповненні випадаючого спику виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними списку виникла помилка", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach(var i in rationId)
            {
                RationDelDropDown.AddItem(i);
            }
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що бажаєте видалити цю інформацію?", "Видалення раціону",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (result == DialogResult.Yes)
            {
                if (RationDelDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали жодного елементу для видалення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "DELETE FROM ration WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", rationId[RationDelDropDown.selectedIndex]);

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Видалення інформації пройшло успішно");
                        MessageBox.Show("Видалення пройшло успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("При видаленні даних виникла помилка");
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("При видаленні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                        FillDataGrid();
                        RationDelDropDown.Clear();
                    }
                }
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
