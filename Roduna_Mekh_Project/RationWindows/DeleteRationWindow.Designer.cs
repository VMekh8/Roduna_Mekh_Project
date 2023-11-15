namespace Roduna_Mekh_Project.RationWindows
{
    partial class DeleteRationWindow
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RationDelDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.elipseforbtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.RationDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
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
            this.RationDataGrid.Location = new System.Drawing.Point(49, 70);
            this.RationDataGrid.Name = "RationDataGrid";
            this.RationDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RationDataGrid.RowHeadersVisible = false;
            this.RationDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RationDataGrid.Size = new System.Drawing.Size(890, 298);
            this.RationDataGrid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 6.973022F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 275.2792F;
            this.Column2.HeaderText = "Опис раціону";
            this.Column2.Name = "Column2";
            this.Column2.Width = 600;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 7.747803F;
            this.Column3.HeaderText = "Ціна ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Видалення раціону";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Виберіть елемент, який бажаєте видалити:";
            // 
            // RationDelDropDown
            // 
            this.RationDelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.RationDelDropDown.BorderRadius = 3;
            this.RationDelDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.RationDelDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RationDelDropDown.ForeColor = System.Drawing.Color.White;
            this.RationDelDropDown.Items = new string[0];
            this.RationDelDropDown.Location = new System.Drawing.Point(598, 401);
            this.RationDelDropDown.Margin = new System.Windows.Forms.Padding(6);
            this.RationDelDropDown.Name = "RationDelDropDown";
            this.RationDelDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(192)))));
            this.RationDelDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.RationDelDropDown.selectedIndex = -1;
            this.RationDelDropDown.Size = new System.Drawing.Size(341, 47);
            this.RationDelDropDown.TabIndex = 16;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Tomato;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(752, 483);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(187, 45);
            this.DeleteButton.TabIndex = 37;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // elipseforbtn
            // 
            this.elipseforbtn.ElipseRadius = 10;
            this.elipseforbtn.TargetControl = this.DeleteButton;
            // 
            // DeleteRationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RationDelDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RationDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteRationWindow";
            this.Text = "DeleteRationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.RationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid RationDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown RationDelDropDown;
        private System.Windows.Forms.Button DeleteButton;
        private Bunifu.Framework.UI.BunifuElipse elipseforbtn;
    }
}