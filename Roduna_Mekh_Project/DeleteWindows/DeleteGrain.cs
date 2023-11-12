using MySql.Data.MySqlClient;
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

namespace Roduna_Mekh_Project.DeleteWindows
{
    public partial class DeleteGrain : Form
    {
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();
        public DeleteGrain()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            DataBase db = new DataBase();

            db.OpenConnection();

            string query = "SELECT id, name_field, area_field, type_culture, date_sowing, fuel_consumption, productivity FROM grain";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection());
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_sowing"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");

                    grainDataGrid.Rows.Add(
                        dataTable.Rows[i]["id"],
                        dataTable.Rows[i]["name_field"],
                        dataTable.Rows[i]["area_field"],
                        dataTable.Rows[i]["type_culture"],
                        formattedDate,
                        dataTable.Rows[i]["fuel_consumption"],
                        dataTable.Rows[i]["productivity"]
                        );
                }

                for (int i = 0; i < grainDataGrid.Rows.Count; i++)
                {
                    string rowText = "";

                    for (int j = 0; j < grainDataGrid.Columns.Count; j++)
                    {
                        if (grainDataGrid.Rows[i].Cells[j].Value != null)
                        {
                            rowText += grainDataGrid.Rows[i].Cells[j].Value.ToString() + "  ";
                        }
                    }
                    GrainDelDropDown.AddItem(rowText.Trim());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GrainDelDropDown.selectedIndex == -1)
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
                        int selectedIndex = GrainDelDropDown.selectedIndex;
                        int idToDelete = int.Parse(ID[selectedIndex]);

                        string query = "DELETE FROM grain WHERE id = @ID";
                        using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@ID", idToDelete);
                            command.ExecuteNonQuery();
                        }
                        grainDataGrid.Rows.Clear();
                        dataTable.Clear();
                        GrainDelDropDown.Clear();
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