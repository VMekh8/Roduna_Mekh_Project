using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Roduna_Mekh_Project.DeleteWindows
{
    public partial class DeleteBee : Form
    {
        List<string> ID = new List<string>();
        DataBase db = new DataBase();

        public DeleteBee()
        {
            InitializeComponent();
            FillDataGrid();
            FillIdList();
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

        private void FillIdList()
        {
            ID.Clear();
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM bee";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID.Add(reader["id"].ToString());
                        }
                    }
                }

                foreach (var i in ID)
                {
                    BeeDelDropDown.AddItem(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (BeeDelDropDown.selectedIndex == -1)
            {
                MessageBox.Show("Ви нічого не вибрали для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataBase db = new DataBase();
                try
                {
                    DialogResult dialog = MessageBox.Show("Ви впевнені що хочете видалити цей елемент?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        db.OpenConnection();
                        int selectedIndex = BeeDelDropDown.selectedIndex;
                        int idToDelete = int.Parse(ID[selectedIndex]);

                        string query = "DELETE FROM bee WHERE id = @ID";
                        using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@ID", idToDelete);
                            command.ExecuteNonQuery();
                        }
                       
                        Console.WriteLine("Дані успішно видалені");
                        MessageBox.Show("Дані успішно видалені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка при видаленні з таблиці bee");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("Виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
                finally
                {
                    db.CloseConnection();
                    BeeDelDropDown.Clear();
                    FillDataGrid();
                    FillIdList();

                }
            }
           
        }

       
        
    }
}
