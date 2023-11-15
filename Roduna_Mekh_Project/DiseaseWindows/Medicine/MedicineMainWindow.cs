﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roduna_Mekh_Project.DiseaseWindows.Medicine
{
    public partial class MedicineMainWindow : Form
    {
        MainWindow mainWindow;
        public MedicineMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddMedicineWindow());
        }

        private void DeleteMedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteMedicineWindow());
        }
    }
}
