using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.DeleteWindows
{
    public partial class DeleteGrain : Form
    {

        DataBase db = new DataBase();
        public DeleteGrain()
        {
            InitializeComponent();
            GetInfoFromDB();
        }

        private void FillDropDown(ref DataTable table)
        {
            GrainDelDropDown.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                GrainDelDropDown.AddItem(table.Rows[i]["id"].ToString());
            }
        }

        private void SetDataGridCol(ref DataTable table)
        {
            grainDataGrid.DataSource = table;

            grainDataGrid.Columns[0].HeaderText = "ID";
            grainDataGrid.Columns[1].HeaderText = "Назва поля";
            grainDataGrid.Columns[2].HeaderText = "Площа (Га)";
            grainDataGrid.Columns[3].HeaderText = "Тип культури";
            grainDataGrid.Columns[4].HeaderText = "Культура";
            grainDataGrid.Columns[5].HeaderText = "Врожайність";
            grainDataGrid.Columns[6].HeaderText = "Витрати палива";
            grainDataGrid.Columns[7].HeaderText = "Дата посіву";
            grainDataGrid.Columns[8].HeaderText = "Ціна за кг";

            grainDataGrid.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void GetInfoFromDB()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT * FROM grain";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0 )
                    {
                        FillDropDown(ref table);
                    }

                    SetDataGridCol(ref table);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GrainDelDropDown.selectedIndex  == -1)
            {
                MessageBox.Show("Ви нічого не вибрали для видалення\n\tСпробуйте знову", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DialogResult result = MessageBox.Show("Ви впевненні, що хочете видалити це поле?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    try
                    {
                        db.OpenConnection();

                        string query = @"DELETE FROM grain WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(GrainDelDropDown.selectedValue));

                            cmd.ExecuteNonQuery();
                            GetInfoFromDB();

                            Console.WriteLine("Success");
                            MessageBox.Show("Дані успішно видалені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
        }
    }
}