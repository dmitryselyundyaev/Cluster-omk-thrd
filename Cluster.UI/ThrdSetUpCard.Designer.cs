
namespace Cluster.UI
{
    partial class ThrdSetUpCard
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
            this.listBoxListOfPrograms = new System.Windows.Forms.ListBox();
            this.buttonOpenDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxListOfPrograms
            // 
            this.listBoxListOfPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxListOfPrograms.BackColor = System.Drawing.Color.SteelBlue;
            this.listBoxListOfPrograms.FormattingEnabled = true;
            this.listBoxListOfPrograms.ItemHeight = 16;
            this.listBoxListOfPrograms.Location = new System.Drawing.Point(301, 176);
            this.listBoxListOfPrograms.Name = "listBoxListOfPrograms";
            this.listBoxListOfPrograms.Size = new System.Drawing.Size(329, 132);
            this.listBoxListOfPrograms.TabIndex = 0;
            // 
            // buttonOpenDocument
            // 
            this.buttonOpenDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenDocument.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonOpenDocument.FlatAppearance.BorderSize = 2;
            this.buttonOpenDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonOpenDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOpenDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDocument.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDocument.ForeColor = System.Drawing.Color.White;
            this.buttonOpenDocument.Location = new System.Drawing.Point(301, 314);
            this.buttonOpenDocument.Name = "buttonOpenDocument";
            this.buttonOpenDocument.Size = new System.Drawing.Size(329, 47);
            this.buttonOpenDocument.TabIndex = 1;
            this.buttonOpenDocument.Text = "Открыть";
            this.buttonOpenDocument.UseVisualStyleBackColor = true;
            this.buttonOpenDocument.Click += new System.EventHandler(this.buttonOpenDocument_Click);
            // 
            // ThrdSetUpCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(963, 579);
            this.Controls.Add(this.buttonOpenDocument);
            this.Controls.Add(this.listBoxListOfPrograms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThrdSetUpCard";
            this.Text = "ThrdSetUpCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListOfPrograms;
        private System.Windows.Forms.Button buttonOpenDocument;
    }
}