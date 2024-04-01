
namespace PAIS_kurs_v1
{
    partial class MaintenanceRecordsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CostInput = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.VehicleIDComboBox = new System.Windows.Forms.ComboBox();
            this.toAdminMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehiclesDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.LicensePlate = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateOfServiceInput = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data";
            // 
            // CostInput
            // 
            this.CostInput.Location = new System.Drawing.Point(73, 132);
            this.CostInput.Multiline = true;
            this.CostInput.Name = "CostInput";
            this.CostInput.Size = new System.Drawing.Size(91, 25);
            this.CostInput.TabIndex = 24;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(25, 144);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(40, 13);
            this.Cost.TabIndex = 23;
            this.Cost.Text = "сумма";
            // 
            // VehicleIDComboBox
            // 
            this.VehicleIDComboBox.FormattingEnabled = true;
            this.VehicleIDComboBox.Location = new System.Drawing.Point(196, 136);
            this.VehicleIDComboBox.Name = "VehicleIDComboBox";
            this.VehicleIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.VehicleIDComboBox.TabIndex = 22;
            // 
            // toAdminMain
            // 
            this.toAdminMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.toAdminMain.FlatAppearance.BorderSize = 0;
            this.toAdminMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toAdminMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toAdminMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toAdminMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAdminMain.ForeColor = System.Drawing.Color.White;
            this.toAdminMain.Location = new System.Drawing.Point(556, 183);
            this.toAdminMain.Name = "toAdminMain";
            this.toAdminMain.Size = new System.Drawing.Size(102, 35);
            this.toAdminMain.TabIndex = 21;
            this.toAdminMain.Text = "НА ГОЛОВНУ";
            this.toAdminMain.UseVisualStyleBackColor = false;
            this.toAdminMain.Click += new System.EventHandler(this.toAdminMain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.vehiclesDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-25, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 305);
            this.panel1.TabIndex = 6;
            // 
            // vehiclesDataGrid
            // 
            this.vehiclesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGrid.Location = new System.Drawing.Point(36, 56);
            this.vehiclesDataGrid.Name = "vehiclesDataGrid";
            this.vehiclesDataGrid.Size = new System.Drawing.Size(674, 244);
            this.vehiclesDataGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "транспорний засіб";
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.UpdateUserButton.FlatAppearance.BorderSize = 0;
            this.UpdateUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserButton.ForeColor = System.Drawing.Color.White;
            this.UpdateUserButton.Location = new System.Drawing.Point(145, 183);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(102, 35);
            this.UpdateUserButton.TabIndex = 15;
            this.UpdateUserButton.Text = "ОНОВИТИ";
            this.UpdateUserButton.UseVisualStyleBackColor = false;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(23, 183);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(102, 35);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "ДОДАТИ";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(74, 57);
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(210, 61);
            this.DescriptionInput.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(32, 69);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "опис";
            // 
            // LicensePlate
            // 
            this.LicensePlate.AutoSize = true;
            this.LicensePlate.Location = new System.Drawing.Point(32, 25);
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.Size = new System.Drawing.Size(30, 13);
            this.LicensePlate.TabIndex = 0;
            this.LicensePlate.Text = "дата";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(272, 183);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(102, 35);
            this.deleteUserButton.TabIndex = 17;
            this.deleteUserButton.Text = "ВИДАЛИТИ";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DateOfServiceInput);
            this.panel2.Controls.Add(this.CostInput);
            this.panel2.Controls.Add(this.Cost);
            this.panel2.Controls.Add(this.VehicleIDComboBox);
            this.panel2.Controls.Add(this.toAdminMain);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.UpdateUserButton);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.DescriptionInput);
            this.panel2.Controls.Add(this.Type);
            this.panel2.Controls.Add(this.LicensePlate);
            this.panel2.Location = new System.Drawing.Point(-11, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 269);
            this.panel2.TabIndex = 7;
            // 
            // DateOfServiceInput
            // 
            this.DateOfServiceInput.Location = new System.Drawing.Point(74, 18);
            this.DateOfServiceInput.Name = "DateOfServiceInput";
            this.DateOfServiceInput.Size = new System.Drawing.Size(209, 20);
            this.DateOfServiceInput.TabIndex = 27;
            // 
            // MaintenanceRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MaintenanceRecordsForm";
            this.Text = "MaintenanceRecordsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CostInput;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.ComboBox VehicleIDComboBox;
        private System.Windows.Forms.Button toAdminMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView vehiclesDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label LicensePlate;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateOfServiceInput;
    }
}