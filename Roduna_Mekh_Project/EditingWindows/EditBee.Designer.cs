namespace Roduna_Mekh_Project.EditingWindows
{
    partial class EditBee
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
            this.label2 = new System.Windows.Forms.Label();
            this.beeDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HiveState = new Bunifu.Framework.UI.BunifuDropdown();
            this.PowerOfFamily = new Bunifu.Framework.UI.BunifuDropdown();
            this.InstallDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HoneyAverage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NumberOfFamily = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DateCollectHoney = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.beeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(341, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Редагування вулику";
            // 
            // beeDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.beeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.beeDataGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.beeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beeDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.beeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.beeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.beeDataGrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.beeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.beeDataGrid.DoubleBuffered = true;
            this.beeDataGrid.EnableHeadersVisualStyles = false;
            this.beeDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.beeDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.beeDataGrid.Location = new System.Drawing.Point(42, 47);
            this.beeDataGrid.Name = "beeDataGrid";
            this.beeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.beeDataGrid.RowHeadersVisible = false;
            this.beeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.beeDataGrid.Size = new System.Drawing.Size(891, 298);
            this.beeDataGrid.TabIndex = 16;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.beeDataGrid;
            // 
            // HiveState
            // 
            this.HiveState.BackColor = System.Drawing.Color.Transparent;
            this.HiveState.BorderRadius = 3;
            this.HiveState.DisabledColor = System.Drawing.Color.Gray;
            this.HiveState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HiveState.ForeColor = System.Drawing.Color.White;
            this.HiveState.Items = new string[] {
        "100",
        "90",
        "80",
        "70",
        "60",
        "50",
        "40",
        "30",
        "20",
        "10",
        "0"};
            this.HiveState.Location = new System.Drawing.Point(405, 378);
            this.HiveState.Margin = new System.Windows.Forms.Padding(6);
            this.HiveState.Name = "HiveState";
            this.HiveState.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.HiveState.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.HiveState.selectedIndex = 0;
            this.HiveState.Size = new System.Drawing.Size(242, 42);
            this.HiveState.TabIndex = 26;
            // 
            // PowerOfFamily
            // 
            this.PowerOfFamily.BackColor = System.Drawing.Color.Transparent;
            this.PowerOfFamily.BorderRadius = 3;
            this.PowerOfFamily.DisabledColor = System.Drawing.Color.Gray;
            this.PowerOfFamily.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerOfFamily.ForeColor = System.Drawing.Color.White;
            this.PowerOfFamily.Items = new string[] {
        "Хороший",
        "Переважно хороший",
        "Нейтральний",
        "Переважно нейтральний",
        "Поганий",
        "Переважно поганий"};
            this.PowerOfFamily.Location = new System.Drawing.Point(123, 453);
            this.PowerOfFamily.Margin = new System.Windows.Forms.Padding(6);
            this.PowerOfFamily.Name = "PowerOfFamily";
            this.PowerOfFamily.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.PowerOfFamily.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.PowerOfFamily.selectedIndex = 0;
            this.PowerOfFamily.Size = new System.Drawing.Size(242, 42);
            this.PowerOfFamily.TabIndex = 25;
            // 
            // InstallDate
            // 
            this.InstallDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.InstallDate.BorderRadius = 0;
            this.InstallDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallDate.ForeColor = System.Drawing.Color.White;
            this.InstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.InstallDate.FormatCustom = null;
            this.InstallDate.Location = new System.Drawing.Point(691, 378);
            this.InstallDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.InstallDate.Name = "InstallDate";
            this.InstallDate.Size = new System.Drawing.Size(242, 42);
            this.InstallDate.TabIndex = 24;
            this.InstallDate.Value = new System.DateTime(2023, 8, 19, 14, 13, 22, 445);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(686, 348);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(250, 25);
            this.bunifuCustomLabel5.TabIndex = 23;
            this.bunifuCustomLabel5.Text = "Дата встановлення вулика";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(400, 426);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(220, 25);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Середня кількість меду";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(400, 348);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(153, 25);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Стан вулика (%)";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(119, 426);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(107, 25);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Стан сімей";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(118, 348);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 25);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Кількість сімей";
            // 
            // HoneyAverage
            // 
            this.HoneyAverage.BackColor = System.Drawing.Color.Gainsboro;
            this.HoneyAverage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HoneyAverage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoneyAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HoneyAverage.HintForeColor = System.Drawing.Color.Empty;
            this.HoneyAverage.HintText = "";
            this.HoneyAverage.isPassword = false;
            this.HoneyAverage.LineFocusedColor = System.Drawing.Color.Gold;
            this.HoneyAverage.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.HoneyAverage.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.HoneyAverage.LineThickness = 4;
            this.HoneyAverage.Location = new System.Drawing.Point(405, 453);
            this.HoneyAverage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HoneyAverage.Name = "HoneyAverage";
            this.HoneyAverage.Size = new System.Drawing.Size(242, 42);
            this.HoneyAverage.TabIndex = 18;
            this.HoneyAverage.Text = "0";
            this.HoneyAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NumberOfFamily
            // 
            this.NumberOfFamily.BackColor = System.Drawing.Color.Gainsboro;
            this.NumberOfFamily.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberOfFamily.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NumberOfFamily.HintForeColor = System.Drawing.Color.Empty;
            this.NumberOfFamily.HintText = "";
            this.NumberOfFamily.isPassword = false;
            this.NumberOfFamily.LineFocusedColor = System.Drawing.Color.Gold;
            this.NumberOfFamily.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.NumberOfFamily.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.NumberOfFamily.LineThickness = 4;
            this.NumberOfFamily.Location = new System.Drawing.Point(121, 378);
            this.NumberOfFamily.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NumberOfFamily.Name = "NumberOfFamily";
            this.NumberOfFamily.Size = new System.Drawing.Size(242, 42);
            this.NumberOfFamily.TabIndex = 17;
            this.NumberOfFamily.Text = "0";
            this.NumberOfFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(825, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 68);
            this.button1.TabIndex = 27;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.button1;
            // 
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.White;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(15, 378);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.ElementID.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(94, 42);
            this.ElementID.TabIndex = 29;
            this.ElementID.onItemSelected += new System.EventHandler(this.ElementID_onItemSelected);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(37, 349);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(32, 25);
            this.bunifuCustomLabel6.TabIndex = 28;
            this.bunifuCustomLabel6.Text = "ID";
            // 
            // DateCollectHoney
            // 
            this.DateCollectHoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(162)))), ((int)(((byte)(6)))));
            this.DateCollectHoney.BorderRadius = 0;
            this.DateCollectHoney.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateCollectHoney.ForeColor = System.Drawing.Color.White;
            this.DateCollectHoney.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateCollectHoney.FormatCustom = null;
            this.DateCollectHoney.Location = new System.Drawing.Point(691, 453);
            this.DateCollectHoney.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DateCollectHoney.Name = "DateCollectHoney";
            this.DateCollectHoney.Size = new System.Drawing.Size(242, 42);
            this.DateCollectHoney.TabIndex = 31;
            this.DateCollectHoney.Value = new System.DateTime(2023, 8, 19, 14, 13, 22, 445);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(686, 423);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(259, 25);
            this.bunifuCustomLabel7.TabIndex = 30;
            this.bunifuCustomLabel7.Text = "Дата крайнього збору меду";
            // 
            // EditBee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.DateCollectHoney);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HiveState);
            this.Controls.Add(this.PowerOfFamily);
            this.Controls.Add(this.InstallDate);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.HoneyAverage);
            this.Controls.Add(this.NumberOfFamily);
            this.Controls.Add(this.beeDataGrid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBee";
            this.Text = "EditBee";
            ((System.ComponentModel.ISupportInitialize)(this.beeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid beeDataGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown HiveState;
        private Bunifu.Framework.UI.BunifuDropdown PowerOfFamily;
        private Bunifu.Framework.UI.BunifuDatepicker InstallDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HoneyAverage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NumberOfFamily;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker DateCollectHoney;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}