
using System;
using System.Windows.Forms;

namespace Cluster.UI
{
    partial class MainSetting
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
            this.buttonBackUpDataBase = new System.Windows.Forms.Button();
            this.buttonRestoreDataBase = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackUpDataBase
            // 
            this.buttonBackUpDataBase.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonBackUpDataBase.FlatAppearance.BorderSize = 2;
            this.buttonBackUpDataBase.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.buttonBackUpDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonBackUpDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBackUpDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackUpDataBase.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackUpDataBase.ForeColor = System.Drawing.Color.White;
            this.buttonBackUpDataBase.Location = new System.Drawing.Point(47, 306);
            this.buttonBackUpDataBase.Name = "buttonBackUpDataBase";
            this.buttonBackUpDataBase.Size = new System.Drawing.Size(160, 30);
            this.buttonBackUpDataBase.TabIndex = 0;
            this.buttonBackUpDataBase.Text = "Бекап базы данных";
            this.buttonBackUpDataBase.UseVisualStyleBackColor = true;
            this.buttonBackUpDataBase.Click += new System.EventHandler(this.buttonBackUpDataBase_Click);
            // 
            // buttonRestoreDataBase
            // 
            this.buttonRestoreDataBase.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonRestoreDataBase.FlatAppearance.BorderSize = 2;
            this.buttonRestoreDataBase.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.buttonRestoreDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonRestoreDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRestoreDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreDataBase.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestoreDataBase.ForeColor = System.Drawing.Color.White;
            this.buttonRestoreDataBase.Location = new System.Drawing.Point(47, 210);
            this.buttonRestoreDataBase.Name = "buttonRestoreDataBase";
            this.buttonRestoreDataBase.Size = new System.Drawing.Size(160, 48);
            this.buttonRestoreDataBase.TabIndex = 1;
            this.buttonRestoreDataBase.Text = "Восстановление базы данных";
            this.buttonRestoreDataBase.UseVisualStyleBackColor = true;
            this.buttonRestoreDataBase.Click += new System.EventHandler(this.buttonRestoreDataBase_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(47, 182);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(160, 23);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(47, 159);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(142, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Введите пароль";
            // 
            // MainSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(978, 683);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRestoreDataBase);
            this.Controls.Add(this.buttonBackUpDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainSetting";
            this.Text = "MainSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                buttonRestoreDataBase_Click(sender, e);
            }
        }

        #endregion

        private System.Windows.Forms.Button buttonBackUpDataBase;
        private System.Windows.Forms.Button buttonRestoreDataBase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxPassword;
        private Label labelPassword;
    }
}