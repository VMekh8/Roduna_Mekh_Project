namespace Roduna_Mekh_Project.GrainWindows
{
    partial class AddChemistGrainWindow
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
            this.label6 = new System.Windows.Forms.Label();
            this.grainDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrainIDSpinner = new Bunifu.Framework.UI.BunifuDropdown();
            this.DateChemists = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CountPreparateField = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToMainButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grainDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(176, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(618, 45);
            this.label6.TabIndex = 64;
            this.label6.Text = "Додати інформацію про обробку полів";
            // 
            // grainDataGrid
            // 
            this.grainDataGrid.AllowUserToAddRows = false;
            this.grainDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.grainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grainDataGrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grainDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grainDataGrid.DoubleBuffered = true;
            this.grainDataGrid.EnableHeadersVisualStyles = false;
            this.grainDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.grainDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.grainDataGrid.Location = new System.Drawing.Point(19, 163);
            this.grainDataGrid.MultiSelect = false;
            this.grainDataGrid.Name = "grainDataGrid";
            this.grainDataGrid.ReadOnly = true;
            this.grainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grainDataGrid.RowHeadersVisible = false;
            this.grainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grainDataGrid.Size = new System.Drawing.Size(920, 225);
            this.grainDataGrid.TabIndex = 65;
            this.grainDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grainDataGrid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 66;
            this.label2.Text = "Виберіть препарат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 67;
            this.label1.Text = "Виберіть ідентифікатор поля: ";
            // 
            // GrainIDSpinner
            // 
            this.GrainIDSpinner.BackColor = System.Drawing.Color.Transparent;
            this.GrainIDSpinner.BorderRadius = 3;
            this.GrainIDSpinner.DisabledColor = System.Drawing.Color.Gray;
            this.GrainIDSpinner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrainIDSpinner.ForeColor = System.Drawing.Color.White;
            this.GrainIDSpinner.Items = new string[0];
            this.GrainIDSpinner.Location = new System.Drawing.Point(414, 78);
            this.GrainIDSpinner.Margin = new System.Windows.Forms.Padding(6);
            this.GrainIDSpinner.Name = "GrainIDSpinner";
            this.GrainIDSpinner.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.GrainIDSpinner.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.GrainIDSpinner.selectedIndex = -1;
            this.GrainIDSpinner.Size = new System.Drawing.Size(355, 47);
            this.GrainIDSpinner.TabIndex = 68;
            // 
            // DateChemists
            // 
            this.DateChemists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.DateChemists.BorderRadius = 0;
            this.DateChemists.ForeColor = System.Drawing.Color.White;
            this.DateChemists.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateChemists.FormatCustom = null;
            this.DateChemists.Location = new System.Drawing.Point(15, 432);
            this.DateChemists.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DateChemists.Name = "DateChemists";
            this.DateChemists.Size = new System.Drawing.Size(355, 47);
            this.DateChemists.TabIndex = 70;
            this.DateChemists.Value = new System.DateTime(2023, 8, 19, 19, 0, 42, 37);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(9, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 36);
            this.label5.TabIndex = 69;
            this.label5.Text = "Дата обробки поля: ";
            // 
            // CountPreparateField
            // 
            this.CountPreparateField.BackColor = System.Drawing.Color.Gainsboro;
            this.CountPreparateField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CountPreparateField.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPreparateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CountPreparateField.HintForeColor = System.Drawing.Color.Empty;
            this.CountPreparateField.HintText = "";
            this.CountPreparateField.isPassword = false;
            this.CountPreparateField.LineFocusedColor = System.Drawing.Color.Green;
            this.CountPreparateField.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.CountPreparateField.LineMouseHoverColor = System.Drawing.Color.Green;
            this.CountPreparateField.LineThickness = 4;
            this.CountPreparateField.Location = new System.Drawing.Point(18, 515);
            this.CountPreparateField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CountPreparateField.Name = "CountPreparateField";
            this.CountPreparateField.Size = new System.Drawing.Size(355, 47);
            this.CountPreparateField.TabIndex = 72;
            this.CountPreparateField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 36);
            this.label3.TabIndex = 71;
            this.label3.Text = "Кількість речовини";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 74);
            this.button1.TabIndex = 73;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BackToMainButton.TabIndex = 74;
            this.BackToMainButton.TabStop = false;
            this.BackToMainButton.Zoom = 10;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.grainDataGrid;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.CountPreparateField;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.DateChemists;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.GrainIDSpinner;
            // 
            // AddChemistGrainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.BackToMainButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountPreparateField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateChemists);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrainIDSpinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grainDataGrid);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddChemistGrainWindow";
            this.Text = "AddChemistGrainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.grainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grainDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown GrainIDSpinner;
        private Bunifu.Framework.UI.BunifuDatepicker DateChemists;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CountPreparateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuImageButton BackToMainButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}