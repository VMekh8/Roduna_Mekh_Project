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
using Roduna_Mekh_Project.InformationWindows;
using Roduna_Mekh_Project.DeleteWindows;
using Roduna_Mekh_Project.EditingWindows;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Roduna_Mekh_Project
{
    public partial class MainWindow : Form
    {
        private Timer timer1;
        private Panel CurrentPanel = null;
        private Form CurrentForm;
        private AskWindow AskWindow;
        private AboutFarmWindow AboutFarmWindow;
        private AboutAuthorWindow AboutAuthorWindow;
        private AboutBee AboutBee;
        private AboutCow AboutCow;
        private AboutPig AboutPig;
        private AboutGrain AboutGrain;

        Series seriesIncomes = new Series("Incomes");
       
        Series seriesExpenses = new Series("Expenses");

        public MainWindow()
        {
            InitializeComponent();
            panelMainPage.Hide();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tag = "Expand"; 
            timer1.Tick += timer1_Tick;
            UpdateChartWithData();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ConfigurePieChart(chart1);
            chart1.Series.Add(seriesIncomes);

            ConfigurePieChart(chart2);
            chart2.Series.Add(seriesExpenses);

        }


        private void UpdateChartWithData()
        {
            //DataBase db = new DataBase();
            //string query = "SELECT agro_category, incomes, extendes FROM costsflow";
            //db.OpenConnection();

            //SqlDataAdapter adapter = new SqlDataAdapter(query, db.getConnection());
            //DataTable data = new DataTable();
            //adapter.Fill(data);

            //seriesIncomes.ChartType = SeriesChartType.Pie;
            //seriesIncomes.Points.Clear();

            //seriesIncomes.Points.AddXY("Корови", int.Parse(data.Rows[1]["incomes"].ToString()));
            //seriesIncomes.Points.AddXY("Вулики", int.Parse(data.Rows[0]["incomes"].ToString()));
            //seriesIncomes.Points.AddXY("Свині", int.Parse(data.Rows[2]["incomes"].ToString()));
            //seriesIncomes.Points.AddXY("Поля", int.Parse(data.Rows[3]["incomes"].ToString()));

            

            //ConfigurePieChart(chart1);

            //seriesExpenses.ChartType = SeriesChartType.Pie;
            //seriesExpenses.Points.Clear();

            //seriesExpenses.Points.AddXY("Корови", int.Parse(data.Rows[1]["extendes"].ToString()));
            //seriesExpenses.Points.AddXY("Вулики", int.Parse(data.Rows[0]["extendes"].ToString()));
            //seriesExpenses.Points.AddXY("Свині", int.Parse(data.Rows[2]["extendes"].ToString()));
            //seriesExpenses.Points.AddXY("Поля", int.Parse(data.Rows[3]["extendes"].ToString()));

            

            //ConfigurePieChart(chart2);
            //db.CloseConnection();
        }

        private void ConfigurePieChart(Chart chart)
        {
            chart.BackColor = System.Drawing.Color.WhiteSmoke;
            

            foreach (Legend legend in chart.Legends)
            {
                legend.Font = new System.Drawing.Font("Arial", 10);
            }
        }

        private void OpenInfoWindows(Form Window)
        {
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
                    Window.Opacity = 0;
                    Window.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        Window.Opacity = stepSize * currentFadeInStep;
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


        private void OpenWindows(Form OpenWindow)
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
                    this.Close();
                    OpenWindow.Opacity = 0;
                    OpenWindow.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        OpenWindow.Opacity = stepSize * currentFadeInStep;
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


        public void PanelForm(Form fm)
        {
            CurrentForm = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.BackColor = Color.White;
            panelMainPage.Controls.Add(fm);
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
            if (panelBeekeeping.ClientRectangle.Contains(panelBeekeeping.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Expand", panelBeekeeping);
                timer1.Start();
            }
        }

        

        private void buttonBee_MouseLeave(object sender, EventArgs e)
        {
            if (!panelBeekeeping.ClientRectangle.Contains(panelBeekeeping.PointToClient(MousePosition)))
            {
                timer1.Tag = new Tuple<string, Panel>("Collapse", panelBeekeeping); 
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
           
            UpdateChartWithData();
        }

        private void buttonBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;

            panel1.BackColor = Color.FromArgb(223,151,8);
            panel2.BackColor = Color.FromArgb(223,151,8);
            TopPanelDesign.BackColor = Color.FromArgb(223,151,8);
            panel3.BackColor = Color.FromArgb(223,151,8);

            PanelForm(new BeeForm(this));
        }

        private void buttonCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;
            panel2.BackColor = Color.FromArgb(8, 132, 223);
            
            PanelForm(new CowForm(this));
        }
        private void buttonPig_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;
            panel2.BackColor = Color.FromArgb(223, 85, 179);

            PanelForm(new PigForm(this));
        }

        private void buttonGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;
            panel2.BackColor = Color.FromArgb(23, 177, 10);

            PanelForm(new GrainForm(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AskWindow == null)
            {
                AskWindow = new AskWindow();
                AskWindow.Visible = false;
                
            }

            OpenWindows(AskWindow);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (AboutFarmWindow == null)
            {
                AboutFarmWindow = new AboutFarmWindow();
                AboutFarmWindow.Visible = false;
            }

            OpenWindows(AboutFarmWindow);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AboutAuthorWindow == null)
            {
                AboutAuthorWindow = new AboutAuthorWindow();
                AboutAuthorWindow.Visible = false;
            }

            OpenWindows(AboutAuthorWindow);
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (AboutBee == null)
            {
                AboutBee = new AboutBee();
                AboutBee.Visible = false;
            }

            OpenInfoWindows(AboutBee);

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (AboutCow == null)
            {
                AboutCow = new AboutCow();
                AboutCow.Visible = false;
            }

            OpenInfoWindows(AboutCow);

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (AboutPig == null)
            {
                AboutPig = new AboutPig();
                AboutPig.Visible = false;
            }

            OpenInfoWindows(AboutPig);

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (AboutGrain == null)
            {
                AboutGrain = new AboutGrain();
                AboutGrain.Visible = false;
            }

            OpenInfoWindows(AboutGrain);

        }

        private void ButtonAddBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;

            panel1.BackColor = Color.FromArgb(223, 151, 8);
            panel2.BackColor = Color.FromArgb(223, 151, 8);
            TopPanelDesign.BackColor = Color.FromArgb(223, 151, 8);
            panel3.BackColor = Color.FromArgb(223, 151, 8);

            PanelForm(new AddBee());
        }

        private void ButtodAddCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;


            panel1.BackColor = Color.FromArgb(8, 132, 223);
            panel2.BackColor = Color.FromArgb(8, 132, 223);
            TopPanelDesign.BackColor = Color.FromArgb(8, 132, 223);
            panel3.BackColor = Color.FromArgb(8, 132, 223);

            PanelForm(new AddCow());
        }

        private void ButtodAddPig_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;

            panel1.BackColor = Color.FromArgb(223, 85, 179);
            panel2.BackColor = Color.FromArgb(223, 85, 179);
            TopPanelDesign.BackColor = Color.FromArgb(223, 85, 179);
            panel3.BackColor = Color.FromArgb(223, 85, 179);

            PanelForm(new AddPig());
        }

        private void ButtonAddGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;

            panel1.BackColor = Color.FromArgb(23, 177, 10);
            panel2.BackColor = Color.FromArgb(23, 177, 10);
            TopPanelDesign.BackColor = Color.FromArgb(23, 177, 10);
            panel3.BackColor = Color.FromArgb(23, 177, 10);

            PanelForm(new AddGrain());
        }

        private void ButtonDeleteBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;

            panel1.BackColor = Color.FromArgb(223, 151, 8);
            panel2.BackColor = Color.FromArgb(223, 151, 8);
            TopPanelDesign.BackColor = Color.FromArgb(223, 151, 8);
            panel3.BackColor = Color.FromArgb(223, 151, 8);

            PanelForm(new DeleteBee());
        }

        private void ButtodDeleteCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;


            panel1.BackColor = Color.FromArgb(8, 132, 223);
            panel2.BackColor = Color.FromArgb(8, 132, 223);
            TopPanelDesign.BackColor = Color.FromArgb(8, 132, 223);
            panel3.BackColor = Color.FromArgb(8, 132, 223);

            PanelForm(new DeleteCow());

        }

        private void ButtodDeletePig_Click(object sender, EventArgs e)
        {

            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;

            panel1.BackColor = Color.FromArgb(223, 85, 179);
            panel2.BackColor = Color.FromArgb(223, 85, 179);
            TopPanelDesign.BackColor = Color.FromArgb(223, 85, 179);
            panel3.BackColor = Color.FromArgb(223, 85, 179);

            PanelForm(new DeletePig());
        }

        private void ButtonDeleteGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;

            panel1.BackColor = Color.FromArgb(23, 177, 10);
            panel2.BackColor = Color.FromArgb(23, 177, 10);
            TopPanelDesign.BackColor = Color.FromArgb(23, 177, 10);
            panel3.BackColor = Color.FromArgb(23, 177, 10);

            PanelForm(new DeleteGrain());
        }

        private void ButtonEditBee_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelBeekeeping;
            panel2.Location = panelBeekeeping.Location;

            panel1.BackColor = Color.FromArgb(223, 151, 8);
            panel2.BackColor = Color.FromArgb(223, 151, 8);
            TopPanelDesign.BackColor = Color.FromArgb(223, 151, 8);
            panel3.BackColor = Color.FromArgb(223, 151, 8);

            PanelForm(new EditBee());
        }

        private void ButtodEditCow_Click(object sender, EventArgs e)
        {
            CurrentPanel = panelStockbreeding;
            panel2.Location = panelStockbreeding.Location;


            panel1.BackColor = Color.FromArgb(8, 132, 223);
            panel2.BackColor = Color.FromArgb(8, 132, 223);
            TopPanelDesign.BackColor = Color.FromArgb(8, 132, 223);
            panel3.BackColor = Color.FromArgb(8, 132, 223);

            PanelForm(new EditCow());
        }

        private void ButtodEditPig_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelPig;
            panel2.Location = PanelPig.Location;

            panel1.BackColor = Color.FromArgb(223, 85, 179);
            panel2.BackColor = Color.FromArgb(223, 85, 179);
            TopPanelDesign.BackColor = Color.FromArgb(223, 85, 179);
            panel3.BackColor = Color.FromArgb(223, 85, 179);

            PanelForm(new EditPig());
        }

        private void ButtonEditGrain_Click(object sender, EventArgs e)
        {
            CurrentPanel = PanelGrain;
            panel2.Location = PanelGrain.Location;

            panel1.BackColor = Color.FromArgb(23, 177, 10);
            panel2.BackColor = Color.FromArgb(23, 177, 10);
            TopPanelDesign.BackColor = Color.FromArgb(23, 177, 10);
            panel3.BackColor = Color.FromArgb(23, 177, 10);

            PanelForm(new EditGrain());
        }

    }
}

