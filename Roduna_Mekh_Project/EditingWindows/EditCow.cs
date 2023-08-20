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

namespace Roduna_Mekh_Project.EditingWindows
{
    public partial class EditCow : Form
    {
        private BunifuMaterialTextbox activeTextBox;
        private Button Incrementbutton, Decrementbutton;
        public EditCow()
        {
            InitializeComponent();
            Create_Button();


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


    }
}
