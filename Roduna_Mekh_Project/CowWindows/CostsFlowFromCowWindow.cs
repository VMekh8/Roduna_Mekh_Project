using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.CowWindows
{
    public partial class CostsFlowFromCowWindow : Form
    {
        DataBase db = new DataBase();
        MainWindow mainWindow;
        public CostsFlowFromCowWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillStartInfo();


            this.mainWindow = mainWindow;
        }

        private void FillStartInfo()
        {

            try
            {
                db.OpenConnection();
                string query = @"
                                 SELECT 
                                     cow.*, 
                                     cowration.idration, 
                                     ration.price,
                                     COUNT(*) OVER () AS cow_count,
                                     SUM(cow.weight) OVER () AS total_weight,
                                     SUM(cow.average_food) OVER () AS total_average_food,
                                     SUM(cow.milkcount) OVER () AS total_milk_average,
                                     medicine.price AS medicine_price
                                 FROM 
                                     cow
                                 JOIN 
                                     cowration ON cow.id = cowration.idcow
                                 JOIN 
                                     ration ON cowration.idration = ration.id
                                 LEFT JOIN 
                                     disease ON cow.diseaseid = disease.id
                                 LEFT JOIN 
                                     medicine ON disease.medicineid = medicine.id;";


                using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double totalWeight = Convert.ToDouble(reader["total_weight"]);
                            double totalMilk = Convert.ToDouble(reader["total_milk_average"]);
                            double totalFood = Convert.ToDouble(reader["total_average_food"]);
                            double rationPrice = Convert.ToDouble(reader["price"]);
                            double medicinePrice = reader["medicine_price"] == DBNull.Value ? 0 : Convert.ToDouble(reader["medicine_price"]);
                            int cowCount = Convert.ToInt32(reader["cow_count"]);

                            double averageIncome = ((totalWeight * 7.02) + (totalMilk * 0.67)) * 38.18; 
                            double averageExpenses = ((totalFood * rationPrice) + medicinePrice) * 38.18;


                            labelCowCount.Text = $"{cowCount}";
                            labelAverageWeight.Text = $"{totalWeight}";
                            labelAverageIncome.Text = $"{averageIncome}";
                            labelAverageExpenses.Text = $"{averageExpenses}";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("При зчитуванні інформації з бази даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

       

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new CowForm(mainWindow));
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            FillStartInfo();
            labelAverageWeight.Text = (Convert.ToDouble(labelAverageWeight.Text) * trackBar2.Value).ToString();
            labelAverageIncome.Text = (Convert.ToDouble(labelAverageIncome.Text) * trackBar2.Value).ToString();
            labelAverageExpenses.Text = (Convert.ToDouble(labelAverageExpenses.Text) * trackBar2.Value).ToString();
        }
    }
}
