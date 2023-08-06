using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class AboutFarmWindow : Form
    {
        private MainWindow mainWindow;
       
        public AboutFarmWindow()
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
    }
}
