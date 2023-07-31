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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private Login login = new Login();
        Register register;
        private void label6_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login.Visible = false; 
            }

            
            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;

            
            Timer timer = new Timer();
            timer.Interval = 30;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep; 
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop(); 
                    this.Hide(); 
                    login.Opacity = 0; 
                    login.Show(); 
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        login.Opacity = stepSize * currentFadeInStep; 
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
       
      
    }
}
