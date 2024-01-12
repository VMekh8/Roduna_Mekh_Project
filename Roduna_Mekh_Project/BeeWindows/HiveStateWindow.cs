using Roduna_Mekh_Project.BeeWindows.BeeStateWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.BeeWindows
{
    public partial class HiveStateWindow : Form
    {
        public HiveStateWindow()
        {
            InitializeComponent();
            PanelForm(new HiveWindow());
        }

        public void PanelForm(Form fm)
        {
            panelMainPage.Controls.Clear();
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            panelMainPage.Controls.Add(fm);
            panelMainPage.Tag = fm;
            fm.BringToFront();
            fm.Show();
            panelMainPage.BringToFront();
            panelMainPage.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelForm(new BeeStateWndw());
            button2.BackColor = Color.FromArgb(245, 179, 66);
            button1.BackColor = Color.Cornsilk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelForm(new HiveWindow());
            button1.BackColor = Color.FromArgb(245, 179, 66);
            button2.BackColor = Color.Cornsilk;

        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
