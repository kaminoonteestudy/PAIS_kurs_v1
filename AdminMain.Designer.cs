﻿
namespace PAIS_kurs_v1
{
    partial class AdminMain
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
            this.addUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUsers
            // 
            this.addUsers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addUsers.Location = new System.Drawing.Point(275, 107);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(182, 97);
            this.addUsers.TabIndex = 0;
            this.addUsers.Text = "ДОДАТИ КОРИСТУВАЧІВ";
            this.addUsers.UseVisualStyleBackColor = false;
            this.addUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(275, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "ДОДАТИ ПІДПРИЕМСТВА";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addUsers);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUsers;
        private System.Windows.Forms.Button button2;
    }
}