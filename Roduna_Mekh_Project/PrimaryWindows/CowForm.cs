using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Roduna_Mekh_Project.CowWindows;
using Roduna_Mekh_Project.DiseaseWindows.Disesase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class CowForm : Form
    {
        
       
        MainWindow mainWindow;
        private bool isPanelExpanded;

        public CowForm(MainWindow mainWindow)
        {
            InitializeComponent();
            
            this.mainWindow = mainWindow;
            for (int i = 1; i <= 5; i++)
            {
                cowDataGrid.Rows.Add(i, "Стать " + i, DateTime.Now, "Порода " + i, i * 10.0m, i * 2.0m, i, i);
            }

            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;
            int targetHeight = 0;

            if (timer1.Tag.ToString() == "Expand")
            {
                targetHeight = panel2.MaximumSize.Height;
            }
            else if (timer1.Tag.ToString() == "Collapse")
            {
                targetHeight = panel2.MinimumSize.Height;
            }

            if (panel2.Height != targetHeight)
            {
                int step = (targetHeight - panel2.Height > 0) ? animationSpeed : -animationSpeed;
                panel2.Height += step;

                if ((step > 0 && panel2.Height > targetHeight) || (step < 0 && panel2.Height < targetHeight))
                {
                    panel2.Height = targetHeight;
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

       



        private void button1_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            cowDataGrid.Rows.Clear();
        }

        private void Nav1_MouseHover(object sender, EventArgs e) => Nav1.ForeColor = Color.Gray;
   
        private void Nav1_MouseLeave(object sender, EventArgs e)=> Nav1.ForeColor = Color.FromArgb(64, 64, 64); 

        private void nav2_MouseHover(object sender, EventArgs e) => nav2.ForeColor = Color.Gray;
       
        private void nav2_MouseLeave(object sender, EventArgs e) => nav2.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav3_MouseHover(object sender, EventArgs e) => nav3.ForeColor = Color.Gray;

        private void nav3_MouseLeave(object sender, EventArgs e) => nav3.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav4_MouseHover(object sender, EventArgs e) => nav4.ForeColor = Color.Gray;

        private void nav4_MouseLeave(object sender, EventArgs e) => nav4.ForeColor = Color.FromArgb(64, 64, 64);

        private void nav2_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.panel3.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.PanelForm(new DiseaseMainWindow(mainWindow));
        }

        private void Nav1_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.panel3.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(177, 122, 162);
            mainWindow.PanelForm(new RationMainWindow(mainWindow));
        }

        private void nav3_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AboutCowWithPreg());
        }

        private void nav4_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new CostsFlowFromCowWindow());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isPanelExpanded)
            {
                timer1.Tag = "Expand";
                timer1.Start();
            }
            else
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }

            isPanelExpanded = !isPanelExpanded;
        }

    }
}

        
    

