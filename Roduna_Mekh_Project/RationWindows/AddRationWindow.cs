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

namespace Roduna_Mekh_Project.RationWindows
{
    public partial class AddRationWindow : Form
    {
        DataBase db = new DataBase();

        MainWindow mainWindow;
        public AddRationWindow(MainWindow mainWindow)
        {
            InitializeComponent();


            this.mainWindow = mainWindow;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете додати саме цю інформацію?", "Додавання раціону",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (DescriptionRationTextBox.Text == "" || PriceRationTextBox.Text == "" || int.Parse(PriceRationTextBox.Text) < 0)
                {
                    MessageBox.Show("Поля не можуть бути порожніми або від'ємними", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "INSERT INTO ration (type_feed, price) VALUES (@type, @price)";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@type", DescriptionRationTextBox.Text);
                            cmd.Parameters.AddWithValue("@price", int.Parse(PriceRationTextBox.Text));

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Дані успішно додані до таблиці ration");
                        MessageBox.Show("Дані успішно додані", "Успіх", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"При додаванні даних виникла помилка: {ex.Message}");
                        MessageBox.Show("При додаванні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
