namespace Roduna_Mekh_Project.InformationWindows
{
    partial class AddPig
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.WeightTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BreedTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GenderTextBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(237, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Вага свині";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(237, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Порода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(237, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 16;
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
            this.DateBirth.Location = new System.Drawing.Point(243, 179);
            this.DateBirth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(490, 45);
            this.DateBirth.TabIndex = 15;
            this.DateBirth.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(237, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Стать свині ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(220, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(544, 47);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Додати інформацію про свиню\r\n";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.button1;
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
            this.WeightTextBox.Location = new System.Drawing.Point(243, 352);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(490, 45);
            this.WeightTextBox.TabIndex = 21;
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
            this.BreedTextBox.Location = new System.Drawing.Point(243, 262);
            this.BreedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(490, 45);
            this.BreedTextBox.TabIndex = 20;
            this.BreedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderTextBox.BorderRadius = 3;
            this.GenderTextBox.DisabledColor = System.Drawing.Color.Gray;
            this.GenderTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderTextBox.ForeColor = System.Drawing.Color.White;
            this.GenderTextBox.Items = new string[] {
        "Кабан",
        "Свиня"};
            this.GenderTextBox.Location = new System.Drawing.Point(243, 85);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.NomalColor = System.Drawing.Color.HotPink;
            this.GenderTextBox.onHoverColor = System.Drawing.Color.Pink;
            this.GenderTextBox.selectedIndex = 1;
            this.GenderTextBox.Size = new System.Drawing.Size(490, 45);
            this.GenderTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(237, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Споживання корму на день";
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
            this.AverageFood.Location = new System.Drawing.Point(243, 439);
            this.AverageFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AverageFood.Name = "AverageFood";
            this.AverageFood.Size = new System.Drawing.Size(490, 45);
            this.AverageFood.TabIndex = 24;
            this.AverageFood.Text = "0";
            this.AverageFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(359, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 76);
            this.button1.TabIndex = 25;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AverageFood);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BreedTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPig";
            this.Text = "AddPig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DateBirth;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WeightTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BreedTextBox;
        private Bunifu.Framework.UI.BunifuDropdown GenderTextBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AverageFood;
        private System.Windows.Forms.Button button1;
    }
}