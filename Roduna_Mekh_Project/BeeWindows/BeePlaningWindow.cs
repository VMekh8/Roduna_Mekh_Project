using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.BeeWindows
{
    public partial class BeePlaningWindow : Form
    {
        public BeePlaningWindow()
        {
            InitializeComponent();
            FillInfoInLabel();
        }

        private enum Month
        {
            Січень = 1,
            Лютий, 
            Березень, 
            Квітень, 
            Травень,
            Червень, 
            Липень, 
            Серпень, 
            Вересень, 
            Жовтень,
            Листопад, 
            Грудень
        }

        private Month? nextMonth = null;
        private Month currentMoth = (Month)DateTime.Now.Month;
        private Dictionary<Month, string> Schedule = new Dictionary<Month, string>()
        {
            {Month.Травень, "Початок сезону збору меду. \nЦе час цвітіння рапсу, конюшини та малини."},
            {Month.Червень, "Продовження збору меду. \nЦе час цвітіння липи та соняшнику."},
            {Month.Липень,  "Пік сезону збору меду. \nЦе час цвітіння лаванди, шавлії та гречки."},
            {Month.Серпень, "Кінець сезону збору меду. \nЦе час, коли бджоли збирають мед з різнотрав'я."}
        };

        private void FindNearestMonth()
        {
            for (Month m = currentMoth; m < Month.Грудень; m++)
            {
                if (Schedule.ContainsKey(m))
                {
                    nextMonth = m;
                    break;
                }
            }
        }

        private void GetInfoAboutBee(out int id, out DateTime dateCollect)
        {
            DataBase db = new DataBase();

            id = 0;
            dateCollect = DateTime.Now;

            try
            {
                db.OpenConnection();
                string query = @"SELECT TOP 1 id, data_honey_collect
                                 FROM bee 
                                 ORDER BY data_honey_collect ASC";


                using (SqlCommand command = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["id"]);
                            dateCollect = Convert.ToDateTime(reader["data_honey_collect"]);
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

        private void FillInfoInLabel()
        {
            FindNearestMonth();
            switch (nextMonth)
            {

                case Month.Травень:
                    pictureBox1.Image = Properties.Resources.CloverHoney;
                    break;

                case Month.Червень:
                    pictureBox1.Image = Properties.Resources.SunFlowerHoney;
                    break;

                case Month.Липень:
                    pictureBox1.Image = Properties.Resources.BuckWheatHoney;
                    break;

                case Month.Серпень:
                    pictureBox1.Image = Properties.Resources.LastHoney;
                    break;
            }

            label10.Text = Schedule[nextMonth.Value];

            int id; DateTime dateTime;
            GetInfoAboutBee(out id, out dateTime);
            label6.Text = id.ToString();
            label7.Text = dateTime.ToShortDateString();

            label8.Text = ((Month)DateTime.Now.Month).ToString();
            label9.Text = nextMonth.ToString();
        }


        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
