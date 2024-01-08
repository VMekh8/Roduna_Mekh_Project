using Bunifu.Framework.UI;
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

namespace Roduna_Mekh_Project.EditingWindows
{
    public partial class EditBee : Form
    {
        List<string> ID = new List<string>();
        DataBase db = new DataBase();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditBee()
        {
            InitializeComponent();
            FillDataGrid();
            FillIdList();

            Create_Button();

            NumberOfFamily.Enter += TextBox_Enter;
            HoneyAverage.Enter += TextBox_Enter;
            
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM bee";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    beeDataGrid.DataSource = dataTable;

                    beeDataGrid.Columns[0].HeaderText = "ID"; 
                    beeDataGrid.Columns[1].HeaderText = "К-сть сімей"; 
                    beeDataGrid.Columns[2].HeaderText = "Стан сімей"; 
                    beeDataGrid.Columns[3].HeaderText = "К-сть меду"; 
                    beeDataGrid.Columns[4].HeaderText = "Дата встановлення"; 
                    beeDataGrid.Columns[5].HeaderText = "Дата ост. збору меду"; 
                    beeDataGrid.Columns[6].HeaderText = "Стан вулика (%)"; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні таблиці виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillIdList()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM bee";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID.Add(reader["id"].ToString());
                        }
                    }
                }

                foreach(var i in ID)
                {
                    ElementID.AddItem(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumberOfFamily.Text) || string.IsNullOrEmpty(HoneyAverage.Text))
            {
                MessageBox.Show("Поля не можуть бути порожніми\nСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(NumberOfFamily.Text) < 0 || int.Parse(HoneyAverage.Text) < 0)
            {
                MessageBox.Show("Поля не можуть бути від'ємними\nСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataBase db = new DataBase();

                DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        db.OpenConnection();
                        string query = @"UPDATE bee SET numbers_of_family = @numbers_of_family, power_of_family = @power_of_family, honey_average = @honey_average,
                                install_date = @install_date, data_honey_collect = @data_honey_collect, hive_state = @hive_state WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(ElementID.selectedValue));
                            cmd.Parameters.AddWithValue("@numbers_of_family", int.Parse(NumberOfFamily.Text));
                            cmd.Parameters.AddWithValue("@power_of_family", PowerOfFamily.selectedValue);
                            cmd.Parameters.AddWithValue("@honey_average", int.Parse(HoneyAverage.Text));
                            cmd.Parameters.AddWithValue("@install_date", Convert.ToDateTime(InstallDate.Value));
                            cmd.Parameters.AddWithValue("@data_honey_collect", Convert.ToDateTime(DateCollectHoney.Value));
                            cmd.Parameters.AddWithValue("@hive_state", int.Parse(HiveState.selectedValue));

                            cmd.ExecuteNonQuery();

                        }
                        MessageBox.Show("Відправлення даних відбулося успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGrid();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("При відправленні даних відбулася помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }


        private void Create_Button()
        {
            Incrementbutton = new Button();
            Incrementbutton.Text = "+";
            Incrementbutton.Click += IncrementButton_Click;

            Decrementbutton = new Button();
            Decrementbutton.Text = "—";
            Decrementbutton.Click += DecrementButton_Click;

            Incrementbutton.Visible = false;
            Decrementbutton.Visible = false;



            Incrementbutton.Size = new Size(25, 20);
            Decrementbutton.Size = new Size(25, 20);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = (BunifuMaterialTextbox)sender;

            int x = activeTextBox.Location.X + activeTextBox.Width;
            int y = activeTextBox.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

            Incrementbutton.Visible = true;
            Decrementbutton.Visible = true;
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            currentValue++;
            activeTextBox.Text = currentValue.ToString();
        }

        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM bee WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(ElementID.selectedValue));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            NumberOfFamily.Text = reader["numbers_of_family"].ToString();
                            HoneyAverage.Text = reader["honey_average"].ToString();
                            InstallDate.Value = Convert.ToDateTime(reader["install_date"]);
                            DateCollectHoney.Value = Convert.ToDateTime(reader["install_date"]);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даних у поля виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                currentValue--;
                activeTextBox.Text = currentValue.ToString();
            }
        }

    }
}
