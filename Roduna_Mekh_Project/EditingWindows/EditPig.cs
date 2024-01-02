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
        List<string> ID = new List<string>();
        DataTable dataTable = new DataTable();
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;
        public EditPig()
        {
            InitializeComponent();
           


            Create_Button();

            WeightTextBox.Enter += TextBox_Enter;
            AverageFood.Enter += TextBox_Enter;
        }

       

        private void ElementID_onItemSelected(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (GenderDropDown.selectedValue == dataTable.Rows[ElementID.selectedIndex]["gender"].ToString())
                {
                    GenderDropDown.selectedIndex = i - 1; break;
                }
                else
                {
                    GenderDropDown.selectedIndex = i;
                }
            }
            DateBirth.Value = Convert.ToDateTime(dataTable.Rows[ElementID.selectedIndex]["date_birth"]);
            BreedTextBox.Text = dataTable.Rows[ElementID.selectedIndex]["breed"].ToString();
            WeightTextBox.Text = dataTable.Rows[ElementID.selectedIndex]["weight"].ToString();
            AverageFood.Text = dataTable.Rows[ElementID.selectedIndex]["average_food"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
    }
}
