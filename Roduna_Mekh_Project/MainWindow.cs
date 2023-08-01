using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class MainWindow : Form
    {
        private Timer timer1;
        private bool isCollapsed;
        public MainWindow()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tag = "Expand"; 
            timer1.Tick += timer1_Tick;
        }

        private void buttonBee_MouseEnter(object sender, EventArgs e)
        {
            timer1.Tag = "Expand";
            timer1.Start();
        }

        private void buttonBee_MouseLeave(object sender, EventArgs e)
        {
            if (!panelBeekeeping.ClientRectangle.Contains(panelBeekeeping.PointToClient(MousePosition)))
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5; 

            if (timer1.Tag.ToString() == "Expand")
            {
                if (panelBeekeeping.Height < panelBeekeeping.MaximumSize.Height)
                {
                    panelBeekeeping.Height += animationSpeed;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else if (timer1.Tag.ToString() == "Collapse")
            {
                if (panelBeekeeping.Height > panelBeekeeping.MinimumSize.Height)
                {
                    panelBeekeeping.Height -= animationSpeed;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }
    }
}
