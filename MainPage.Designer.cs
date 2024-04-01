
namespace PAIS_kurs_v1
{
    partial class MainPage
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
            this.AddVehicles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddVehicles
            // 
            this.AddVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.AddVehicles.ForeColor = System.Drawing.SystemColors.Window;
            this.AddVehicles.Location = new System.Drawing.Point(182, 174);
            this.AddVehicles.Name = "AddVehicles";
            this.AddVehicles.Size = new System.Drawing.Size(212, 92);
            this.AddVehicles.TabIndex = 0;
            this.AddVehicles.Text = "ДОДАТИ МАШИНИ";
            this.AddVehicles.UseVisualStyleBackColor = false;
            this.AddVehicles.Click += new System.EventHandler(this.AddVehicles_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(400, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "ДОДАТИ ЗАПИСИ ОБСЛУГОВУВАННЯ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddVehicles);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddVehicles;
        private System.Windows.Forms.Button button1;
    }
}