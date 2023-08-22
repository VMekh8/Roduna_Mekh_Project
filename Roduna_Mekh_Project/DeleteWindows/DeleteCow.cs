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
    public partial class DeleteCow : Form
    {
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();
        public DeleteCow()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            DataBase db = new DataBase();

            db.OpenConnection();

            string query = "SELECT id, gender, date_birth, breed, weight, average_food FROM cow";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_birth"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");

                    cowDataGrid.Rows.Add(
                       dataTable.Rows[i]["id"],
                       dataTable.Rows[i]["gender"],
                       formattedDate,
                       dataTable.Rows[i]["breed"],
                       dataTable.Rows[i]["weight"],
                       dataTable.Rows[i]["average_food"]
                       );

                }

                for (int i = 0; i < cowDataGrid.Rows.Count; i++)
                {
                    string rowText = "";

                    for (int j = 0; j < cowDataGrid.Columns.Count; j++)
                    {
                        if (cowDataGrid.Rows[i].Cells[j].Value != null)
                        {
                            rowText += cowDataGrid.Rows[i].Cells[j].Value.ToString() + "  ";
                        }
                    }
                    CowDelDropDown.AddItem(rowText.Trim());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CowDelDropDown.selectedIndex == -1)
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
                        int selectedIndex = CowDelDropDown.selectedIndex;
                        int idToDelete = int.Parse(ID[selectedIndex]);

                        string query = "DELETE FROM cow WHERE id = @ID";
                        using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@ID", idToDelete);
                            command.ExecuteNonQuery();
                        }

                        cowDataGrid.Rows.Clear();
                        dataTable.Clear();
                        CowDelDropDown.Clear();
                        ID.Clear();
                        RefreshData();
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
    }
}