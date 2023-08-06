
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Roduna_Mekh_Project
{
    public partial class AboutFarmWindow : Form
    {
        private MainWindow mainWindow;
        private int currentImageIndex = 0;
        private List<Image> images = new List<Image>();
        private int animationSteps = 1;
        private double stepSize;
        private double currentOpacity = 1.0;


        public AboutFarmWindow()
        {
            InitializeComponent();

            images.Add(Properties.Resources.image1);
            images.Add(Properties.Resources.image2);
            images.Add(Properties.Resources.image3);
            images.Add(Properties.Resources.image4);
            SliderBox.Image = images[currentImageIndex];
            stepSize = 1.0 / animationSteps;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (mainWindow == null)
            {
                mainWindow = new MainWindow();
                mainWindow.Visible = false;
            }


            int totalSteps = 20;
            double stepSize = 1.0 / totalSteps;


            Timer timer = new Timer();
            timer.Interval = 10;
            int currentStep = 0;
            timer.Tick += (s, ev) =>
            {
                this.Opacity = 1 - stepSize * currentStep;
                currentStep++;
                if (currentStep > totalSteps)
                {
                    timer.Stop();
                    this.Hide();
                    mainWindow.Opacity = 0;
                    mainWindow.Show();
                    Timer fadeInTimer = new Timer();
                    fadeInTimer.Interval = 30;
                    int currentFadeInStep = 0;
                    fadeInTimer.Tick += (c, av) =>
                    {
                        mainWindow.Opacity = stepSize * currentFadeInStep;
                        currentFadeInStep++;
                        if (currentFadeInStep > totalSteps)
                        {
                            fadeInTimer.Stop();
                        }
                    };
                    fadeInTimer.Start();
                }
            };
            timer.Start();
        }

        private void AnimateImageTransition()
        {
            currentOpacity -= stepSize;
            if (currentOpacity < 0)
            {
                currentOpacity = 1.0;
                currentImageIndex = (currentImageIndex + 1) % images.Count;
                SliderBox.Image = images[currentImageIndex];
            }
            else
            {
                SliderBox.Image = ChangeImageOpacity(images[currentImageIndex], currentOpacity);
            }
        }

        private Image ChangeImageOpacity(Image image, double opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = (float)opacity;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                graphics.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            AnimateImageTransition();
        }

    }
}