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
    public partial class BeePlaningWindow : Form
    {
        public BeePlaningWindow()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
       
    }
}
