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
    public partial class AboutGrain : Form
    {
        public AboutGrain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
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
                }
            };
            timer.Start();
        }
    }
}
