
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
            this.SuspendLayout();
            // 
            // buttonBackUpDataBase
            // 
            this.buttonBackUpDataBase.Location = new System.Drawing.Point(65, 46);
            this.buttonBackUpDataBase.Name = "buttonBackUpDataBase";
            this.buttonBackUpDataBase.Size = new System.Drawing.Size(160, 30);
            this.buttonBackUpDataBase.TabIndex = 0;
            this.buttonBackUpDataBase.Text = "Бекап базы данных";
            this.buttonBackUpDataBase.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDataBase
            // 
            this.buttonRestoreDataBase.Location = new System.Drawing.Point(65, 93);
            this.buttonRestoreDataBase.Name = "buttonRestoreDataBase";
            this.buttonRestoreDataBase.Size = new System.Drawing.Size(160, 41);
            this.buttonRestoreDataBase.TabIndex = 1;
            this.buttonRestoreDataBase.Text = "Восстановление базы данных";
            this.buttonRestoreDataBase.UseVisualStyleBackColor = true;
            // 
            // MainSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(978, 683);
            this.Controls.Add(this.buttonRestoreDataBase);
            this.Controls.Add(this.buttonBackUpDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainSetting";
            this.Text = "MainSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackUpDataBase;
        private System.Windows.Forms.Button buttonRestoreDataBase;
    }
}