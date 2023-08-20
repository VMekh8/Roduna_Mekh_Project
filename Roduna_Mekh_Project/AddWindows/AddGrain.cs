using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.InformationWindows
{
    public partial class AddGrain : Form
    {
        private Button Incrementbutton, Decrementbutton;
        private BunifuMaterialTextbox activeTextBox;

        public AddGrain()
        {
            InitializeComponent();
            Create_Button();


            areaField.Enter += TextBox_Enter;
            FuelConsuption.Enter += TextBox_Enter;
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
            double currentValue = double.Parse(activeTextBox.Text);
            if (activeTextBox == areaField)
            {
                currentValue += 0.05;
                activeTextBox.Text = currentValue.ToString();
            }
            else
            {
                currentValue++;
                activeTextBox.Text = currentValue.ToString();
            }
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(activeTextBox.Text);
            if (currentValue > 0)
            {
                if (activeTextBox == areaField)
                {
                    currentValue -= 0.05;
                    activeTextBox.Text = currentValue.ToString();
                }
                else
                {
                    currentValue--;
                    activeTextBox.Text = currentValue.ToString();
                }

            }
        }
    }

}