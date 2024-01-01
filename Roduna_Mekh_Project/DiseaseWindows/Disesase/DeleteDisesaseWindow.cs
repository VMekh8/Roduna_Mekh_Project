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

namespace Roduna_Mekh_Project.DiseaseWindows.Disesase
{
    public partial class DeleteDisesaseWindow : Form
    {
        DataBase db = new DataBase();
        List<string> diseaseId = new List<string>();

        MainWindow mainWindow;
        public DeleteDisesaseWindow(MainWindow mainWindow)
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
                string query = "SELECT id FROM disease";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            diseaseId.Add(rdr["id"].ToString());
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

            foreach (var i in diseaseId)
            {
                DiseaseDelDropDown.AddItem(i);
            }
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM disease";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DiseaseDataGrid.DataSource = table;
                    }
                }

                DiseaseDataGrid.Columns[0].HeaderText = "Id";
                DiseaseDataGrid.Columns[1].HeaderText = "Назва захворювання";
                DiseaseDataGrid.Columns[2].HeaderText = "Тип захворювання";
                DiseaseDataGrid.Columns[3].HeaderText = "Симтоми";
                DiseaseDataGrid.Columns[4].HeaderText = "Опис";
                DiseaseDataGrid.Columns[5].HeaderText = "Номер медикаменту";


            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці disease виникла помилка");
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
                if (DiseaseDelDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали жодного елементу для видалення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "DELETE FROM disease WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", diseaseId[DiseaseDelDropDown.selectedIndex]);

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
                        DiseaseDelDropDown.Clear();
                    }
                }
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => mainWindow.PanelForm(new DiseaseMainWindow(mainWindow));
    }
}
