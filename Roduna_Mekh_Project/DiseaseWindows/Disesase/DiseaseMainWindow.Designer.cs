namespace Roduna_Mekh_Project.DiseaseWindows.Disesase
{
    partial class DiseaseMainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.DiseaseDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DeleteDiseaseButton = new System.Windows.Forms.Button();
            this.AddDiseaseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MedicineButton = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DiseaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(313, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "ВЗАЄМОДІЯ З ХВОРОБАМИ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Можливі захворювання:";
            // 
            // DiseaseDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiseaseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiseaseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiseaseDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.DiseaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiseaseDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DiseaseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(132)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiseaseDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiseaseDataGrid.ColumnHeadersHeight = 50;
            this.DiseaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiseaseDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiseaseDataGrid.DoubleBuffered = true;
            this.DiseaseDataGrid.EnableHeadersVisualStyles = false;
            this.DiseaseDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(132)))), ((int)(((byte)(231)))));
            this.DiseaseDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DiseaseDataGrid.Location = new System.Drawing.Point(52, 61);
            this.DiseaseDataGrid.Name = "DiseaseDataGrid";
            this.DiseaseDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiseaseDataGrid.RowHeadersVisible = false;
            this.DiseaseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiseaseDataGrid.Size = new System.Drawing.Size(891, 298);
            this.DiseaseDataGrid.TabIndex = 12;
            // 
            // DeleteDiseaseButton
            // 
            this.DeleteDiseaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.DeleteDiseaseButton.FlatAppearance.BorderSize = 0;
            this.DeleteDiseaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDiseaseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.DeleteDiseaseButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDiseaseButton.Image = global::Roduna_Mekh_Project.Properties.Resources.minus_outline__1_;
            this.DeleteDiseaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteDiseaseButton.Location = new System.Drawing.Point(512, 401);
            this.DeleteDiseaseButton.Name = "DeleteDiseaseButton";
            this.DeleteDiseaseButton.Size = new System.Drawing.Size(254, 45);
            this.DeleteDiseaseButton.TabIndex = 16;
            this.DeleteDiseaseButton.Text = "Видалити ";
            this.DeleteDiseaseButton.UseVisualStyleBackColor = false;
            // 
            // AddDiseaseButton
            // 
            this.AddDiseaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.AddDiseaseButton.FlatAppearance.BorderSize = 0;
            this.AddDiseaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDiseaseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.AddDiseaseButton.ForeColor = System.Drawing.Color.White;
            this.AddDiseaseButton.Image = global::Roduna_Mekh_Project.Properties.Resources.plus__1_2;
            this.AddDiseaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDiseaseButton.Location = new System.Drawing.Point(181, 401);
            this.AddDiseaseButton.Name = "AddDiseaseButton";
            this.AddDiseaseButton.Size = new System.Drawing.Size(254, 45);
            this.AddDiseaseButton.TabIndex = 15;
            this.AddDiseaseButton.Text = "Додати ";
            this.AddDiseaseButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(365, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "МЕДИКАМЕНТИ";
            // 
            // MedicineButton
            // 
            this.MedicineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.MedicineButton.FlatAppearance.BorderSize = 0;
            this.MedicineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicineButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.MedicineButton.ForeColor = System.Drawing.Color.White;
            this.MedicineButton.Image = global::Roduna_Mekh_Project.Properties.Resources.pill__1_;
            this.MedicineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedicineButton.Location = new System.Drawing.Point(336, 487);
            this.MedicineButton.Name = "MedicineButton";
            this.MedicineButton.Size = new System.Drawing.Size(254, 66);
            this.MedicineButton.TabIndex = 18;
            this.MedicineButton.Text = "Медикаменти";
            this.MedicineButton.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.DiseaseDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.AddDiseaseButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.DeleteDiseaseButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.MedicineButton;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 64.33668F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 88.52728F;
            this.Column2.HeaderText = "Назва";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 88.52728F;
            this.Column3.HeaderText = "Тип";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 88.52728F;
            this.Column4.HeaderText = "Симптоми";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 88.52728F;
            this.Column5.HeaderText = "Опис";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 88.52728F;
            this.Column6.HeaderText = "Номер препарату";
            this.Column6.Name = "Column6";
            // 
            // DiseaseMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.MedicineButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteDiseaseButton);
            this.Controls.Add(this.AddDiseaseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiseaseDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiseaseMainWindow";
            this.Text = "DiseaseMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DiseaseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteDiseaseButton;
        private System.Windows.Forms.Button AddDiseaseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DiseaseDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MedicineButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}