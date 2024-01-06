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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roduna_Mekh_Project.PigWindows
{
    public partial class PigCostFlowWindow : Form
    {
        DataBase db = new DataBase();
        public PigCostFlowWindow()
        {
            InitializeComponent();
            FillStartInfo();
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();


        private void FillStartInfo()
        {
            try
            {
                db.OpenConnection();
                string query = @"
                                 SELECT 
                                     pig.*, 
                                     pigration.idration, 
                                     ration.price,
                                     COUNT(*) OVER () AS pig_count,
                                     SUM(pig.weight) OVER () AS total_weight,
                                     SUM(pig.average_food) OVER () AS total_average_food,
                                     medicine.price AS medicine_price
                                 FROM 
                                     pig
                                 JOIN 
                                     pigration ON pig.id = pigration.idpig
                                 JOIN 
                                     ration ON pigration.idration = ration.id
                                 LEFT JOIN 
                                     disease ON pig.diseaseid = disease.id
                                 LEFT JOIN 
                                     medicine ON disease.medicineid = medicine.id;";


                using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double totalWeight = Convert.ToDouble(reader["total_weight"]);
                            double totalFood = Convert.ToDouble(reader["total_average_food"]);
                            double rationPrice = Convert.ToDouble(reader["price"]);
                            double medicinePrice = reader["medicine_price"] == DBNull.Value ? 0 : Convert.ToDouble(reader["medicine_price"]);
                            int pigCount = Convert.ToInt32(reader["pig_count"]);

                            double averageIncome = (totalWeight * 7.02) * 38.18;
                            double averageExpenses = ((totalFood * rationPrice) + medicinePrice) * 38.18;


                            labelPigCount.Text = $"{pigCount}";
                            labelAverageIncome.Text = $"{averageIncome}";
                            labelAverageWeight.Text = $"{totalWeight}";
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

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            FillStartInfo();
            labelAverageWeight.Text = (Convert.ToDouble(labelAverageWeight.Text) * trackBar2.Value).ToString();
            labelAverageIncome.Text = (Convert.ToDouble(labelAverageIncome.Text) * trackBar2.Value).ToString();
            labelAverageExpenses.Text = (Convert.ToDouble(labelAverageExpenses.Text) * trackBar2.Value).ToString();
        }
    }
}
