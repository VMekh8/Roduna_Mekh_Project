using Roduna_Mekh_Project.RationWindows;
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
    public partial class RationMainWindow : Form
    {
        MainWindow mainWindow;
        public RationMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void AddRationButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddRationWindow());
        }

        private void DeleteRationButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteRationWindow());
        }
    }
}
