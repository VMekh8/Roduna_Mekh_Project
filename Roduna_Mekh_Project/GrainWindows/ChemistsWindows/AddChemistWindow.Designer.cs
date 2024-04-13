namespace Roduna_Mekh_Project.GrainWindows.ChemistsWindows
{
    partial class AddChemistWindow
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
            this.BackToMainButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.NameField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CultureField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PriceField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainButton.Image = global::Roduna_Mekh_Project.Properties.Resources.back_arrow_dark;
            this.BackToMainButton.ImageActive = null;
            this.BackToMainButton.Location = new System.Drawing.Point(0, 3);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(44, 30);
            this.BackToMainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackToMainButton.TabIndex = 52;
            this.BackToMainButton.TabStop = false;
            this.BackToMainButton.Zoom = 10;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.Color.Gainsboro;
            this.NameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameField.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameField.HintForeColor = System.Drawing.Color.Empty;
            this.NameField.HintText = "";
            this.NameField.isPassword = false;
            this.NameField.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.NameField.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.NameField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.NameField.LineThickness = 4;
            this.NameField.Location = new System.Drawing.Point(275, 114);
            this.NameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(450, 40);
            this.NameField.TabIndex = 54;
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(269, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 36);
            this.label2.TabIndex = 53;
            this.label2.Text = "Назва препарату";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(269, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Тип препарату";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(269, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "Для яких культур препарат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(269, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 36);
            this.label4.TabIndex = 59;
            this.label4.Text = "Вартість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(267, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(522, 45);
            this.label6.TabIndex = 63;
            this.label6.Text = "Додати інформацію про хімікати";
            // 
            // TypeField
            // 
            this.TypeField.BackColor = System.Drawing.Color.Gainsboro;
            this.TypeField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeField.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeField.HintForeColor = System.Drawing.Color.Empty;
            this.TypeField.HintText = "";
            this.TypeField.isPassword = false;
            this.TypeField.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.TypeField.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.TypeField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TypeField.LineThickness = 4;
            this.TypeField.Location = new System.Drawing.Point(275, 209);
            this.TypeField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(450, 40);
            this.TypeField.TabIndex = 64;
            this.TypeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CultureField
            // 
            this.CultureField.BackColor = System.Drawing.Color.Gainsboro;
            this.CultureField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CultureField.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CultureField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CultureField.HintForeColor = System.Drawing.Color.Empty;
            this.CultureField.HintText = "";
            this.CultureField.isPassword = false;
            this.CultureField.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.CultureField.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.CultureField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.CultureField.LineThickness = 4;
            this.CultureField.Location = new System.Drawing.Point(275, 302);
            this.CultureField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CultureField.Name = "CultureField";
            this.CultureField.Size = new System.Drawing.Size(450, 40);
            this.CultureField.TabIndex = 65;
            this.CultureField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PriceField
            // 
            this.PriceField.BackColor = System.Drawing.Color.Gainsboro;
            this.PriceField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceField.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceField.HintForeColor = System.Drawing.Color.Empty;
            this.PriceField.HintText = "";
            this.PriceField.isPassword = false;
            this.PriceField.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.PriceField.LineIdleColor = System.Drawing.Color.MediumAquamarine;
            this.PriceField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.PriceField.LineThickness = 4;
            this.PriceField.Location = new System.Drawing.Point(275, 394);
            this.PriceField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(450, 40);
            this.PriceField.TabIndex = 66;
            this.PriceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(353, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 74);
            this.button1.TabIndex = 67;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SendDataToDB);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // AddChemistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.CultureField);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackToMainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddChemistWindow";
            this.Text = "AddChemistWindow";
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton BackToMainButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TypeField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CultureField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceField;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}