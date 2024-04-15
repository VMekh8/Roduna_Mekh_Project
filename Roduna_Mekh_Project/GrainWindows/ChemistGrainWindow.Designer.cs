namespace Roduna_Mekh_Project.GrainWindows
{
    partial class ChemistGrainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrainIDSpinner = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.grainDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToMainButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grainDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(117, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 71;
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
            this.GrainIDSpinner.Location = new System.Drawing.Point(523, 110);
            this.GrainIDSpinner.Margin = new System.Windows.Forms.Padding(6);
            this.GrainIDSpinner.Name = "GrainIDSpinner";
            this.GrainIDSpinner.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.GrainIDSpinner.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.GrainIDSpinner.selectedIndex = -1;
            this.GrainIDSpinner.Size = new System.Drawing.Size(355, 47);
            this.GrainIDSpinner.TabIndex = 72;
            this.GrainIDSpinner.onItemSelected += new System.EventHandler(this.GrainIDSpinner_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 36);
            this.label2.TabIndex = 70;
            this.label2.Text = "На цьому полі використані такі хімікати:\r\n";
            // 
            // grainDataGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grainDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grainDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.grainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grainDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grainDataGrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grainDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.grainDataGrid.DoubleBuffered = true;
            this.grainDataGrid.EnableHeadersVisualStyles = false;
            this.grainDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(10)))));
            this.grainDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.grainDataGrid.Location = new System.Drawing.Point(33, 232);
            this.grainDataGrid.Name = "grainDataGrid";
            this.grainDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grainDataGrid.RowHeadersVisible = false;
            this.grainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grainDataGrid.Size = new System.Drawing.Size(920, 291);
            this.grainDataGrid.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 45);
            this.label3.TabIndex = 73;
            this.label3.Text = "Перегляд інформації про обробку полів";
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
            this.bunifuElipse1.TargetControl = this.grainDataGrid;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.GrainIDSpinner;
            // 
            // ChemistGrainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 577);
            this.Controls.Add(this.BackToMainButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrainIDSpinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grainDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChemistGrainWindow";
            this.Text = "ChemistGrainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.grainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown GrainIDSpinner;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grainDataGrid;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton BackToMainButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}