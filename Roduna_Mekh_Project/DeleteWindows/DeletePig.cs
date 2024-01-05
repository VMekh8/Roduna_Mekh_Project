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
    public partial class DeletePig : Form
    {
        List<string> ID = new List<string>();
        DataBase db = new DataBase();
        public DeletePig()
        {
            InitializeComponent();
            GetIdToDropDown();
            FillDataGrid();
            

        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, diseaseid, pigration.idration 
                                    FROM pig 
                                    JOIN pigration ON pig.id = pigration.idpig";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    pigDataGrid.DataSource = dataTable;
                }

                pigDataGrid.Columns[0].HeaderText = "ID";
                pigDataGrid.Columns[1].HeaderText = "Порода";
                pigDataGrid.Columns[2].HeaderText = "Стать";
                pigDataGrid.Columns[3].HeaderText = "Дата народження";
                pigDataGrid.Columns[4].HeaderText = "Вага";
                pigDataGrid.Columns[5].HeaderText = "Кількість їжі";
                pigDataGrid.Columns[6].HeaderText = "Дата вагітності";
                pigDataGrid.Columns[7].HeaderText = "Номер хвороби";
                pigDataGrid.Columns[8].HeaderText = "Номер раціону";

                pigDataGrid.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                pigDataGrid.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";


            }
            catch (SqlException ex)
            {
                MessageBox.Show("При завантаженні даних у таблицю виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                db.CloseConnection();
            }
        }

        private void GetIdToDropDown()
        {
            ID.Clear();

            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM pig";

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

                foreach (string id in ID)
                {
                    PigDelDropDown.AddItem(id);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка\nНеможливо витягнути ID в DropDownMenu", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що бажаєте видалити цю інформацію?", "Видалення раціону",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (PigDelDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали жодного елементу для видалення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"DELETE FROM pigration 
                                        WHERE idpig = @id;
                                        DELETE FROM pig 
                                        WHERE id = @id;";


                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", ID[PigDelDropDown.selectedIndex]);

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
                        PigDelDropDown.Clear();
                        GetIdToDropDown();
                    }
                }
            }
        }
    }
}
