using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.PigWindows
{
    public partial class PigWithPregWindow : Form
    {
        MainWindow mainWindow;
        public PigWithPregWindow(MainWindow mainWindow)
        {
            InitializeComponent();


            this.mainWindow = mainWindow;
        }
    }
}
