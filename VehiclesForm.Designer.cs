
namespace PAIS_kurs_v1
{
    partial class VehiclesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Year = new System.Windows.Forms.Label();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.toAdminMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.TypeInput = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.licensePlateInput = new System.Windows.Forms.TextBox();
            this.LicensePlate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehiclesDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numericUpDownYear);
            this.panel2.Controls.Add(this.Year);
            this.panel2.Controls.Add(this.modelInput);
            this.panel2.Controls.Add(this.Model);
            this.panel2.Controls.Add(this.departmentComboBox);
            this.panel2.Controls.Add(this.toAdminMain);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.UpdateUserButton);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.TypeInput);
            this.panel2.Controls.Add(this.Type);
            this.panel2.Controls.Add(this.licensePlateInput);
            this.panel2.Controls.Add(this.LicensePlate);
            this.panel2.Location = new System.Drawing.Point(-15, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 291);
            this.panel2.TabIndex = 5;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(20, 120);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(64, 13);
            this.Year.TabIndex = 25;
            this.Year.Text = "рік випуску";
            // 
            // modelInput
            // 
            this.modelInput.Location = new System.Drawing.Point(103, 77);
            this.modelInput.Multiline = true;
            this.modelInput.Name = "modelInput";
            this.modelInput.Size = new System.Drawing.Size(144, 25);
            this.modelInput.TabIndex = 24;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(20, 89);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(45, 13);
            this.Model.TabIndex = 23;
            this.Model.Text = "модель";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(272, 112);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComboBox.TabIndex = 22;
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
            this.toAdminMain.Location = new System.Drawing.Point(587, 183);
            this.toAdminMain.Name = "toAdminMain";
            this.toAdminMain.Size = new System.Drawing.Size(102, 35);
            this.toAdminMain.TabIndex = 21;
            this.toAdminMain.Text = "НА ГОЛОВНУ";
            this.toAdminMain.UseVisualStyleBackColor = false;
            this.toAdminMain.Click += new System.EventHandler(this.toAdminMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "підприємство";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // TypeInput
            // 
            this.TypeInput.Location = new System.Drawing.Point(103, 46);
            this.TypeInput.Multiline = true;
            this.TypeInput.Name = "TypeInput";
            this.TypeInput.Size = new System.Drawing.Size(144, 25);
            this.TypeInput.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(20, 58);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(24, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "тип";
            // 
            // licensePlateInput
            // 
            this.licensePlateInput.Location = new System.Drawing.Point(103, 15);
            this.licensePlateInput.Multiline = true;
            this.licensePlateInput.Name = "licensePlateInput";
            this.licensePlateInput.Size = new System.Drawing.Size(144, 25);
            this.licensePlateInput.TabIndex = 1;
            // 
            // LicensePlate
            // 
            this.LicensePlate.AutoSize = true;
            this.LicensePlate.Location = new System.Drawing.Point(20, 27);
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.Size = new System.Drawing.Size(75, 13);
            this.LicensePlate.TabIndex = 0;
            this.LicensePlate.Text = "id техпаспорт";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.vehiclesDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-36, -44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 305);
            this.panel1.TabIndex = 4;
            // 
            // vehiclesDataGrid
            // 
            this.vehiclesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGrid.Location = new System.Drawing.Point(47, 55);
            this.vehiclesDataGrid.Name = "vehiclesDataGrid";
            this.vehiclesDataGrid.Size = new System.Drawing.Size(663, 245);
            this.vehiclesDataGrid.TabIndex = 1;
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
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(103, 118);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(144, 20);
            this.numericUpDownYear.TabIndex = 26;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button toAdminMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox TypeInput;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox licensePlateInput;
        private System.Windows.Forms.Label LicensePlate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView vehiclesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox modelInput;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
    }
}