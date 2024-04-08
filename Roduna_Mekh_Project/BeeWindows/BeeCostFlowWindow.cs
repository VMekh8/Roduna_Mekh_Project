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

namespace Roduna_Mekh_Project.BeeWindows
{
    public partial class BeeCostFlowWindow : Form
    {
        public BeeCostFlowWindow()
        {
            InitializeComponent();

            GetInfoFromDB();
        }

        

        private void GetInfoFromDB()
        {
            DataBase db = new DataBase();

            try
            {
                db.OpenConnection();

                string query = @"SELECT bee.*,
                                 COUNT (*) OVER() as bee_count,
                                 SUM(honey_average) OVER () as honey_sum,
                                 SUM(numbers_of_family) OVER () as family_sum,
                                 SUM(repairextendes) OVER () as repair_cost,
                                 SUM(medicineextendes) OVER () as medicine_cost
                                 FROM bee";

                using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int beeCount = Convert.ToInt32(reader["bee_count"]);
                            double honeyAvg = Convert.ToDouble(reader["honey_sum"]);
                            int familyNumbers = Convert.ToInt32(reader["family_sum"]);
                            double repairCost = reader["repair_cost"] == DBNull.Value ? 0 : Convert.ToDouble(reader["repair_cost"]);
                            double medicineCost = reader["medicine_cost"] == DBNull.Value ? 0 : Convert.ToDouble(reader["medicine_cost"]);

                            FillInfo(beeCount, honeyAvg, familyNumbers, repairCost, medicineCost);
                        }

                    }
                }

            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                MessageBox.Show("Помилка завантаження даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillInfo(int beeCount, double honeyAvg, int familyNumbers, double repairCost, double medicineCost)
        {
            label2.Text = beeCount.ToString();
            label1.Text = honeyAvg.ToString();
            label10.Text = familyNumbers.ToString();

            label4.Text = (honeyAvg * 150).ToString();
            label3.Text = (repairCost + medicineCost).ToString();
        }
        private void CostFlowTrackBar_ValueChanged(object sender, EventArgs e)
        {
            GetInfoFromDB();
            label1.Text = (int.Parse(label1.Text) * CostFlowTrackBar.Value).ToString();
            label10.Text = (int.Parse(label10.Text) * CostFlowTrackBar.Value / 2).ToString();

            label4.Text = (double.Parse(label4.Text) *  CostFlowTrackBar.Value).ToString();
            label3.Text = (double.Parse(label3.Text) * CostFlowTrackBar.Value).ToString();
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

    }
}
