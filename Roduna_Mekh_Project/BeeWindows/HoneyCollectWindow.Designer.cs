namespace Roduna_Mekh_Project.BeeWindows
{
    partial class HoneyCollectWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackToMainButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(528, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 43);
            this.panel5.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(98, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 43);
            this.panel1.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(507, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 35);
            this.label4.TabIndex = 45;
            this.label4.Text = "• Кількість меду з цього вулику: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(79, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 35);
            this.label3.TabIndex = 44;
            this.label3.Text = "• Найпродуктивніший вулик: ";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Snow;
            this.cartesianChart1.Location = new System.Drawing.Point(98, 159);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(782, 388);
            this.cartesianChart1.TabIndex = 48;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 8;
            this.bunifuElipse2.TargetControl = this.panel5;
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainButton.Image = global::Roduna_Mekh_Project.Properties.Resources.back_arrow_dark;
            this.BackToMainButton.ImageActive = null;
            this.BackToMainButton.Location = new System.Drawing.Point(0, 4);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(44, 30);
            this.BackToMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackToMainButton.TabIndex = 49;
            this.BackToMainButton.TabStop = false;
            this.BackToMainButton.Zoom = 10;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // HoneyCollectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.BackToMainButton);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoneyCollectWindow";
            this.Text = "HoneyCollectWindow";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton BackToMainButton;
    }
}