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

namespace Roduna_Mekh_Project.GrainWindows.ChemistsWindows
{
    public partial class DeleteChemistWindow : Form
    {
        DataBase db = new DataBase();
        public DeleteChemistWindow()
        {
            InitializeComponent();
            GetItemsId();
            GetItemToDataGrid();
        }

        private void DeleteFromDB(object sender, EventArgs e)
        {
            if (DelDropDown.selectedIndex == -1)
            {
                MessageBox.Show("Ви не вибрали поля для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Ви впевненні що хочете видалити це поле?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No) { return; }

                try
                {
                    db.OpenConnection();

                    string query = $"DELETE FROM chemists WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(DelDropDown.selectedValue));

                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("Success");
                    MessageBox.Show("Видалення даних пройшло успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetItemToDataGrid();
                    GetItemsId();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Виникла помилка при видаленні даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
                
            }
        }

        private void GetItemsId()
        {
            DelDropDown.Clear();
            try
            {
                db.OpenConnection();

                string query = "SELECT id FROM chemists";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DelDropDown.AddItem(reader["id"].ToString());
                        }
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

        private void GetItemToDataGrid()
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

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
