﻿namespace Roduna_Mekh_Project.EditingWindows
{
    partial class EditPig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GenderDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BreedTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.AverageFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pigDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(207, -2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(604, 47);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Редагувати інформацію про свиню\r\n";
            // 
            // GenderDropDown
            // 
            this.GenderDropDown.BackColor = System.Drawing.Color.Transparent;
            this.GenderDropDown.BorderRadius = 3;
            this.GenderDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.GenderDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderDropDown.ForeColor = System.Drawing.Color.White;
            this.GenderDropDown.Items = new string[] {
        "Кабан",
        "Свиня"};
            this.GenderDropDown.Location = new System.Drawing.Point(135, 396);
            this.GenderDropDown.Margin = new System.Windows.Forms.Padding(6);
            this.GenderDropDown.Name = "GenderDropDown";
            this.GenderDropDown.NomalColor = System.Drawing.Color.HotPink;
            this.GenderDropDown.onHoverColor = System.Drawing.Color.Pink;
            this.GenderDropDown.selectedIndex = 0;
            this.GenderDropDown.Size = new System.Drawing.Size(243, 45);
            this.GenderDropDown.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(412, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Вага свині";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(412, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Порода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(129, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата народження";
            // 
            // DateBirth
            // 
            this.DateBirth.BackColor = System.Drawing.Color.HotPink;
            this.DateBirth.BorderRadius = 0;
            this.DateBirth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBirth.ForeColor = System.Drawing.Color.White;
            this.DateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBirth.FormatCustom = null;
            this.DateBirth.Location = new System.Drawing.Point(135, 495);
            this.DateBirth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(243, 45);
            this.DateBirth.TabIndex = 24;
            this.DateBirth.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(129, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Стать";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.WeightTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WeightTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeightTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.WeightTextBox.HintText = "";
            this.WeightTextBox.isPassword = false;
            this.WeightTextBox.LineFocusedColor = System.Drawing.Color.Pink;
            this.WeightTextBox.LineIdleColor = System.Drawing.Color.HotPink;
            this.WeightTextBox.LineMouseHoverColor = System.Drawing.Color.Pink;
            this.WeightTextBox.LineThickness = 4;
            this.WeightTextBox.Location = new System.Drawing.Point(418, 495);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(243, 45);
            this.WeightTextBox.TabIndex = 29;
            this.WeightTextBox.Text = "0";
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BreedTextBox
            // 
            this.BreedTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.BreedTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BreedTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BreedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BreedTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.BreedTextBox.HintText = "";
            this.BreedTextBox.isPassword = false;
            this.BreedTextBox.LineFocusedColor = System.Drawing.Color.Pink;
            this.BreedTextBox.LineIdleColor = System.Drawing.Color.HotPink;
            this.BreedTextBox.LineMouseHoverColor = System.Drawing.Color.Pink;
            this.BreedTextBox.LineThickness = 4;
            this.BreedTextBox.Location = new System.Drawing.Point(418, 396);
            this.BreedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(243, 45);
            this.BreedTextBox.TabIndex = 28;
            this.BreedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.White;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(15, 396);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.HotPink;
            this.ElementID.onHoverColor = System.Drawing.Color.Pink;
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(105, 45);
            this.ElementID.TabIndex = 32;
            this.ElementID.onItemSelected += new System.EventHandler(this.ElementID_onItemSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(735, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 76);
            this.button1.TabIndex = 34;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.pigDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.button1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(666, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Споживання корму за день";
            // 
            // AverageFood
            // 
            this.AverageFood.BackColor = System.Drawing.Color.Gainsboro;
            this.AverageFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AverageFood.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AverageFood.HintForeColor = System.Drawing.Color.Empty;
            this.AverageFood.HintText = "";
            this.AverageFood.isPassword = false;
            this.AverageFood.LineFocusedColor = System.Drawing.Color.Pink;
            this.AverageFood.LineIdleColor = System.Drawing.Color.HotPink;
            this.AverageFood.LineMouseHoverColor = System.Drawing.Color.Pink;
            this.AverageFood.LineThickness = 4;
            this.AverageFood.Location = new System.Drawing.Point(686, 396);
            this.AverageFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AverageFood.Name = "AverageFood";
            this.AverageFood.Size = new System.Drawing.Size(243, 45);
            this.AverageFood.TabIndex = 37;
            this.AverageFood.Text = "0";
            this.AverageFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Споживання корму за день";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Вага";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Порода";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата народження";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Стать";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // pigDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pigDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pigDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pigDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.pigDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pigDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pigDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pigDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pigDataGrid.ColumnHeadersHeight = 50;
            this.pigDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pigDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.pigDataGrid.DoubleBuffered = true;
            this.pigDataGrid.EnableHeadersVisualStyles = false;
            this.pigDataGrid.HeaderBgColor = System.Drawing.Color.HotPink;
            this.pigDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.pigDataGrid.Location = new System.Drawing.Point(51, 48);
            this.pigDataGrid.Name = "pigDataGrid";
            this.pigDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pigDataGrid.RowHeadersVisible = false;
            this.pigDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pigDataGrid.Size = new System.Drawing.Size(891, 298);
            this.pigDataGrid.TabIndex = 35;
            // 
            // EditPig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AverageFood);
            this.Controls.Add(this.pigDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenderDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BreedTextBox);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPig";
            this.Text = "EditPig";
            ((System.ComponentModel.ISupportInitialize)(this.pigDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown GenderDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DateBirth;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WeightTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BreedTextBox;
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AverageFood;
        private Bunifu.Framework.UI.BunifuCustomDataGrid pigDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}