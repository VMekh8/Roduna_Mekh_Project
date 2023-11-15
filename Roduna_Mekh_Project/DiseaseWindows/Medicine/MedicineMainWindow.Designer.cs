namespace Roduna_Mekh_Project.DiseaseWindows.Medicine
{
    partial class MedicineMainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MedicineDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteMedicineButton = new System.Windows.Forms.Button();
            this.AddMedicineButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineDataGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.MedicineDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineDataGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.MedicineDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicineDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MedicineDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.MedicineDataGrid.ColumnHeadersHeight = 50;
            this.MedicineDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.MedicineDataGrid.DoubleBuffered = true;
            this.MedicineDataGrid.EnableHeadersVisualStyles = false;
            this.MedicineDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.MedicineDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MedicineDataGrid.Location = new System.Drawing.Point(48, 40);
            this.MedicineDataGrid.Name = "MedicineDataGrid";
            this.MedicineDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MedicineDataGrid.RowHeadersVisible = false;
            this.MedicineDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineDataGrid.Size = new System.Drawing.Size(891, 298);
            this.MedicineDataGrid.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 64.33668F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Назва препарату";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тип медикаменту";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Для типу захворювання";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ціна";
            this.Column5.Name = "Column5";
            // 
            // DeleteMedicineButton
            // 
            this.DeleteMedicineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.DeleteMedicineButton.FlatAppearance.BorderSize = 0;
            this.DeleteMedicineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.DeleteMedicineButton.ForeColor = System.Drawing.Color.White;
            this.DeleteMedicineButton.Image = global::Roduna_Mekh_Project.Properties.Resources.minus_outline__1_;
            this.DeleteMedicineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMedicineButton.Location = new System.Drawing.Point(529, 415);
            this.DeleteMedicineButton.Name = "DeleteMedicineButton";
            this.DeleteMedicineButton.Size = new System.Drawing.Size(254, 62);
            this.DeleteMedicineButton.TabIndex = 21;
            this.DeleteMedicineButton.Text = "Видалити ";
            this.DeleteMedicineButton.UseVisualStyleBackColor = false;
            // 
            // AddMedicineButton
            // 
            this.AddMedicineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.AddMedicineButton.FlatAppearance.BorderSize = 0;
            this.AddMedicineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.AddMedicineButton.ForeColor = System.Drawing.Color.White;
            this.AddMedicineButton.Image = global::Roduna_Mekh_Project.Properties.Resources.plus__1_2;
            this.AddMedicineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMedicineButton.Location = new System.Drawing.Point(198, 415);
            this.AddMedicineButton.Name = "AddMedicineButton";
            this.AddMedicineButton.Size = new System.Drawing.Size(254, 62);
            this.AddMedicineButton.TabIndex = 20;
            this.AddMedicineButton.Text = "Додати ";
            this.AddMedicineButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(294, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "ВЗАЄМОДІЯ З МЕДИКАМЕНТАМИ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.MedicineDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.AddMedicineButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.DeleteMedicineButton;
            // 
            // MedicineMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.DeleteMedicineButton);
            this.Controls.Add(this.AddMedicineButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicineDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineMainWindow";
            this.Text = "MedicineMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid MedicineDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button DeleteMedicineButton;
        private System.Windows.Forms.Button AddMedicineButton;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}