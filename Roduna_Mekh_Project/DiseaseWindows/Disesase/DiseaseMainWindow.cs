﻿using MySqlX.XDevAPI.Relational;
using Roduna_Mekh_Project.DiseaseWindows.Medicine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataBase db = new DataBase();
        public DiseaseMainWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillDataGrid();

            this.mainWindow = mainWindow;
            ChangeWindowColors(); 
        }

        private void ChangeWindowColors()
        {
            mainWindow.panel1.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.panel3.BackColor = Color.FromArgb(112, 132, 231);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(112, 132, 231);
        }

        public delegate void OnClosedWindowDelegate();
        public event OnClosedWindowDelegate OnClosedWindow;

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            OnClosedWindow?.Invoke();
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM disease";

                using (SqlCommand cmd = new SqlCommand(query, db.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DiseaseDataGrid.DataSource = table;
                    }
                }

                DiseaseDataGrid.Columns[0].HeaderText = "Id";
                DiseaseDataGrid.Columns[1].HeaderText = "Назва захворювання";
                DiseaseDataGrid.Columns[2].HeaderText = "Тип захворювання";
                DiseaseDataGrid.Columns[3].HeaderText = "Симтоми";
                DiseaseDataGrid.Columns[4].HeaderText = "Опис";
                DiseaseDataGrid.Columns[5].HeaderText = "Номер медикаменту";


            }
            catch (Exception ex)
            {
                Console.WriteLine("При вибірці даних з таблиці disease виникла помилка");
                Console.WriteLine(ex.Message);
                MessageBox.Show("При вибірці даних виникла помилка\n\tСпробуйте знову", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void AddDiseaseButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new AddDiseaseWindow(mainWindow));
        }

        private void DeleteDiseaseButton_Click(object sender, EventArgs e)
        {
            mainWindow.PanelForm(new DeleteDisesaseWindow(mainWindow));
        }

        private void MedicineButton_Click(object sender, EventArgs e)
        {
            mainWindow.panel1.BackColor = Color.FromArgb(193, 211, 254);
            mainWindow.panel3.BackColor = Color.FromArgb(193, 211, 254);
            mainWindow.TopPanelDesign.BackColor = Color.FromArgb(193, 211, 254);

            mainWindow.PanelForm(new MedicineMainWindow(mainWindow));
        }

        private void BackToMainButton_Click(object sender, EventArgs e) => this.Close();
    }
}
