using Bunifu.Framework.UI;
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

namespace Roduna_Mekh_Project.GrainWindows.ChemistsWindows
{
    public partial class AddChemistWindow : Form
    {
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public AddChemistWindow()
        {
            InitializeComponent();
            Create_Button();

            PriceField.Enter += TextBox_Enter;
        }

        private void SendDataToDB(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (string.IsNullOrEmpty(NameField.Text) || string.IsNullOrEmpty(TypeField.Text)
                || string.IsNullOrEmpty(CultureField.Text) || int.Parse(PriceField.Text) < 0)
            {
                MessageBox.Show("Введені дані місять помилку\n\tСпробуйте знову", "Помикла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult res = MessageBox.Show("Ви впевненні що хочете відправити ці дані?", "Перевірка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No) { return; }

                try
                {
                    db.OpenConnection();

                    string query = @"INSERT INTO chemists (name_chemist, type_chemist, for_type_culture, price) 
                                VALUES (@name_chemist, @type_chemist, @for_type_culture, @price )";

                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@name_chemist", NameField.Text);
                        cmd.Parameters.AddWithValue("@type_chemist", TypeField.Text);
                        cmd.Parameters.AddWithValue("@for_type_culture", CultureField.Text);
                        cmd.Parameters.AddWithValue("@price", int.Parse(PriceField.Text));

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Success");
                    MessageBox.Show("Дані успішно відправленні", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("При відправленні даних виникла помилка!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
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

            Incrementbutton.Location = new Point(x, y);
            Decrementbutton.Location = new Point(x, y + Incrementbutton.Height);

            Incrementbutton.Visible = true;
            Decrementbutton.Visible = true;
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = !string.IsNullOrEmpty(activeTextBox.Text) ? double.Parse(activeTextBox.Text) : 0;
            currentValue += 10;
            activeTextBox.Text = currentValue.ToString();

        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            
            double currentValue = !string.IsNullOrEmpty(activeTextBox.Text) ? double.Parse(activeTextBox.Text) : 0;
            if (currentValue > 0)
            {
                currentValue -= 10;
                activeTextBox.Text = currentValue.ToString();
            }
        }

    }
}
