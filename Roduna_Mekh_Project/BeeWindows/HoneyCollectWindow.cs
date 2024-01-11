using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.BeeWindows
{
    public partial class HoneyCollectWindow : Form
    {
        DataBase db = new DataBase();
        public HoneyCollectWindow()
        {
            InitializeComponent();
            FillDataChart();
        }

        private void FillDataChart()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id, honey_average FROM bee";

                List<string> ID = new List<string>();
                ChartValues<int> values = new ChartValues<int>();

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID.Add(reader["id"].ToString());
                            values.Add(Convert.ToInt32(reader["honey_average"]));
                        }


                        cartesianChart1.Series = new SeriesCollection
                        {
                            new LineSeries
                            {
                                Title = "Продуктивність вулика",
                                Values = new ChartValues<int>(values),
                                Stroke = System.Windows.Media.Brushes.Orange,
                                Fill = System.Windows.Media.Brushes.Cornsilk

                            }                            
                        };
                        cartesianChart1.AxisX.Add(new Axis
                        {
                            Title = "Номер вулика",
                            Labels = ID
                        });
                        
                    }
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних у графіку виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();   
            }
        }

      
    }
}
