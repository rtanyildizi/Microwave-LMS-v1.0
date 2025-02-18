﻿namespace Microwave_v1._0
{
    partial class Warning
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
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(204, 144);
            this.btn_no.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(68, 29);
            this.btn_no.TabIndex = 0;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(41, 144);
            this.btn_yes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(68, 29);
            this.btn_yes.TabIndex = 2;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(16, 33);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(69, 18);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Message";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(16, 72);
            this.lbl_admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(45, 15);
            this.lbl_admin.TabIndex = 3;
            this.lbl_admin.Text = "Admin:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(17, 98);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 15);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.DimGray;
            this.tb_password.Location = new System.Drawing.Point(97, 95);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(175, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_password_KeyPress);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(94, 72);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(16, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "...";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_error.Location = new System.Drawing.Point(16, 123);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_error.TabIndex = 25;
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(315, 193);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Warning";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_error;
    }
}