namespace Roduna_Mekh_Project.EditingWindows
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.RationDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.PigDiseasePicker = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.PregnancyDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GenderTextBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.WeightTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BreedTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.White;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(50, 76);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.HotPink;
            this.ElementID.onHoverColor = System.Drawing.Color.Pink;
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(400, 45);
            this.ElementID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(49, 47);
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
            this.button1.Location = new System.Drawing.Point(375, 489);
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
            this.label6.Location = new System.Drawing.Point(523, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 32);
            this.label6.TabIndex = 52;
            this.label6.Text = "Виберіть раціон";
            // 
            // RationDropDown
            // 
            this.RationDropDown.BackColor = System.Drawing.Color.Transparent;
            this.RationDropDown.BorderRadius = 3;
            this.RationDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.RationDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RationDropDown.ForeColor = System.Drawing.Color.White;
            this.RationDropDown.Items = new string[0];
            this.RationDropDown.Location = new System.Drawing.Point(529, 304);
            this.RationDropDown.Margin = new System.Windows.Forms.Padding(6);
            this.RationDropDown.Name = "RationDropDown";
            this.RationDropDown.NomalColor = System.Drawing.Color.HotPink;
            this.RationDropDown.onHoverColor = System.Drawing.Color.Pink;
            this.RationDropDown.selectedIndex = -1;
            this.RationDropDown.Size = new System.Drawing.Size(400, 47);
            this.RationDropDown.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(555, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Чи хворіє тварина?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(523, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 32);
            this.label8.TabIndex = 49;
            this.label8.Text = "Виберіть захворювання";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.Pink;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.Pink;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(529, 361);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 48;
            // 
            // PigDiseasePicker
            // 
            this.PigDiseasePicker.BackColor = System.Drawing.Color.Transparent;
            this.PigDiseasePicker.BorderRadius = 3;
            this.PigDiseasePicker.DisabledColor = System.Drawing.Color.Gray;
            this.PigDiseasePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PigDiseasePicker.ForeColor = System.Drawing.Color.White;
            this.PigDiseasePicker.Items = new string[0];
            this.PigDiseasePicker.Location = new System.Drawing.Point(529, 420);
            this.PigDiseasePicker.Margin = new System.Windows.Forms.Padding(6);
            this.PigDiseasePicker.Name = "PigDiseasePicker";
            this.PigDiseasePicker.NomalColor = System.Drawing.Color.HotPink;
            this.PigDiseasePicker.onHoverColor = System.Drawing.Color.Pink;
            this.PigDiseasePicker.selectedIndex = -1;
            this.PigDiseasePicker.Size = new System.Drawing.Size(400, 47);
            this.PigDiseasePicker.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(523, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Дата вагітності";
            // 
            // PregnancyDatePicker
            // 
            this.PregnancyDatePicker.BackColor = System.Drawing.Color.HotPink;
            this.PregnancyDatePicker.BorderRadius = 0;
            this.PregnancyDatePicker.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PregnancyDatePicker.ForeColor = System.Drawing.Color.White;
            this.PregnancyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PregnancyDatePicker.FormatCustom = null;
            this.PregnancyDatePicker.Location = new System.Drawing.Point(529, 212);
            this.PregnancyDatePicker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PregnancyDatePicker.Name = "PregnancyDatePicker";
            this.PregnancyDatePicker.Size = new System.Drawing.Size(400, 45);
            this.PregnancyDatePicker.TabIndex = 45;
            this.PregnancyDatePicker.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(523, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Споживання корму на день";
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
            this.AverageFood.Location = new System.Drawing.Point(529, 116);
            this.AverageFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AverageFood.Name = "AverageFood";
            this.AverageFood.Size = new System.Drawing.Size(400, 45);
            this.AverageFood.TabIndex = 44;
            this.AverageFood.Text = "0";
            this.AverageFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.GenderTextBox.Location = new System.Drawing.Point(50, 165);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.NomalColor = System.Drawing.Color.HotPink;
            this.GenderTextBox.onHoverColor = System.Drawing.Color.Pink;
            this.GenderTextBox.selectedIndex = 1;
            this.GenderTextBox.Size = new System.Drawing.Size(400, 45);
            this.GenderTextBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(44, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "Вага ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(44, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Порода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(44, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 37;
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
            this.DateBirth.Location = new System.Drawing.Point(50, 259);
            this.DateBirth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(400, 45);
            this.DateBirth.TabIndex = 36;
            this.DateBirth.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(44, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "Стать ";
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
            this.WeightTextBox.Location = new System.Drawing.Point(50, 432);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(400, 45);
            this.WeightTextBox.TabIndex = 41;
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
            this.BreedTextBox.Location = new System.Drawing.Point(50, 342);
            this.BreedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(400, 45);
            this.BreedTextBox.TabIndex = 40;
            this.BreedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EditPig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RationDropDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.PigDiseasePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PregnancyDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AverageFood);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBirth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BreedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPig";
            this.Text = "EditPig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown RationDropDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuDropdown PigDiseasePicker;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker PregnancyDatePicker;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AverageFood;
        private Bunifu.Framework.UI.BunifuDropdown GenderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DateBirth;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WeightTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BreedTextBox;
    }
}