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
    public partial class AskWindow : Form
    {
        private MainWindow mainWindow;
        private bool isPanelExpanded = false;
        public AskWindow()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (mainWindow == null)
            {
                mainWindow = new MainWindow();
                mainWindow.Visible = false;
            }


            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;


            Timer timer = new Timer();
            timer.Interval = 10;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep;
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop();
                    this.Hide();
                    mainWindow.Opacity = 0;
                    mainWindow.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        mainWindow.Opacity = stepSize * currentFadeInStep;
                        currentFadeInStep++;
                        if (currentFadeInStep > totalSteps)
                        {
                            fadeInTimer.Stop();
                        }
                    };
                    fadeInTimer.Start();
                }
            };
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tuple<string, Panel> tagData = timer1.Tag as Tuple<string, Panel>;
            if (tagData != null)
            {
                string tagValue = tagData.Item1;
                Panel p = tagData.Item2;

                int animationSpeed = 5;

                if (tagValue == "Expand")
                {
                    if (p.Height < p.MaximumSize.Height)
                    {
                        p.Height += animationSpeed;
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
                else if (tagValue == "Collapse")
                {
                    if (p.Height > p.MinimumSize.Height)
                    {
                        p.Height -= animationSpeed;
                    }
                    else
                    {
                        timer1.Stop();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!isPanelExpanded)
            {
                timer1.Tag = new Tuple<string, Panel>("Expand", panel2);
                timer1.Start();
            }
            else
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", panel2);
                timer1.Start();
            }

            isPanelExpanded = !isPanelExpanded;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isPanelExpanded)
            {
                timer1.Tag = new Tuple<string, Panel>("Expand", panel3);
                timer1.Start();
            }
            else
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", panel3);
                timer1.Start();
            }

            isPanelExpanded = !isPanelExpanded;
        }
    }
}
