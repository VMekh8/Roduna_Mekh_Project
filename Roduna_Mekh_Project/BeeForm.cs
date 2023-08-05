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
    public partial class BeeForm : Form
    {
        public BeeForm()
        {
            InitializeComponent();

          

            beeDataGrid.Rows.Add("Запис 1", "Довільний текст 1", 123, true, DateTime.Now, 3.14);
            beeDataGrid.Rows.Add("Запис 2", "Довільний текст 2", 456, false, DateTime.Now.AddDays(1), 2.71);
        }

        
    }
}
