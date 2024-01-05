namespace Roduna_Mekh_Project.EditingWindows
{
    partial class EditCow
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
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GenderDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.DateBirthPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.AverageFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.WeightTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BreedTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CowDiseasePicker = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.PregnancyDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MilkaverageTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RationDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.White;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(47, 81);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.ElementID.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(400, 40);
            this.ElementID.TabIndex = 22;
            this.ElementID.onItemSelected += new System.EventHandler(this.ElementID_onItemSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(41, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(617, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 76);
            this.button1.TabIndex = 23;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(197, -1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(611, 47);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Редагувати інформацію про худобу";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.button1;
            // 
            // GenderDropDown
            // 
            this.GenderDropDown.BackColor = System.Drawing.Color.Transparent;
            this.GenderDropDown.BorderRadius = 3;
            this.GenderDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.GenderDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderDropDown.ForeColor = System.Drawing.Color.White;
            this.GenderDropDown.Items = new string[] {
        "Бик ",
        "Корова"};
            this.GenderDropDown.Location = new System.Drawing.Point(46, 160);
            this.GenderDropDown.Margin = new System.Windows.Forms.Padding(6);
            this.GenderDropDown.Name = "GenderDropDown";
            this.GenderDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.GenderDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.GenderDropDown.selectedIndex = 1;
            this.GenderDropDown.Size = new System.Drawing.Size(400, 40);
            this.GenderDropDown.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(40, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Дата народження";
            // 
            // DateBirthPicker
            // 
            this.DateBirthPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.DateBirthPicker.BorderRadius = 0;
            this.DateBirthPicker.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBirthPicker.ForeColor = System.Drawing.Color.White;
            this.DateBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBirthPicker.FormatCustom = null;
            this.DateBirthPicker.Location = new System.Drawing.Point(46, 247);
            this.DateBirthPicker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DateBirthPicker.Name = "DateBirthPicker";
            this.DateBirthPicker.Size = new System.Drawing.Size(400, 40);
            this.DateBirthPicker.TabIndex = 30;
            this.DateBirthPicker.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(40, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Стать худоби ";
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
            this.AverageFood.LineFocusedColor = System.Drawing.Color.Blue;
            this.AverageFood.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.AverageFood.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AverageFood.LineThickness = 4;
            this.AverageFood.Location = new System.Drawing.Point(550, 107);
            this.AverageFood.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AverageFood.Name = "AverageFood";
            this.AverageFood.Size = new System.Drawing.Size(400, 40);
            this.AverageFood.TabIndex = 38;
            this.AverageFood.Text = "0";
            this.AverageFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(544, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Споживання корму на день";
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
            this.WeightTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.WeightTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.WeightTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.WeightTextBox.LineThickness = 4;
            this.WeightTextBox.Location = new System.Drawing.Point(46, 421);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(400, 40);
            this.WeightTextBox.TabIndex = 36;
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
            this.BreedTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.BreedTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.BreedTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.BreedTextBox.LineThickness = 4;
            this.BreedTextBox.Location = new System.Drawing.Point(46, 332);
            this.BreedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(400, 40);
            this.BreedTextBox.TabIndex = 35;
            this.BreedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(40, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Вага худоби";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(40, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Порода";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(576, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Чи хворіє тварина?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(544, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Виберіть захворювання";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(550, 345);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 44;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // CowDiseasePicker
            // 
            this.CowDiseasePicker.BackColor = System.Drawing.Color.Transparent;
            this.CowDiseasePicker.BorderRadius = 3;
            this.CowDiseasePicker.DisabledColor = System.Drawing.Color.Gray;
            this.CowDiseasePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CowDiseasePicker.ForeColor = System.Drawing.Color.White;
            this.CowDiseasePicker.Items = new string[0];
            this.CowDiseasePicker.Location = new System.Drawing.Point(550, 412);
            this.CowDiseasePicker.Margin = new System.Windows.Forms.Padding(6);
            this.CowDiseasePicker.Name = "CowDiseasePicker";
            this.CowDiseasePicker.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.CowDiseasePicker.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.CowDiseasePicker.selectedIndex = -1;
            this.CowDiseasePicker.Size = new System.Drawing.Size(400, 40);
            this.CowDiseasePicker.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(544, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Дата вагітності";
            // 
            // PregnancyDatePicker
            // 
            this.PregnancyDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.PregnancyDatePicker.BorderRadius = 0;
            this.PregnancyDatePicker.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PregnancyDatePicker.ForeColor = System.Drawing.Color.White;
            this.PregnancyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PregnancyDatePicker.FormatCustom = null;
            this.PregnancyDatePicker.Location = new System.Drawing.Point(550, 193);
            this.PregnancyDatePicker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PregnancyDatePicker.Name = "PregnancyDatePicker";
            this.PregnancyDatePicker.Size = new System.Drawing.Size(400, 40);
            this.PregnancyDatePicker.TabIndex = 41;
            this.PregnancyDatePicker.Value = new System.DateTime(2023, 8, 19, 18, 12, 12, 769);
            // 
            // MilkaverageTextBox
            // 
            this.MilkaverageTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MilkaverageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MilkaverageTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MilkaverageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MilkaverageTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.MilkaverageTextBox.HintText = "";
            this.MilkaverageTextBox.isPassword = false;
            this.MilkaverageTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.MilkaverageTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.MilkaverageTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MilkaverageTextBox.LineThickness = 4;
            this.MilkaverageTextBox.Location = new System.Drawing.Point(550, 281);
            this.MilkaverageTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MilkaverageTextBox.Name = "MilkaverageTextBox";
            this.MilkaverageTextBox.Size = new System.Drawing.Size(400, 40);
            this.MilkaverageTextBox.TabIndex = 40;
            this.MilkaverageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(544, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 28);
            this.label10.TabIndex = 39;
            this.label10.Text = "Кількість молока в день";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(41, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 28);
            this.label11.TabIndex = 48;
            this.label11.Text = "Виберіть раціон для тварини";
            // 
            // RationDropDown
            // 
            this.RationDropDown.BackColor = System.Drawing.Color.Transparent;
            this.RationDropDown.BorderRadius = 3;
            this.RationDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.RationDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RationDropDown.ForeColor = System.Drawing.Color.White;
            this.RationDropDown.Items = new string[0];
            this.RationDropDown.Location = new System.Drawing.Point(47, 508);
            this.RationDropDown.Margin = new System.Windows.Forms.Padding(6);
            this.RationDropDown.Name = "RationDropDown";
            this.RationDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
            this.RationDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.RationDropDown.selectedIndex = -1;
            this.RationDropDown.Size = new System.Drawing.Size(400, 40);
            this.RationDropDown.TabIndex = 47;
            // 
            // EditCow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RationDropDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.CowDiseasePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PregnancyDatePicker);
            this.Controls.Add(this.MilkaverageTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AverageFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.BreedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenderDropDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateBirthPicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCow";
            this.Text = "EditCow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDropdown GenderDropDown;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker DateBirthPicker;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AverageFood;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WeightTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BreedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuDropdown CowDiseasePicker;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker PregnancyDatePicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MilkaverageTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDropdown RationDropDown;
    }
}