﻿namespace Roduna_Mekh_Project
{
    partial class PigForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pigDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nav4 = new System.Windows.Forms.Label();
            this.nav3 = new System.Windows.Forms.Label();
            this.nav2 = new System.Windows.Forms.Label();
            this.Nav1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(306, 218);
            this.panel2.MaximumSize = new System.Drawing.Size(200, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 0);
            this.panel2.TabIndex = 26;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton3.Location = new System.Drawing.Point(3, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Статтю";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton2.Location = new System.Drawing.Point(3, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Породою";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton1.Location = new System.Drawing.Point(3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Пошук за ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Roduna_Mekh_Project.Properties.Resources.arrow_down_sign_to_navigate;
            this.button2.Location = new System.Drawing.Point(381, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 33);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SearchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextBox.Location = new System.Drawing.Point(436, 185);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(371, 33);
            this.SearchTextBox.TabIndex = 24;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.HotPink;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(813, 185);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 33);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pigDataGrid
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pigDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.pigDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pigDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.pigDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pigDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pigDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pigDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.pigDataGrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pigDataGrid.DefaultCellStyle = dataGridViewCellStyle36;
            this.pigDataGrid.DoubleBuffered = true;
            this.pigDataGrid.EnableHeadersVisualStyles = false;
            this.pigDataGrid.HeaderBgColor = System.Drawing.Color.HotPink;
            this.pigDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.pigDataGrid.Location = new System.Drawing.Point(12, 224);
            this.pigDataGrid.Name = "pigDataGrid";
            this.pigDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pigDataGrid.RowHeadersVisible = false;
            this.pigDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pigDataGrid.Size = new System.Drawing.Size(950, 298);
            this.pigDataGrid.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.pigDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.SearchTextBox;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.SearchButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 20;
            this.bunifuElipse7.TargetControl = this;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Roduna_Mekh_Project.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 35);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nav4
            // 
            this.nav4.AutoSize = true;
            this.nav4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.nav4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nav4.Location = new System.Drawing.Point(623, 25);
            this.nav4.Name = "nav4";
            this.nav4.Size = new System.Drawing.Size(169, 28);
            this.nav4.TabIndex = 46;
            this.nav4.Text = "Доходи/Витрати";
            this.nav4.Click += new System.EventHandler(this.nav4_Click);
            this.nav4.MouseLeave += new System.EventHandler(this.nav4_MouseLeave);
            this.nav4.MouseHover += new System.EventHandler(this.nav4_MouseHover);
            // 
            // nav3
            // 
            this.nav3.AutoSize = true;
            this.nav3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.nav3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nav3.Location = new System.Drawing.Point(456, 25);
            this.nav3.Name = "nav3";
            this.nav3.Size = new System.Drawing.Size(145, 28);
            this.nav3.TabIndex = 45;
            this.nav3.Text = "Розмноження";
            this.nav3.Click += new System.EventHandler(this.nav3_Click);
            this.nav3.MouseLeave += new System.EventHandler(this.nav3_MouseLeave);
            this.nav3.MouseHover += new System.EventHandler(this.nav3_MouseHover);
            // 
            // nav2
            // 
            this.nav2.AutoSize = true;
            this.nav2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.nav2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nav2.Location = new System.Drawing.Point(281, 25);
            this.nav2.Name = "nav2";
            this.nav2.Size = new System.Drawing.Size(151, 28);
            this.nav2.TabIndex = 44;
            this.nav2.Text = "Захворювання";
            this.nav2.Click += new System.EventHandler(this.nav2_Click);
            this.nav2.MouseLeave += new System.EventHandler(this.nav2_MouseLeave);
            this.nav2.MouseHover += new System.EventHandler(this.nav2_MouseHover);
            // 
            // Nav1
            // 
            this.Nav1.AutoSize = true;
            this.Nav1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.Nav1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nav1.Location = new System.Drawing.Point(166, 25);
            this.Nav1.Name = "Nav1";
            this.Nav1.Size = new System.Drawing.Size(86, 28);
            this.Nav1.TabIndex = 43;
            this.Nav1.Text = "Раціони";
            this.Nav1.Click += new System.EventHandler(this.Nav1_Click);
            this.Nav1.MouseLeave += new System.EventHandler(this.Nav1_MouseLeave);
            this.Nav1.MouseHover += new System.EventHandler(this.Nav1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(118, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 3);
            this.panel1.TabIndex = 42;
            // 
            // PigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 538);
            this.Controls.Add(this.nav4);
            this.Controls.Add(this.nav3);
            this.Controls.Add(this.nav2);
            this.Controls.Add(this.Nav1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.pigDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PigForm";
            this.Text = "PigForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid pigDataGrid;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nav4;
        private System.Windows.Forms.Label nav3;
        private System.Windows.Forms.Label nav2;
        private System.Windows.Forms.Label Nav1;
        private System.Windows.Forms.Panel panel1;
    }
}