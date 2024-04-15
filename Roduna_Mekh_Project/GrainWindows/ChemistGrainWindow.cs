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

namespace Roduna_Mekh_Project.GrainWindows
{
    public partial class ChemistGrainWindow : Form
    {
        private DataBase db = new DataBase();
        public ChemistGrainWindow()
        {
            InitializeComponent();
            GetGrainData();
        }

        private void SetDataGrid(in DataTable table)
        {
            grainDataGrid.DataSource = table;

            grainDataGrid.Columns[0].HeaderText = "ID";
            grainDataGrid.Columns[1].HeaderText = "Назва хімікату";
            grainDataGrid.Columns[2].HeaderText = "Тип хімікату";
            grainDataGrid.Columns[3].HeaderText = "Кількість";
            grainDataGrid.Columns[4].HeaderText = "Дата обробки";

            grainDataGrid.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void GetChemistData(int id)
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT chemists.id, chemists.name_chemist, chemists.type_chemist, grainchemist.consumption, grainchemist.dataChemical  
                                FROM grainchemist
                                LEFT JOIN chemists ON grainchemist.idChemist = chemists.id
                                WHERE IdGrain = @id;
                                ";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        SetDataGrid(table);
                    }
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

        private void GetGrainData()
        {
            try
            {
                db.OpenConnection();

                string query = $"SELECT id FROM grain";

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
        private void GrainIDSpinner_onItemSelected(object sender, EventArgs e) => GetChemistData(int.Parse(GrainIDSpinner.selectedValue));

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

       
    }
}
