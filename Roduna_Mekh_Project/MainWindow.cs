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
        private Timer timer1, timer2, timer3, timer4;
        private Panel CurrentPanel = null;
        public MainWindow()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tag = "Expand"; 
            timer1.Tick += timer1_Tick;
            timer2 = new Timer();
            timer2.Interval = 10;
            timer2.Tag = "Expand"; 
            timer2.Tick += timer2_Tick;
            timer3 = new Timer();
            timer3.Interval = 10;
            timer3.Tag = "Expand"; 
            timer3.Tick += timer3_Tick;
            timer4 = new Timer();
            timer4.Interval = 10;
            timer4.Tag = "Expand"; 
            timer4.Tick += timer4_Tick;
           
            
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;

            if (timer2.Tag.ToString() == "Expand")
            {
                if (panelStockbreeding.Height < panelStockbreeding.MaximumSize.Height)
                {
                    panelStockbreeding.Height += animationSpeed;
                }
                else
                {
                    timer2.Stop();
                }
            }
            else if (timer2.Tag.ToString() == "Collapse")
            {
                if (panelStockbreeding.Height > panelStockbreeding.MinimumSize.Height)
                {
                    panelStockbreeding.Height -= animationSpeed;
                }
                else
                {
                    timer2.Stop();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;

            if (timer3.Tag.ToString() == "Expand")
            {
                if (PanelPig.Height < PanelPig.MaximumSize.Height)
                {
                    PanelPig.Height += animationSpeed;
                }
                else
                {
                    timer3.Stop();
                }
            }
            else if (timer3.Tag.ToString() == "Collapse")
            {
                if (PanelPig.Height > PanelPig.MinimumSize.Height)
                {
                    PanelPig.Height -= animationSpeed;
                }
                else
                {
                    timer3.Stop();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;

            if (timer4.Tag.ToString() == "Expand")
            {
                if (PanelGrain.Height < PanelGrain.MaximumSize.Height)
                {
                    PanelGrain.Height += animationSpeed;
                }
                else
                {
                    timer4.Stop();
                }
            }
            else if (timer4.Tag.ToString() == "Collapse")
            {
                if (PanelGrain.Height > PanelGrain.MinimumSize.Height)
                {
                    PanelGrain.Height -= animationSpeed;
                }
                else
                {
                    timer4.Stop();
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonBee_MouseHover(object sender, EventArgs e)
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

        

        private void buttonCow_MouseEnter(object sender, EventArgs e)
        {
            timer2.Tag = "Expand";
            timer2.Start();
        }

        private void buttonCow_MouseLeave(object sender, EventArgs e)
        {
            if (!panelStockbreeding.ClientRectangle.Contains(panelStockbreeding.PointToClient(MousePosition)))
            {
                timer2.Tag = "Collapse";
                timer2.Start();
            }
        }

        private void buttonPig_MouseEnter(object sender, EventArgs e)
        {
            timer3.Tag = "Expand";
            timer3.Start();
        }

        

        private void buttonPig_MouseLeave(object sender, EventArgs e)
        {
            if (!PanelPig.ClientRectangle.Contains(PanelPig.PointToClient(MousePosition)))
            {
                timer3.Tag = "Collapse";
                timer3.Start();
            }
        }

       

        private void buttonGrain_MouseEnter(object sender, EventArgs e)
        {
            timer4.Tag = "Expand";
            timer4.Start();
        }

        

        private void buttonGrain_MouseLeave(object sender, EventArgs e)
        {
            if (!PanelGrain.ClientRectangle.Contains(PanelGrain.PointToClient(MousePosition)))
            {
                timer4.Tag = "Collapse";
                timer4.Start();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;



            Timer timer = new Timer();
            timer.Interval = 30;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep;
                currentStep++;
                if (this.Opacity == 0)
                {
                    timer.Stop();
                    Application.Exit();
                }

            };
            timer.Start();
        }

        private void panelStockbreeding_LocationChanged(object sender, EventArgs e)
        {
            if (CurrentPanel == panelStockbreeding && panel2.Location != panelStockbreeding.Location)
            {
                panel2.Location = panelStockbreeding.Location;
            }
        }

        private void PanelPig_LocationChanged(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelPig && panel2.Location != PanelPig.Location)
            {
                panel2.Location = PanelPig.Location;
            }
        }

        private void PanelGrain_LocationChanged(object sender, EventArgs e)
        {
            if (CurrentPanel == PanelGrain && panel2.Location != PanelGrain.Location)
            {
                panel2.Location = PanelGrain.Location;
            }
        }




















        private void HomeButton_Click(object sender, EventArgs e)
        {
            CurrentPanel = NavigationPanel;
            panel2.Location = HomeButton.Location;
        }

        private void buttonBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;
        }

      

        private void buttonCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;

        }
        private void buttonPig_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;

        }

        private void buttonGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;

        }

    }
}
