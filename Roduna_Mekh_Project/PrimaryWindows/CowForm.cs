using MySql.Data.MySqlClient;
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

namespace Roduna_Mekh_Project
{
    public partial class CowForm : Form
    {
        
       
        MainWindow mainWindow;
        public CowForm(MainWindow mainWindow)
        {
            InitializeComponent();
            
            this.mainWindow = mainWindow;

        }


       

       
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;
            int targetHeight = 0;

            if (timer1.Tag.ToString() == "Expand")
            {
                targetHeight = panel2.MaximumSize.Height;
            }
            else if (timer1.Tag.ToString() == "Collapse")
            {
                targetHeight = panel2.MinimumSize.Height;
            }

            if (panel2.Height != targetHeight)
            {
                int step = (targetHeight - panel2.Height > 0) ? animationSpeed : -animationSpeed;
                panel2.Height += step;

                if ((step > 0 && panel2.Height > targetHeight) || (step < 0 && panel2.Height < targetHeight))
                {
                    panel2.Height = targetHeight;
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            //{
            //    MessageBox.Show("Ви не вибрали ніяких параметрів для пошуку.\nВиберіть один з параметрів біля рядка пошуку", "Помилка",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    DataBase db = new DataBase();
            //    if (radioButton1.Checked)
            //    {
            //        db.OpenConnection();
            //        string query = "SELECT id, gender, date_birth, breed, weight, average_food FROM cow WHERE id = @id";
            //        int desiredId = int.Parse(SearchTextBox.Text);
            //        SqlCommand command = new SqlCommand(query, db.getConnection());
            //        command.Parameters.AddWithValue("@id", desiredId);

            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        dataTable.Clear();
            //        cowDataGrid.Rows.Clear();
            //        adapter.Fill(dataTable);
            //        if (dataTable.Rows.Count > 0)
            //        {
            //            for (int i = 0; i < dataTable.Rows.Count; i++)
            //            {


            //                DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_birth"]);
            //                string formattedDate = installDate.ToString("yyyy-MM-dd");


            //                cowDataGrid.Rows.Add(
            //                   dataTable.Rows[i]["id"],
            //                   dataTable.Rows[i]["gender"],
            //                   formattedDate,
            //                   dataTable.Rows[i]["breed"],
            //                   dataTable.Rows[i]["weight"],
            //                   dataTable.Rows[i]["average_food"]
            //               );
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            PrintIntoDataGrid();
            //            SearchTextBox.Clear();
            //        }
            //        db.CloseConnection();
            //    }
            //    if (radioButton2.Checked)
            //    {
            //        db.OpenConnection();
            //        string query = "SELECT id, gender, date_birth, breed, weight, average_food FROM cow WHERE breed = @breed";
            //        string breed = SearchTextBox.Text;
            //        SqlCommand command = new SqlCommand(query, db.getConnection());
            //        command.Parameters.AddWithValue("@breed", breed);

            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        dataTable.Clear();
            //        cowDataGrid.Rows.Clear();
            //        adapter.Fill(dataTable);
            //        if (dataTable.Rows.Count > 0)
            //        {
            //            for (int i = 0; i < dataTable.Rows.Count; i++)
            //            {


            //                DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_birth"]);
            //                string formattedDate = installDate.ToString("yyyy-MM-dd");


            //                cowDataGrid.Rows.Add(
            //                   dataTable.Rows[i]["id"],
            //                   dataTable.Rows[i]["gender"],
            //                   formattedDate,
            //                   dataTable.Rows[i]["breed"],
            //                   dataTable.Rows[i]["weight"],
            //                   dataTable.Rows[i]["average_food"]
            //               );
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            PrintIntoDataGrid();
            //            SearchTextBox.Clear();
            //        }
            //        db.CloseConnection();
            //    }
            //    if (radioButton3.Checked)
            //    {
            //        db.OpenConnection();
            //        string query = "SELECT id, gender, date_birth, breed, weight, average_food FROM cow WHERE gender = @gender";
            //        string gender = SearchTextBox.Text;
            //        SqlCommand command = new SqlCommand(query, db.getConnection());
            //        command.Parameters.AddWithValue("@gender", gender);

            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        dataTable.Clear();
            //        cowDataGrid.Rows.Clear();
            //        adapter.Fill(dataTable);
            //        if (dataTable.Rows.Count > 0)
            //        {
            //            for (int i = 0; i < dataTable.Rows.Count; i++)
            //            {


            //                DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["date_birth"]);
            //                string formattedDate = installDate.ToString("yyyy-MM-dd");


            //                cowDataGrid.Rows.Add(
            //                   dataTable.Rows[i]["id"],
            //                   dataTable.Rows[i]["gender"],
            //                   formattedDate,
            //                   dataTable.Rows[i]["breed"],
            //                   dataTable.Rows[i]["weight"],
            //                   dataTable.Rows[i]["average_food"]
            //               );
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Нічого не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            PrintIntoDataGrid();
            //            SearchTextBox.Clear();
            //        }
            //        db.CloseConnection();
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            cowDataGrid.Rows.Clear();
           
        }

      
    }

        
    
}
