namespace Roduna_Mekh_Project
{
    partial class RationMainWindow
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
            this.RationDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.elipsefordatagrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elipseforaddbutton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AddRationButton = new System.Windows.Forms.Button();
            this.elipsefordeletebtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DeleteRationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RationDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RationDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RationDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.RationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RationDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RationDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RationDataGrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RationDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RationDataGrid.DoubleBuffered = true;
            this.RationDataGrid.EnableHeadersVisualStyles = false;
            this.RationDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.RationDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RationDataGrid.Location = new System.Drawing.Point(55, 49);
            this.RationDataGrid.Name = "RationDataGrid";
            this.RationDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RationDataGrid.RowHeadersVisible = false;
            this.RationDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RationDataGrid.Size = new System.Drawing.Size(891, 298);
            this.RationDataGrid.TabIndex = 3;
            // 
            // elipsefordatagrid
            // 
            this.elipsefordatagrid.ElipseRadius = 10;
            this.elipsefordatagrid.TargetControl = this.RationDataGrid;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наявні раціони: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(316, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "ВЗАЄМОДІЯ З РАЦІОНАМИ";
            // 
            // elipseforaddbutton
            // 
            this.elipseforaddbutton.ElipseRadius = 10;
            this.elipseforaddbutton.TargetControl = this.AddRationButton;
            // 
            // AddRationButton
            // 
            this.AddRationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.AddRationButton.FlatAppearance.BorderSize = 0;
            this.AddRationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRationButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.AddRationButton.ForeColor = System.Drawing.Color.White;
            this.AddRationButton.Image = global::Roduna_Mekh_Project.Properties.Resources.plus__1_2;
            this.AddRationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRationButton.Location = new System.Drawing.Point(184, 459);
            this.AddRationButton.Name = "AddRationButton";
            this.AddRationButton.Size = new System.Drawing.Size(254, 77);
            this.AddRationButton.TabIndex = 9;
            this.AddRationButton.Text = "Додати раціони";
            this.AddRationButton.UseVisualStyleBackColor = false;
            this.AddRationButton.Click += new System.EventHandler(this.AddRationButton_Click);
            // 
            // elipsefordeletebtn
            // 
            this.elipsefordeletebtn.ElipseRadius = 10;
            this.elipsefordeletebtn.TargetControl = this.DeleteRationButton;
            // 
            // DeleteRationButton
            // 
            this.DeleteRationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.DeleteRationButton.FlatAppearance.BorderSize = 0;
            this.DeleteRationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRationButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.DeleteRationButton.ForeColor = System.Drawing.Color.White;
            this.DeleteRationButton.Image = global::Roduna_Mekh_Project.Properties.Resources.minus_outline__1_;
            this.DeleteRationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRationButton.Location = new System.Drawing.Point(515, 459);
            this.DeleteRationButton.Name = "DeleteRationButton";
            this.DeleteRationButton.Size = new System.Drawing.Size(254, 77);
            this.DeleteRationButton.TabIndex = 11;
            this.DeleteRationButton.Text = "Видалити раціони";
            this.DeleteRationButton.UseVisualStyleBackColor = false;
            this.DeleteRationButton.Click += new System.EventHandler(this.DeleteRationButton_Click);
            // 
            // RationMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.DeleteRationButton);
            this.Controls.Add(this.AddRationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RationDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RationMainWindow";
            this.Text = "RationMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid RationDataGrid;
        private Bunifu.Framework.UI.BunifuElipse elipsefordatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRationButton;
        private System.Windows.Forms.Button DeleteRationButton;
        private Bunifu.Framework.UI.BunifuElipse elipseforaddbutton;
        private Bunifu.Framework.UI.BunifuElipse elipsefordeletebtn;
    }
}