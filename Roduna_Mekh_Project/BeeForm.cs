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
        private bool isPanelExpanded = false;
        public BeeForm()
        {
            InitializeComponent();
            UpdateSeasonLabel();
            WhatPlants();
           


            beeDataGrid.Rows.Add("Запис 1", 123, "Переважно хороший", true, DateTime.Now, 3.14);
            beeDataGrid.Rows.Add("1", 2, "Хороший", "100%", 54, DateTime.Now.AddDays(1));
        }

        private void WhatPlants()
        {
            DateTime now = DateTime.Now;
            int month = now.Month;
            if (month >= 3 && month <= 5)
            {
                WhatPlantsLabel.Text = "● Проліски\n● Вишневі та яблуневі дереваn\n● Підсніжники\n● Жовте горицвіт\n● Крокуси";
            }
            else if (month >= 6 && month <= 8)
            {
                WhatPlantsLabel.Text = "● Бджолинець\n● Мятлик\n● Ромашка\n● Кульбаба\n● Липа";
            }
            else if (month >= 9 && month <= 11)
            {
                WhatPlantsLabel.Text = "● Чорнобривці\n● Горіхи\n● Таволга\n● Айстри\n● Герань";
            }
            else WhatPlantsLabel.Text = "● Зараз холодно\n Тому бджоли відпочивають.";
        }


        private void UpdateSeasonLabel()
        {
            DateTime now = DateTime.Now;
            int month = now.Month;

            string season = "";
            if (month >= 3 && month <= 5)
                season = "Весна";
            else if (month >= 6 && month <= 8)
                season = "Літо";
            else if (month >= 9 && month <= 11)
                season = "Осінь";
            else
                season = "Зима";

            SeasonLabel.Text = "Пора року: " + season;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int animationSpeed = 5;
            int targetHeight = 0;

            if (timer1.Tag.ToString() == "Expand")
            {
                targetHeight = panel2.MaximumSize.Height;
            }
            else if (timer1.Tag.ToString() == "Collapse")
            {
                targetHeight = panel2.MinimumSize.Height;
            }

            if (panel2.Height != targetHeight)
            {
                int step = (targetHeight - panel2.Height > 0) ? animationSpeed : -animationSpeed;
                panel2.Height += step;

                if ((step > 0 && panel2.Height > targetHeight) || (step < 0 && panel2.Height < targetHeight))
                {
                    panel2.Height = targetHeight;
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isPanelExpanded)
            {
                timer1.Tag = "Expand";
                timer1.Start();
            }
            else
            {
                timer1.Tag = "Collapse";
                timer1.Start();
            }

            isPanelExpanded = !isPanelExpanded;
        }
    }
}
