namespace Roduna_Mekh_Project.BeeWindows.BeeStateWindow
{
    partial class HiveWindow
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
            this.beeDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Nav1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ElementID = new Bunifu.Framework.UI.BunifuDropdown();
            this.RepairCostTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.beeDataGrid)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
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
            this.beeDataGrid.HeaderBgColor = System.Drawing.Color.DarkOrange;
            this.beeDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.beeDataGrid.Location = new System.Drawing.Point(23, 54);
            this.beeDataGrid.Name = "beeDataGrid";
            this.beeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.beeDataGrid.RowHeadersVisible = false;
            this.beeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.beeDataGrid.Size = new System.Drawing.Size(556, 217);
            this.beeDataGrid.TabIndex = 2;
            // 
            // Nav1
            // 
            this.Nav1.AutoSize = true;
            this.Nav1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.Nav1.ForeColor = System.Drawing.Color.Black;
            this.Nav1.Location = new System.Drawing.Point(45, 23);
            this.Nav1.Name = "Nav1";
            this.Nav1.Size = new System.Drawing.Size(330, 28);
            this.Nav1.TabIndex = 44;
            this.Nav1.Text = "Вулики, які потребують ремонту:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Вибрати вулик:";
            // 
            // ElementID
            // 
            this.ElementID.BackColor = System.Drawing.Color.Transparent;
            this.ElementID.BorderRadius = 3;
            this.ElementID.DisabledColor = System.Drawing.Color.Gray;
            this.ElementID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementID.ForeColor = System.Drawing.Color.Black;
            this.ElementID.Items = new string[0];
            this.ElementID.Location = new System.Drawing.Point(50, 318);
            this.ElementID.Margin = new System.Windows.Forms.Padding(6);
            this.ElementID.Name = "ElementID";
            this.ElementID.NomalColor = System.Drawing.Color.Cornsilk;
            this.ElementID.onHoverColor = System.Drawing.Color.Khaki;
            this.ElementID.selectedIndex = -1;
            this.ElementID.Size = new System.Drawing.Size(332, 42);
            this.ElementID.TabIndex = 46;
            // 
            // RepairCostTextBox
            // 
            this.RepairCostTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RepairCostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepairCostTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RepairCostTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.RepairCostTextBox.HintText = "";
            this.RepairCostTextBox.isPassword = false;
            this.RepairCostTextBox.LineFocusedColor = System.Drawing.Color.Gold;
            this.RepairCostTextBox.LineIdleColor = System.Drawing.Color.Cornsilk;
            this.RepairCostTextBox.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.RepairCostTextBox.LineThickness = 4;
            this.RepairCostTextBox.Location = new System.Drawing.Point(50, 398);
            this.RepairCostTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RepairCostTextBox.Name = "RepairCostTextBox";
            this.RepairCostTextBox.Size = new System.Drawing.Size(332, 42);
            this.RepairCostTextBox.TabIndex = 47;
            this.RepairCostTextBox.Text = "0";
            this.RepairCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Вартість ремонту:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Cornsilk;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubmitButton.Location = new System.Drawing.Point(176, 462);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(232, 35);
            this.SubmitButton.TabIndex = 49;
            this.SubmitButton.Text = "Ремонтувати";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this.beeDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 8;
            this.bunifuElipse2.TargetControl = this.SubmitButton;
            // 
            // HiveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(606, 509);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepairCostTextBox);
            this.Controls.Add(this.ElementID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nav1);
            this.Controls.Add(this.beeDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HiveWindow";
            this.Text = "HiveWindow";
            ((System.ComponentModel.ISupportInitialize)(this.beeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid beeDataGrid;
        private System.Windows.Forms.Label Nav1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown ElementID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RepairCostTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}