using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project
{
    public partial class MainWindow : Form
    {
        private Timer timer1;
        private Panel CurrentPanel = null;
        private Form CurrentForm;
        private AskWindow AskWindow;
        private AboutFarmWindow AboutFarmWindow;

        public MainWindow()
        {
            InitializeComponent();
            panelMainPage.Hide();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tag = "Expand"; 
            timer1.Tick += timer1_Tick;
            

            int cornerRadius = 15;

            
            System.Drawing.Drawing2D.GraphicsPath roundedPath = new System.Drawing.Drawing2D.GraphicsPath();
            roundedPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath.AddArc(panel4.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            roundedPath.AddArc(panel4.Width - cornerRadius, panel4.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            roundedPath.AddArc(0, panel4.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            roundedPath.CloseAllFigures();
            panel4.Region = new System.Drawing.Region(roundedPath);

            System.Drawing.Drawing2D.GraphicsPath roundedPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            roundedPath1.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath1.AddArc(panel5.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            roundedPath1.AddArc(panel5.Width - cornerRadius, panel5.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            roundedPath1.AddArc(0, panel5.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            roundedPath1.CloseAllFigures();
            panel5.Region = new System.Drawing.Region(roundedPath1);

            System.Drawing.Drawing2D.GraphicsPath roundedPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            roundedPath2.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath2.AddArc(panel6.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            roundedPath2.AddArc(panel6.Width - cornerRadius, panel6.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            roundedPath2.AddArc(0, panel6.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            roundedPath2.CloseAllFigures();
            panel6.Region = new System.Drawing.Region(roundedPath2);

            System.Drawing.Drawing2D.GraphicsPath roundedPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            roundedPath3.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath3.AddArc(panel7.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            roundedPath3.AddArc(panel7.Width - cornerRadius, panel7.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            roundedPath3.AddArc(0, panel7.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            roundedPath3.CloseAllFigures();
            panel7.Region = new System.Drawing.Region(roundedPath3);
        }


        private void PanelForm(Form fm)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }

            CurrentForm = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.BackColor = Color.White;
            this.panelMainPage.Controls.Add(fm);
            this.panelMainPage.Tag = fm;
            fm.BringToFront();
            fm.Show();
            panelMainPage.BringToFront();
            panelMainPage.Show();
            
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

        private void timer5_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonBee_MouseHover(object sender, EventArgs e)
        {
            timer1.Tag = new Tuple<string, Panel>("Expand", panelBeekeeping); 
            timer1.Start();

        }

        

        private void buttonBee_MouseLeave(object sender, EventArgs e)
        {
            if (!panelBeekeeping.ClientRectangle.Contains(panelBeekeeping.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", panelBeekeeping); 
                timer1.Start();
                timer1.Start();
                timer1.Start();
            }
        }

        

        private void buttonCow_MouseEnter(object sender, EventArgs e)
        {
            timer1.Tag = new Tuple<string, Panel>("Expand", panelStockbreeding);
            timer1.Start();
        }

        private void buttonCow_MouseLeave(object sender, EventArgs e)
        {
            if (!panelStockbreeding.ClientRectangle.Contains(panelStockbreeding.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", panelStockbreeding);
                timer1.Start();
            }
        }

        private void buttonPig_MouseEnter(object sender, EventArgs e)
        {
            timer1.Tag = new Tuple<string, Panel>("Expand", PanelPig);
            timer1.Start();
        }

        

        private void buttonPig_MouseLeave(object sender, EventArgs e)
        {
            if (!PanelPig.ClientRectangle.Contains(PanelPig.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", PanelPig);
                timer1.Start();
            }
        }

       

        private void buttonGrain_MouseEnter(object sender, EventArgs e)
        {
            timer1.Tag = new Tuple<string, Panel>("Expand", PanelGrain);
            timer1.Start();
        }

        

        private void buttonGrain_MouseLeave(object sender, EventArgs e)
        {
            if (!PanelGrain.ClientRectangle.Contains(PanelGrain.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", PanelGrain);
                timer1.Start();
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

            panel1.BackColor = Color.FromArgb(145, 127, 206);
            panel2.BackColor = Color.FromArgb(145, 127, 206);
            TopPanelDesign.BackColor = Color.FromArgb(145, 127, 206);
            panel3.BackColor = Color.FromArgb(145, 127, 206);

            panelMainPage.Hide();
        }

        private void buttonBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;

            panel1.BackColor = Color.FromArgb(223,151,8);
            panel2.BackColor = Color.FromArgb(223,151,8);
            TopPanelDesign.BackColor = Color.FromArgb(223,151,8);
            panel3.BackColor = Color.FromArgb(223,151,8);

            PanelForm(new BeeForm());
        }

        private void buttonCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;


            panel1.BackColor = Color.FromArgb(8, 132, 223);
            panel2.BackColor = Color.FromArgb(8, 132, 223);
            TopPanelDesign.BackColor = Color.FromArgb(8, 132, 223);
            panel3.BackColor = Color.FromArgb(8, 132, 223);

            PanelForm(new CowForm());
        }
        private void buttonPig_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;

            panel1.BackColor = Color.FromArgb(223, 85, 179);
            panel2.BackColor = Color.FromArgb(223, 85, 179);
            TopPanelDesign.BackColor = Color.FromArgb(223, 85, 179);
            panel3.BackColor = Color.FromArgb(223, 85, 179);

            PanelForm(new PigForm());
        }

        private void buttonGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;

            panel1.BackColor = Color.FromArgb(23, 177, 10);
            panel2.BackColor = Color.FromArgb(23, 177, 10);
            TopPanelDesign.BackColor = Color.FromArgb(23, 177, 10);
            panel3.BackColor = Color.FromArgb(23, 177, 10);

            PanelForm(new GrainForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AskWindow == null)
            {
                AskWindow = new AskWindow();
                AskWindow.Visible = false;
            }


            int totalSteps = 15;
            double stepSize = 1.0 / totalSteps;


            Timer timer = new Timer();
            timer.Interval = 10;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop();
                    AskWindow.Opacity = 0;
                    AskWindow.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        AskWindow.Opacity = stepSize * currentFadeInStep;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (AskWindow == null)
            {
                AboutFarmWindow = new AboutFarmWindow();
                AboutFarmWindow.Visible = false;
            }


            int totalSteps = 15;
            double stepSize = 1.0 / totalSteps;


            Timer timer = new Timer();
            timer.Interval = 10;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop();
                    AboutFarmWindow.Opacity = 0;
                    AboutFarmWindow.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        AboutFarmWindow.Opacity = stepSize * currentFadeInStep;
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
