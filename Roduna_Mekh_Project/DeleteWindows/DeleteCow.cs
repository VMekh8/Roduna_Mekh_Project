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
    public partial class DeleteCow : Form
    {
        DataBase db = new DataBase();
        List<string> cowId = new List<string>();
        public DeleteCow()
        {
            InitializeComponent();
            FillDataGrid();
            GetIdToDropDown();
        }

        private void GetIdToDropDown()
        {
            cowId.Clear();

            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM cow";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cowId.Add(reader["id"].ToString());
                        }
                    }

                }

                foreach (string id in cowId)
                {
                    CowDelDropDown.AddItem(id);
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

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = @"SELECT id, breed, gender, date_Birth, weight, average_food, date_pregnancy, milkcount, diseaseid, cowration.idration 
                                    FROM cow 
                                    JOIN cowration ON cow.id = cowration.idcow";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cowDataGrid.DataSource = table;
                }


                cowDataGrid.Columns[0].HeaderText = "ID";
                cowDataGrid.Columns[1].HeaderText = "Порода";
                cowDataGrid.Columns[2].HeaderText = "Стать";
                cowDataGrid.Columns[3].HeaderText = "Дата народження";
                cowDataGrid.Columns[4].HeaderText = "Вага";
                cowDataGrid.Columns[5].HeaderText = "Кількість їжі";
                cowDataGrid.Columns[6].HeaderText = "Дата вагітності";
                cowDataGrid.Columns[7].HeaderText = "К-сть молока";
                cowDataGrid.Columns[8].HeaderText = "Номер хвороби";
                cowDataGrid.Columns[9].HeaderText = "Номер раціону";

                cowDataGrid.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                cowDataGrid.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

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

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що бажаєте видалити цю інформацію?", "Видалення раціону",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (CowDelDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали жодного елементу для видалення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"DELETE FROM cowration 
                                        WHERE idcow = @id;
                                        DELETE FROM cow 
                                        WHERE id = @id;";


                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", cowId[CowDelDropDown.selectedIndex]);

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
                        CowDelDropDown.Clear();
                        GetIdToDropDown();
                    }
                }
            }
        }
    }
}