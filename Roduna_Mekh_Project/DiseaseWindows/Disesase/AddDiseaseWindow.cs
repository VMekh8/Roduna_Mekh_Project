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
    public partial class AddDiseaseWindow : Form
    {
        DataBase db = new DataBase();
        List<string> medicineId = new List<string> ();

        MainWindow mainWindow;
        public AddDiseaseWindow(MainWindow mainWindow)
        {
            InitializeComponent();
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
                MedicineID.AddItem(i);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете додати цю інформацію?", "Додавання інформації",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (NameDisease.Text == "" || TypeDisease.Text == "" ||
                    Sympthoms.Text == "" || Description.Text == "" || MedicineID.selectedIndex == -1)
                {
                    MessageBox.Show("Поля не можуть бути порожніми", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"INSERT INTO disease (name_disease, type_disease, symptoms, descriprion, medicineid) 
                                        VALUES (@name_disease, @type_disease, @symptoms, @descriprion, @medicineid)";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@name_disease", NameDisease.Text);
                            cmd.Parameters.AddWithValue("@type_disease", TypeDisease.Text);
                            cmd.Parameters.AddWithValue("@symptoms", Sympthoms.Text);
                            cmd.Parameters.AddWithValue("@descriprion", Description.Text);
                            cmd.Parameters.AddWithValue("@medicineid", medicineId[MedicineID.selectedIndex]);

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Відправлення даних в таблицю disease успішне");
                        MessageBox.Show("Відправлення даних відбулося успішно", "Успіх",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("При додаванні інформації в таблиці disease виникла помилка");
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("При додаванні інформації виникла помилка", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

    }
}
