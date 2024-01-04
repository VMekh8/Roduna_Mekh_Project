﻿using Bunifu.Framework.UI;
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

namespace Roduna_Mekh_Project.InformationWindows
{
    public partial class AddPig : Form
    {
        DataBase db = new DataBase();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        List<string> rationId = new List<string>();
        List<string> diseaseId = new List<string>();

        public AddPig()
        {
            InitializeComponent();
            Create_Button();
            FillDiseaseDropDown();
            FillRationDropDown();

            WeightTextBox.Enter += TextBox_Enter;
            AverageFood.Enter += TextBox_Enter;
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

        private void GenderTextBox_onItemSelected(object sender, EventArgs e)
        {
            if (GenderTextBox.selectedValue == "Кабан")
            {
                PregnancyDatePicker.Enabled = false;
            }
            else
            {
                PregnancyDatePicker.Enabled = true;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked) PigDiseasePicker.Enabled = true;
            else PigDiseasePicker.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BreedTextBox.Text) || string.IsNullOrEmpty(AverageFood.Text) || string.IsNullOrEmpty(WeightTextBox.Text))
            {
                MessageBox.Show("Поля не можуть бути порожніми\nСпробуйте знову", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(WeightTextBox.Text) < 0 || Convert.ToInt32(AverageFood.Text) < 0)
            {
                MessageBox.Show("Значення при не можуть бути від'ємними\nБудь ласка, заповність поле коректно", "Віправлення даних неможливе",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = 0;
                try
                {
                    DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити саме цю інформацію?", "Перевірка інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        db.OpenConnection();
                        string query = @"INSERT INTO pig (breed, gender, date_Birth, weight, average_food, date_pregnancy, diseaseid) " +
                                        "VALUES (@BreedTextBox, @GenderTextBox, @DateBirth, @WeightTextBox, @AverageFood, @DatePregnancy, @DiseaseId);" +
                                        "SELECT SCOPE_IDENTITY()";

                        string query1 = "INSERT INTO pigration (idpig, idration) " +
                                        "VALUES (@id, @RationId);";


                        using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("@BreedTextBox", BreedTextBox.Text);
                            cmd.Parameters.AddWithValue("@GenderTextBox", GenderTextBox.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@DateBirth", DateTime.Parse(DateBirth.Value.ToString()));
                            cmd.Parameters.AddWithValue("@WeightTextBox", int.Parse(WeightTextBox.Text));
                            cmd.Parameters.AddWithValue("@AverageFood", int.Parse(AverageFood.Text));
                            cmd.Parameters.AddWithValue("@DatePregnancy", PregnancyDatePicker.Enabled ? DateTime.Parse(PregnancyDatePicker.Value.ToString()) : (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@DiseaseId", bunifuCheckbox2.Checked ? diseaseId[PigDiseasePicker.selectedIndex] : (object)DBNull.Value);

                            object result = cmd.ExecuteScalar();
                            id = Convert.ToInt32(result);
                        }


                        using (SqlCommand cmd1 = new SqlCommand(query1, db.getConnection()))
                        {
                            cmd1.Parameters.AddWithValue("@id", id);
                            cmd1.Parameters.AddWithValue("@RationId", rationId[RationDropDown.selectedIndex]);

                            cmd1.ExecuteNonQuery();
                        }


                        Console.WriteLine("Відправлення даних пройшло успішно");
                        MessageBox.Show("Дані успішно додані до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Під час додавання інформацію про худобу виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    db.CloseConnection();
                }


            }

        }


    }
}

