using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DataTable dataTable = new DataTable();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditBee()
        {
            InitializeComponent();
            RefreshData();

            Create_Button();

            NumberOfFamily.Enter += TextBox_Enter;
            HoneyAverage.Enter += TextBox_Enter;
            HoneyPrice.Enter += TextBox_Enter;
            
        }

        private void RefreshData()
        {
            DataBase db = new DataBase();
            db.OpenConnection();

            string query = "SELECT id, numbers_of_family, power_of_family, honey_average, hive_state, install_date, honey_price FROM bee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());

            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    ID.Add(dataTable.Rows[i]["id"].ToString());
                    DateTime installDate = Convert.ToDateTime(dataTable.Rows[i]["install_date"]);
                    string formattedDate = installDate.ToString("yyyy-MM-dd");


                    beeDataGrid.Rows.Add(
                       dataTable.Rows[i]["id"],
                       dataTable.Rows[i]["numbers_of_family"],
                       dataTable.Rows[i]["power_of_family"],
                       dataTable.Rows[i]["hive_state"],
                       dataTable.Rows[i]["honey_average"],
                       formattedDate,
                       dataTable.Rows[i]["honey_price"]
                   );
                }
                foreach(var s in ID)
                {
                    ElementID.AddItem(s);
                   
                }
            }
        }

        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            NumberOfFamily.Text = dataTable.Rows[ElementID.selectedIndex]["numbers_of_family"].ToString();
            for (int i = 0; i < 6; i++)
            {
                if (PowerOfFamily.selectedValue == dataTable.Rows[ElementID.selectedIndex]["power_of_family"].ToString())
                {
                    PowerOfFamily.selectedIndex = i - 1; break;
                }
                else
                {
                    PowerOfFamily.selectedIndex = i;
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (HiveState.selectedValue == dataTable.Rows[ElementID.selectedIndex]["hive_state"].ToString())
                {
                    HiveState.selectedIndex = i - 1; break;
                }
                else
                {
                    HiveState.selectedIndex = i;
                }
            }
            HoneyAverage.Text = dataTable.Rows[ElementID.selectedIndex]["honey_average"].ToString();
            InstallDate.Value = Convert.ToDateTime(dataTable.Rows[ElementID.selectedIndex]["install_date"]);
            HoneyPrice.Text = dataTable.Rows[ElementID.selectedIndex]["honey_price"].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(ElementID.selectedIndex == -1)
            {
                MessageBox.Show("Ви не вибрали елемент для редагування\nВиберіть будь ласка елемент та спробуйте знову", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            DataBase db = new DataBase();
            DialogResult dialog = MessageBox.Show("Ви впевнені що хочете відправити ці зміни?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {

                        db.OpenConnection();

                        string query = "UPDATE bee SET numbers_of_family = @numbers_of_family, power_of_family = @power_of_family, " +
                            "hive_state = @hive_state, honey_average = @honey_average, install_date = @install_date, honey_price = @honey_price WHERE id = @id";

                        using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
                        {
                            command.Parameters.AddWithValue("@numbers_of_family", int.Parse(NumberOfFamily.Text));
                            command.Parameters.AddWithValue("@power_of_family", PowerOfFamily.selectedValue.ToString());
                            command.Parameters.AddWithValue("@hive_state", int.Parse(HiveState.selectedValue.ToString()));
                            command.Parameters.AddWithValue("@honey_average", int.Parse(HoneyAverage.Text));
                            command.Parameters.AddWithValue("@install_date", DateTime.Parse(InstallDate.Value.ToString()));
                            command.Parameters.AddWithValue("@honey_price", int.Parse(HoneyPrice.Text.ToString()));
                            command.Parameters.AddWithValue("@id", ID[ElementID.selectedIndex]);

                            beeDataGrid.Rows.Clear();
                            dataTable.Clear();
                            ElementID.Clear();
                            ID.Clear();

                            command.ExecuteNonQuery();
                            Console.WriteLine("Зміни успішно відправлені");
                            RefreshData();
                            MessageBox.Show("Зміни успішно відправлені до бази даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Під час додавання інформацію про вулик виникла помилка");
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
