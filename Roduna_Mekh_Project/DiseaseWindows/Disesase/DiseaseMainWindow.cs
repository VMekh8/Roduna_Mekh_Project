using MySqlX.XDevAPI.Relational;
using Roduna_Mekh_Project.DiseaseWindows.Medicine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.DiseaseWindows.Disesase
{
    public partial class DiseaseMainWindow : Form
    {
        MainWindow mainWindow;
        public DiseaseMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            for (int i = 1; i <= 5; i++)
            {
                DiseaseDataGrid.Rows.Add(i, "Назва " + i, "Тип " + i, "Симптоми " + i, "Опис " + i, i);
            }
        }

        private void AddDiseaseButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddDiseaseWindow());
        }

        private void DeleteDiseaseButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteDisesaseWindow());
        }

        private void MedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(193, 211, 254);
            mainWindow.panel3.BackColor = Color.FromArgb(193, 211, 254);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(193, 211, 254);

            mainWindow.PanelForm(new MedicineMainWindow(mainWindow));
        }
    }
}
