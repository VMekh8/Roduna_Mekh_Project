﻿namespace Roduna_Mekh_Project.InformationWindows
{
    partial class AddGrain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateSowing = new Bunifu.Framework.UI.BunifuDatepicker();
            this.NameField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.areaField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CultureType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FuelConsumption = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductivityTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceForTon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(177, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати інформацію про поле та агрокультуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва поля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Площа поля (Га)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип агрокультури";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(497, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата посадки";
            // 
            // dateSowing
            // 
            this.dateSowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.dateSowing.BorderRadius = 0;
            this.dateSowing.ForeColor = System.Drawing.Color.White;
            this.dateSowing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSowing.FormatCustom = null;
            this.dateSowing.Location = new System.Drawing.Point(503, 176);
            this.dateSowing.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.dateSowing.Name = "dateSowing";
            this.dateSowing.Size = new System.Drawing.Size(450, 40);
            this.dateSowing.TabIndex = 5;
            this.dateSowing.Value = new System.DateTime(2023, 8, 19, 19, 0, 42, 37);
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
            this.NameField.Location = new System.Drawing.Point(15, 128);
            this.NameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(450, 40);
            this.NameField.TabIndex = 6;
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.areaField.Location = new System.Drawing.Point(15, 220);
            this.areaField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.areaField.Name = "areaField";
            this.areaField.Size = new System.Drawing.Size(450, 40);
            this.areaField.TabIndex = 7;
            this.areaField.Text = "0,00";
            this.areaField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.CultureType.Location = new System.Drawing.Point(15, 296);
            this.CultureType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CultureType.Name = "CultureType";
            this.CultureType.Size = new System.Drawing.Size(450, 40);
            this.CultureType.TabIndex = 8;
            this.CultureType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(384, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.button1;
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
            this.FuelConsumption.Location = new System.Drawing.Point(503, 262);
            this.FuelConsumption.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FuelConsumption.Name = "FuelConsumption";
            this.FuelConsumption.Size = new System.Drawing.Size(450, 40);
            this.FuelConsumption.TabIndex = 11;
            this.FuelConsumption.Text = "0";
            this.FuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(496, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Витрата палива на 1 Га";
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
            this.ProductivityTextBox.Location = new System.Drawing.Point(503, 344);
            this.ProductivityTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductivityTextBox.Name = "ProductivityTextBox";
            this.ProductivityTextBox.Size = new System.Drawing.Size(450, 40);
            this.ProductivityTextBox.TabIndex = 13;
            this.ProductivityTextBox.Text = "0,00";
            this.ProductivityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(497, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Врожайність на Га";
            // 
            // PriceForTon
            // 
            this.PriceForTon.BackColor = System.Drawing.Color.Gainsboro;
            this.PriceForTon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceForTon.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.PriceForTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceForTon.HintForeColor = System.Drawing.Color.Empty;
            this.PriceForTon.HintText = "";
            this.PriceForTon.isPassword = false;
            this.PriceForTon.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.PriceForTon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.PriceForTon.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.PriceForTon.LineThickness = 4;
            this.PriceForTon.Location = new System.Drawing.Point(15, 384);
            this.PriceForTon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PriceForTon.Name = "PriceForTon";
            this.PriceForTon.Size = new System.Drawing.Size(450, 40);
            this.PriceForTon.TabIndex = 15;
            this.PriceForTon.Text = "0,00";
            this.PriceForTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(9, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ціна зерна";
            // 
            // AddGrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.PriceForTon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductivityTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FuelConsumption);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CultureType);
            this.Controls.Add(this.areaField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.dateSowing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGrain";
            this.Text = "AddGrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker dateSowing;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox areaField;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CultureType;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FuelConsumption;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductivityTextBox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceForTon;
        private System.Windows.Forms.Label label8;
    }
}