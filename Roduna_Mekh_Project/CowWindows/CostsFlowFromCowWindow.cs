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
                string query = @"SELECT cow.*, cowration.idration, ration.price
                                    FROM cow
                                    JOIN cowration ON cow.id = cowration.idcow
                                    JOIN ration ON cowration.idration = ration.id;";


                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    label7.Text = table.Rows.Count.ToString();
                    int averageweight = 0;
                    double averageIncome = 0, averageExtendes = 0;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        averageweight += Convert.ToInt32(table.Rows[i]["weight"]);
                        if (!table.Rows[i]["milkcount"].Equals(DBNull.Value))
                        {
                            averageIncome += Convert.ToDouble(table.Rows[i]["milkcount"]);
                        }
                        if (!table.Rows[i]["price"].Equals (DBNull.Value))
                        {
                            averageExtendes += Convert.ToDouble(table.Rows[i]["average_food"]) * Convert.ToDouble(table.Rows[i]["price"]); 
                        }

                    }
                    averageIncome *= 4.5;
                    
                    label6.Text = averageweight.ToString();
                    label5.Text = (averageIncome + averageweight * 85).ToString();
                    label8.Text = averageExtendes.ToString();
                    
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuTrackbar1.Value == 0)
            {
                FillStartInfo();
            }
            else 
            {
                FillStartInfo();
                label6.Text = (double.Parse(label6.Text) * bunifuTrackbar1.Value).ToString();
                label5.Text = (double.Parse(label5.Text) * bunifuTrackbar1.Value).ToString();
                label8.Text = (double.Parse(label8.Text) * bunifuTrackbar1.Value).ToString();
            }
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new CowForm(mainWindow));
        }
    }
}
