
namespace PAIS_kurs_v1
{
    partial class AddUsers
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
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.toAdminMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.adminCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.departmentComboBox);
            this.panel2.Controls.Add(this.toAdminMain);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.adminCheckbox);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.UpdateUserButton);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usernameInput);
            this.panel2.Controls.Add(this.userID);
            this.panel2.Location = new System.Drawing.Point(-4, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 267);
            this.panel2.TabIndex = 3;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(328, 24);
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
            this.toAdminMain.Location = new System.Drawing.Point(531, 174);
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
            this.label2.Location = new System.Drawing.Point(243, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "підприємство:";
            // 
            // adminCheckbox
            // 
            this.adminCheckbox.AutoSize = true;
            this.adminCheckbox.Location = new System.Drawing.Point(80, 93);
            this.adminCheckbox.Name = "adminCheckbox";
            this.adminCheckbox.Size = new System.Drawing.Size(139, 17);
            this.adminCheckbox.TabIndex = 18;
            this.adminCheckbox.Text = "акаунт адміністратора";
            this.adminCheckbox.UseVisualStyleBackColor = true;
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
            this.deleteUserButton.Location = new System.Drawing.Point(272, 174);
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
            this.UpdateUserButton.Location = new System.Drawing.Point(145, 174);
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
            this.addUserButton.Location = new System.Drawing.Point(23, 174);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(102, 35);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "ДОДАТИ";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(80, 62);
            this.passwordInput.Multiline = true;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(144, 25);
            this.passwordInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "пароль:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(80, 21);
            this.usernameInput.Multiline = true;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(144, 25);
            this.usernameInput.TabIndex = 1;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(20, 27);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(35, 13);
            this.userID.TabIndex = 0;
            this.userID.Text = "логін:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usersDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-25, -43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 290);
            this.panel1.TabIndex = 2;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(36, 54);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.Size = new System.Drawing.Size(623, 224);
            this.usersDataGrid.TabIndex = 1;
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
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUsers";
            this.Text = "AdminPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox adminCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toAdminMain;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}