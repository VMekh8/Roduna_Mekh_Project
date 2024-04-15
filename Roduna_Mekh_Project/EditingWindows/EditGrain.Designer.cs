namespace Roduna_Mekh_Project.EditingWindows
{
    partial class EditGrain
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
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.NameCultureTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductivityTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.FuelConsumption = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.CultureType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.areaField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateSowing = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.label10 = new System.Windows.Forms.Label();
            this.PricePerKgField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(108, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(777, 45);
            this.label6.TabIndex = 34;
            this.label6.Text = "Редагувати інформацію про поле та агрокультуру";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(358, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 74);
            this.button1.TabIndex = 43;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameCultureTextBox
            // 
            this.NameCultureTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.NameCultureTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameCultureTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCultureTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameCultureTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.NameCultureTextBox.HintText = "";
            this.NameCultureTextBox.isPassword = false;
            this.NameCultureTextBox.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.NameCultureTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.NameCultureTextBox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.NameCultureTextBox.LineThickness = 4;
            this.NameCultureTextBox.Location = new System.Drawing.Point(516, 144);
            this.NameCultureTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameCultureTextBox.Name = "NameCultureTextBox";
            this.NameCultureTextBox.Size = new System.Drawing.Size(450, 40);
            this.NameCultureTextBox.TabIndex = 51;
            this.NameCultureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(511, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 36);
            this.label9.TabIndex = 50;
            this.label9.Text = "Назва культури";
            // 
            // ProductivityTextBox
            // 
            this.ProductivityTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ProductivityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductivityTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ProductivityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductivityTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ProductivityTextBox.HintText = "";
            this.ProductivityTextBox.isPassword = false;
            this.ProductivityTextBox.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.ProductivityTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.ProductivityTextBox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.ProductivityTextBox.LineThickness = 4;
            this.ProductivityTextBox.Location = new System.Drawing.Point(517, 400);
            this.ProductivityTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductivityTextBox.Name = "ProductivityTextBox";
            this.ProductivityTextBox.Size = new System.Drawing.Size(450, 40);
            this.ProductivityTextBox.TabIndex = 47;
            this.ProductivityTextBox.Text = "0,00";
            this.ProductivityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(511, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 36);
            this.label7.TabIndex = 46;
            this.label7.Text = "Врожайність на Га (т)";
            // 
            // FuelConsumption
            // 
            this.FuelConsumption.BackColor = System.Drawing.Color.Gainsboro;
            this.FuelConsumption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FuelConsumption.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FuelConsumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FuelConsumption.HintForeColor = System.Drawing.Color.Empty;
            this.FuelConsumption.HintText = "";
            this.FuelConsumption.isPassword = false;
            this.FuelConsumption.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.FuelConsumption.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.FuelConsumption.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.FuelConsumption.LineThickness = 4;
            this.FuelConsumption.Location = new System.Drawing.Point(517, 318);
            this.FuelConsumption.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FuelConsumption.Name = "FuelConsumption";
            this.FuelConsumption.Size = new System.Drawing.Size(450, 40);
            this.FuelConsumption.TabIndex = 45;
            this.FuelConsumption.Text = "0";
            this.FuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(510, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Витрата палива на 1 Га";
            // 
            // CultureType
            // 
            this.CultureType.BackColor = System.Drawing.Color.Gainsboro;
            this.CultureType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CultureType.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CultureType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CultureType.HintForeColor = System.Drawing.Color.Empty;
            this.CultureType.HintText = "";
            this.CultureType.isPassword = false;
            this.CultureType.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.CultureType.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.CultureType.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.CultureType.LineThickness = 4;
            this.CultureType.Location = new System.Drawing.Point(15, 354);
            this.CultureType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CultureType.Name = "CultureType";
            this.CultureType.Size = new System.Drawing.Size(450, 40);
            this.CultureType.TabIndex = 42;
            this.CultureType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // areaField
            // 
            this.areaField.BackColor = System.Drawing.Color.Gainsboro;
            this.areaField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.areaField.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.areaField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areaField.HintForeColor = System.Drawing.Color.Empty;
            this.areaField.HintText = "";
            this.areaField.isPassword = false;
            this.areaField.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.areaField.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.areaField.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.areaField.LineThickness = 4;
            this.areaField.Location = new System.Drawing.Point(15, 278);
            this.areaField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.areaField.Name = "areaField";
            this.areaField.Size = new System.Drawing.Size(450, 40);
            this.areaField.TabIndex = 41;
            this.areaField.Text = "0,00";
            this.areaField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.NameField.LineFocusedColor = System.Drawing.Color.Green;
            this.NameField.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.NameField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.NameField.LineThickness = 4;
            this.NameField.Location = new System.Drawing.Point(15, 186);
            this.NameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(450, 40);
            this.NameField.TabIndex = 40;
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateSowing
            // 
            this.dateSowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dateSowing.BorderRadius = 0;
            this.dateSowing.ForeColor = System.Drawing.Color.White;
            this.dateSowing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSowing.FormatCustom = null;
            this.dateSowing.Location = new System.Drawing.Point(517, 232);
            this.dateSowing.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.dateSowing.Name = "dateSowing";
            this.dateSowing.Size = new System.Drawing.Size(450, 40);
            this.dateSowing.TabIndex = 39;
            this.dateSowing.Value = new System.DateTime(2023, 8, 19, 19, 0, 42, 37);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(511, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 36);
            this.label5.TabIndex = 38;
            this.label5.Text = "Дата посадки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "Тип агрокультури";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 36;
            this.label3.Text = "Площа поля (Га)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "Назва поля";
            // 
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.White;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(15, 102);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.ElementID.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(450, 40);
            this.ElementID.TabIndex = 52;
            this.ElementID.onItemSelected += new System.EventHandler(this.ElementID_onItemSelected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 36);
            this.label10.TabIndex = 53;
            this.label10.Text = "ID";
            // 
            // PricePerKgField
            // 
            this.PricePerKgField.BackColor = System.Drawing.Color.Gainsboro;
            this.PricePerKgField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PricePerKgField.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PricePerKgField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PricePerKgField.HintForeColor = System.Drawing.Color.Empty;
            this.PricePerKgField.HintText = "";
            this.PricePerKgField.isPassword = false;
            this.PricePerKgField.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.PricePerKgField.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.PricePerKgField.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.PricePerKgField.LineThickness = 4;
            this.PricePerKgField.Location = new System.Drawing.Point(15, 432);
            this.PricePerKgField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PricePerKgField.Name = "PricePerKgField";
            this.PricePerKgField.Size = new System.Drawing.Size(450, 40);
            this.PricePerKgField.TabIndex = 55;
            this.PricePerKgField.Text = "0,00";
            this.PricePerKgField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(9, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 36);
            this.label8.TabIndex = 54;
            this.label8.Text = "Ціна за кг:";
            // 
            // EditGrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.PricePerKgField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.NameCultureTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProductivityTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FuelConsumption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CultureType);
            this.Controls.Add(this.areaField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.dateSowing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditGrain";
            this.Text = "EditGrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameCultureTextBox;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductivityTextBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FuelConsumption;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CultureType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox areaField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameField;
        private Bunifu.Framework.UI.BunifuDatepicker dateSowing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PricePerKgField;
        private System.Windows.Forms.Label label8;
    }
}