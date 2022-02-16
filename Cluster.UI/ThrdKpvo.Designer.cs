
namespace Cluster.UI
{
    partial class ThrdKpvo
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
            this.buttonOpenDocument = new System.Windows.Forms.Button();
            this.listBoxListOfPdfs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonOpenDocument
            // 
            this.buttonOpenDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonOpenDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonOpenDocument.FlatAppearance.BorderSize = 2;
            this.buttonOpenDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOpenDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonOpenDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDocument.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDocument.ForeColor = System.Drawing.Color.White;
            this.buttonOpenDocument.Location = new System.Drawing.Point(319, 485);
            this.buttonOpenDocument.Name = "buttonOpenDocument";
            this.buttonOpenDocument.Size = new System.Drawing.Size(670, 47);
            this.buttonOpenDocument.TabIndex = 3;
            this.buttonOpenDocument.Text = "Открыть";
            this.buttonOpenDocument.UseVisualStyleBackColor = false;
            this.buttonOpenDocument.Click += new System.EventHandler(this.buttonOpenDocument_Click);
            // 
            // listBoxListOfPdfs
            // 
            this.listBoxListOfPdfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxListOfPdfs.BackColor = System.Drawing.Color.LightYellow;
            this.listBoxListOfPdfs.FormattingEnabled = true;
            this.listBoxListOfPdfs.ItemHeight = 17;
            this.listBoxListOfPdfs.Location = new System.Drawing.Point(101, 303);
            this.listBoxListOfPdfs.Name = "listBoxListOfPdfs";
            this.listBoxListOfPdfs.Size = new System.Drawing.Size(1138, 157);
            this.listBoxListOfPdfs.TabIndex = 2;
            // 
            // ThrdKpvo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1304, 841);
            this.Controls.Add(this.buttonOpenDocument);
            this.Controls.Add(this.listBoxListOfPdfs);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThrdKpvo";
            this.Text = "ThrdKpvo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDocument;
        private System.Windows.Forms.ListBox listBoxListOfPdfs;
    }
}