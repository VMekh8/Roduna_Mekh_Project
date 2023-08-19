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

        public AddGrain()
        {
            InitializeComponent();
            Create_Button();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(areaField.Text);
            currentValue += 0.05;
            areaField.Text = currentValue.ToString();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(areaField.Text);
            if (currentValue > 0)
            {
                currentValue -= 0.05;
                areaField.Text = currentValue.ToString();
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



            Incrementbutton.Size = new Size(25, 25);
            Decrementbutton.Size = new Size(25, 25);

            Controls.Add(Incrementbutton);
            Controls.Add(Decrementbutton);

            int x = areaField.Location.X + areaField.Width;
            int y = areaField.Location.Y;

            Incrementbutton.Location = new System.Drawing.Point(x, y);
            Decrementbutton.Location = new System.Drawing.Point(x, y + Incrementbutton.Height);

        }
    }
}
