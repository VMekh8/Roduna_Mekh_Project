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
    public partial class AddPig : Form
    {
        private Button Incrementbutton, Decrementbutton;

        public AddPig()
        {
            InitializeComponent();
            Create_Button();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(WeightTextBox.Text);
            currentValue += 10;
            WeightTextBox.Text = currentValue.ToString();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(WeightTextBox.Text);
            if (currentValue > 0)
            {
                currentValue -= 10;
                WeightTextBox.Text = currentValue.ToString();
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

            Incrementbutton.Visible = true;
            Decrementbutton.Visible = true;



            Incrementbutton.Size = new Size(25, 20);
            Decrementbutton.Size = new Size(25, 20);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);

            int x = WeightTextBox.Location.X + WeightTextBox.Width;
            int y = WeightTextBox.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

        }
    }
}
