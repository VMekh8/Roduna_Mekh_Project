using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.DeleteWindows
{
    public partial class DeleteBee : Form
    {
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();

        public DeleteBee()
        {
            InitializeComponent();

            DataBase db = new DataBase();
            db.OpenConnection();

            string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());

            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");


                    beeDataGrid.Rows.Add(
                       dataTable.Rows[i]["id"],
                       dataTable.Rows[i]["numbers_of_family"],
                       dataTable.Rows[i]["power_of_family"],
                       dataTable.Rows[i]["hive_state"],
                       dataTable.Rows[i]["honey_average"],
                       formattedDate,
                       dataTable.Rows[i]["honey_price"]
                   );
                }
            }

            for (int i = 0; i < beeDataGrid.Rows.Count; i++)
            {
                string rowText = "";

                for (int j = 0; j < beeDataGrid.Columns.Count; j++)
                {
                    if (beeDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        rowText += beeDataGrid.Rows[i].Cells[j].Value.ToString() + "  ";
                    }

                }

                BeeDelDropDown.AddItem(rowText.Trim());
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
                        using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@ID", idToDelete);
                            command.ExecuteNonQuery();
                        }

                        beeDataGrid.Rows.RemoveAt(selectedIndex);

                        BeeDelDropDown.Clear();
                        LoadDataToDropDown();
                        LoadDataToDropDown();
                        LoadDataToDropDown();

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

                }
            }
           
        }
        private void LoadDataToDropDown()
        {
            BeeDelDropDown.Clear();

            for (int i = 0; i < beeDataGrid.Rows.Count; i++)
            {
                string rowText = "";

                for (int j = 0; j < beeDataGrid.Columns.Count; j++)
                {
                    if (beeDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        rowText += beeDataGrid.Rows[i].Cells[j].Value.ToString() + "  ";
                    }

                }

                BeeDelDropDown.AddItem(rowText.Trim());
            }
        }

       
    }
}
