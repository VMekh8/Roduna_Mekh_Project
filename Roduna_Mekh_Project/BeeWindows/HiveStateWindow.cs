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
        Form CurrentForm;
        public HiveStateWindow()
        {
            InitializeComponent();
            //PanelForm(new HiveWindow());
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

    }
}
