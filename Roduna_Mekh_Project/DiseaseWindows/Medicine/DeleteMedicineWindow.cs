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

namespace Roduna_Mekh_Project.DiseaseWindows.Medicine
{
    public partial class DeleteMedicineWindow : Form
    {
        DataBase db = new DataBase();
        List<string> medicineId = new List<string>();
        MainWindow mainWindow;
        public DeleteMedicineWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();
            FillDropDown();


            this.mainWindow = mainWindow;   
        }

        private void FillDropDown()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM medicine";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            medicineId.Add(rdr["id"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("При заповненні випадаючого спику виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними списку виникла помилка", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach (var i in medicineId)
            {
                MedicineDelDropDown.AddItem(i);
            }
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM medicine";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection())) 
                { 
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    { 
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        MedicineDataGrid.DataSource = table;
                    }
                }

                MedicineDataGrid.Columns[0].HeaderText = "Id";
                MedicineDataGrid.Columns[1].HeaderText = "Назва препарату";
                MedicineDataGrid.Columns[2].HeaderText = "Тип препарату";
                MedicineDataGrid.Columns[3].HeaderText = "Для якого захворювання";
                MedicineDataGrid.Columns[4].HeaderText = "Ціна препарату";


            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці medicine виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При вибірці даних виникла помилка\n\tСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що бажаєте видалити цю інформацію?", "Видалення медикаментів",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (MedicineDelDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали жодного елементу для видалення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "DELETE FROM medicine WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", medicineId[MedicineDelDropDown.selectedIndex]);

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
                        MedicineDelDropDown.Clear();
                    }
                }
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
