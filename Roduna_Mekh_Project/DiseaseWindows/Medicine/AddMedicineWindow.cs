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
    public partial class AddMedicineWindow : Form
    {
        MainWindow mainWindow;
        DataBase db = new DataBase();
        public AddMedicineWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете додати цю інформацію?", "Додавання інформації",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (NameMedicine.Text == "" || TypeMedicine.Text == "" || 
                    ForWhatDisease.Text == "" || PriceMedicine.Text == "")
                {
                    MessageBox.Show("Поля не можуть бути порожніми", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(PriceMedicine.Text) < 0)
                {
                    MessageBox.Show("Поля не можуть бути від'ємними", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"INSERT INTO medicine (name_medicine, type_medicine, for_type_disease, price) 
                                        VALUES (@name, @type, @typedisease, @price)";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@name", NameMedicine.Text);
                            cmd.Parameters.AddWithValue("@type", TypeMedicine.Text);
                            cmd.Parameters.AddWithValue("@typedisease", ForWhatDisease.Text);
                            cmd.Parameters.AddWithValue("@price", int.Parse(PriceMedicine.Text));

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Відправлення даних в таблицю medicine успішне");
                        MessageBox.Show("Відправлення даних відбулося успішно", "Успіх",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("При додаванні інформації в таблиці medicine виникла помилка");
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
