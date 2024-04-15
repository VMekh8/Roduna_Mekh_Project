using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.GrainWindows
{
    public partial class GrainCostFlowWindow : Form
    {
        public GrainCostFlowWindow()
        {
            InitializeComponent();
            GetDataFromDB();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Доходи",
                    Values = new ChartValues<double> {double.Parse(label14.Text)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Витрати",
                    Values = new ChartValues<double> {double.Parse(label16.Text)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void SetLabels(SqlDataReader reader)
        {
            while (reader.Read())
            {
                label2.Text = reader["total_fields"].ToString();
                label1.Text = reader["total_area"].ToString();
                label10.Text = reader["expected_yield"].ToString();
                label3.Text = reader["total_chemicals"].ToString();
                label4.Text = reader["fuel_total"].ToString();
                label9.Text = reader["total_chemical_cost"].ToString();
                label16.Text = reader["total_extendes"].ToString();
                label14.Text = reader["total_incomes"].ToString();
            }
        }

        private void GetDataFromDB()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();

                string query = @"SELECT 
                                (SELECT COUNT(*) FROM Grain) AS total_fields,
                                (SELECT SUM(area) FROM Grain) AS total_area,
                                (SELECT SUM(area * productivity) FROM Grain) AS expected_yield,
                                (SELECT SUM(fuel_consumption)*50 FROM Grain) as fuel_total,
                                (SELECT COUNT(*) FROM chemists) AS total_chemicals,
                                (SELECT SUM(chemists.price * grainchemist.consumption) 
                                 FROM grainchemist
                                 JOIN chemists ON grainchemist.idChemist = chemists.id) AS total_chemical_cost,
                                (SELECT SUM(chemists.price * grainchemist.consumption) + SUM(fuel_consumption)*50
                                 FROM grainchemist
                                 JOIN chemists ON grainchemist.idChemist = chemists.id
                                 CROSS JOIN Grain) AS total_extendes,
                                (SELECT SUM(productivity * 1000 * price_per_kg) FROM Grain) as total_incomes;";


                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        SetLabels(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
