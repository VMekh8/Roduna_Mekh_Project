using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.GrainWindows
{
    public partial class AddChemistGrainWindow : Form
    {
        private DataBase db = new DataBase();
        int chemistsIdSelected;
        public AddChemistGrainWindow()
        {
            InitializeComponent();
            GetLoadData();
        }

        private void GetGrainID()
        {
            GrainIDSpinner.Clear();
            try
            {
                db.OpenConnection();

                string query = @"SELECT id FROM grain";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GrainIDSpinner.AddItem(reader["id"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Виникла помилка при завантаженні полів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();   
            }
        }

        private void SetDataGrid(ref DataTable table)
        {
            grainDataGrid.DataSource = table;

            grainDataGrid.Columns[0].HeaderText = "ID";
            grainDataGrid.Columns[1].HeaderText = "Назва хімікату";
            grainDataGrid.Columns[2].HeaderText = "Тип хімікату";
            grainDataGrid.Columns[3].HeaderText = "Для яких культур";
            grainDataGrid.Columns[4].HeaderText = "Ціна";
        }

        private void GetChemistsData()
        {
            try
            {
                db.OpenConnection();

                string query = $"SELECT * FROM chemists";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    SetDataGrid(ref table);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Виникла помилка при завантаженні хімікатів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void GetLoadData()
        {
            GetGrainID();
            GetChemistsData();
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

        private void grainDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grainDataGrid.Rows[e.RowIndex];
                chemistsIdSelected = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GrainIDSpinner.selectedIndex < 0)
            {
                MessageBox.Show("Ви не вибрали поля\n\tСпробуйте ще раз", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(CountPreparateField.Text) || int.Parse(CountPreparateField.Text) < 0)
            {
                MessageBox.Show($"Недопустиме значення поля {"Кількість"} ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Ви впевненні, що хочете відправити ці дані?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No)
                {
                    return;
                }

                try
                {
                    db.OpenConnection();

                    string query = $"INSERT INTO grainchemist (IdGrain, IdChemist, Consumption, dataChemical)" +
                        $"VALUES (@IdGrain, @IdChemist, @Consumption, @dataChemical)";

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@IdGrain", int.Parse(GrainIDSpinner.selectedValue));
                        cmd.Parameters.AddWithValue("@IdChemist", chemistsIdSelected);
                        cmd.Parameters.AddWithValue("@Consumption", int.Parse(CountPreparateField.Text));
                        cmd.Parameters.AddWithValue("@dataChemical", Convert.ToDateTime(DateChemists.Value));

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Success");
                    MessageBox.Show("Відправлення пройшло успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Виникла помилка при відправленні даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
