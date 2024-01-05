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
    public partial class EditPig : Form
    {
        DataBase db = new DataBase();
        List<string> ID = new List<string>();
        List<string> rationId = new List<string>();
        List<string> diseaseId = new List<string>();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditPig()
        {
            InitializeComponent();
            FillDiseaseDropDown();
            FillRationDropDown();
            GetIdToDropDown();

            Create_Button();

            WeightTextBox.Enter += TextBox_Enter;
            AverageFood.Enter += TextBox_Enter;
        }


        private void GetIdToDropDown()
        {
            ID.Clear();

            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM pig";

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

                foreach (string id in ID)
                {
                    ElementID.AddItem(id);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("При завантаженні даних виникла помилка\nНеможливо витягнути ID в DropDownMenu", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FillRationDropDown()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM ration";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            rationId.Add(rdr["id"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("При заповненні випадаючого спику виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними списку виникла помилка", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach (var i in rationId)
            {
                RationDropDown.AddItem(i);
            }
        }

        private void FillDiseaseDropDown()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM disease";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            diseaseId.Add(rdr["id"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("При заповненні випадаючого спику виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні даними списку виникла помилка", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach (var i in diseaseId)
            {
                PigDiseasePicker.AddItem(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ElementID.selectedIndex == -1)
            {
                MessageBox.Show("Ви не вибрали ідентифікатор тварини\nЗаповніть, будь ласка, це поле", "Помилка відправлення даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (RationDropDown.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали раціон для тварини\nЗаповніть, будь ласка, це поле", "Помилка відправлення даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bunifuCheckbox2.Checked && PigDiseasePicker.selectedIndex == -1)
                {
                    MessageBox.Show("Ви не вибрали хворобу для тварини\nЗаповніть, будь ласка, це поле", "Помилка відправлення даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            db.OpenConnection();
                            string query = @"UPDATE pig SET breed = @breed, gender = @gender, date_birth = @datebirth, weight = @weight, average_food = @food, date_pregnancy = @datepreg, 
                                        diseaseid = @diseaseid WHERE id = @id";

                            string query1 = @"UPDATE pigration SET idration = @idration WHERE idpig = @idpig";

                            using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                            {
                                cmd.Parameters.AddWithValue("@id", ElementID.selectedValue.ToString());
                                cmd.Parameters.AddWithValue("@breed", BreedTextBox.Text);
                                cmd.Parameters.AddWithValue("@gender", GenderTextBox.selectedValue.ToString());
                                cmd.Parameters.AddWithValue("@datebirth", DateTime.Parse(DateBirthPicker.Value.ToString()));
                                cmd.Parameters.AddWithValue("@weight", int.Parse(WeightTextBox.Text));
                                cmd.Parameters.AddWithValue("@food", int.Parse(AverageFood.Text));
                                cmd.Parameters.AddWithValue("@datepreg", PregnancyDatePicker.Enabled ? DateTime.Parse(PregnancyDatePicker.Value.ToString()) : (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@diseaseid", bunifuCheckbox2.Checked ? diseaseId[PigDiseasePicker.selectedIndex] : (object)DBNull.Value);

                                cmd.ExecuteNonQuery();
                            }


                            using (SqlCommand cmd1 = new SqlCommand(query1, db.getConnection()))
                            {
                                cmd1.Parameters.AddWithValue("@idpig", ElementID.selectedValue.ToString());
                                cmd1.Parameters.AddWithValue("@idration", RationDropDown.selectedValue.ToString());

                                cmd1.ExecuteNonQuery();
                            }
                        }
                        Console.WriteLine("Відправлення даних пройшло успішно");
                        MessageBox.Show("Дані успішно додані до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("При відправленні даних на сервер виникла помилка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            currentValue += 10;
            activeTextBox.Text = currentValue.ToString();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                currentValue -= 10;
                activeTextBox.Text = currentValue.ToString();
            }
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

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked)
                PigDiseasePicker.Enabled = true;
            else
                PigDiseasePicker.Enabled = false;
        }

        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM pig WHERE Id = @ID";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", ElementID.selectedValue);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["gender"].ToString().Equals("Кабан"))
                            {
                                GenderTextBox.selectedIndex = 0;
                                PregnancyDatePicker.Enabled = false;
                            }
                            else
                            {
                                GenderTextBox.selectedIndex = 1;
                                PregnancyDatePicker.Enabled = true;

                            }
                            DateBirthPicker.Value = Convert.ToDateTime(reader["date_birth"]);
                            BreedTextBox.Text = reader["breed"].ToString();
                            WeightTextBox.Text = reader["weight"].ToString();
                            AverageFood.Text = reader["average_food"].ToString();

                        }

                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("При заповненні полів даними виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При заповненні полів даними виникла помилка", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
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



            Incrementbutton.Size = new Size(25, 23);
            Decrementbutton.Size = new Size(25, 22);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);

            int x = WeightTextBox.Location.X + WeightTextBox.Width;
            int y = WeightTextBox.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

        }
    }
}
