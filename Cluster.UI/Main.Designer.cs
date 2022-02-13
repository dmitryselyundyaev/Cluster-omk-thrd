
using System.Windows.Forms;

namespace Cluster.UI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSidaMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelThrdDocuments = new System.Windows.Forms.Panel();
            this.buttonThrdSetUpCards = new System.Windows.Forms.Button();
            this.buttonThrdKPVOTubeTime = new System.Windows.Forms.Button();
            this.buttonThrdKPVOThread = new System.Windows.Forms.Button();
            this.buttonThrdDocuments = new System.Windows.Forms.Button();
            this.panelThrdFaqSubMenu = new System.Windows.Forms.Panel();
            this.buttonThrdSetUpProblems = new System.Windows.Forms.Button();
            this.buttonThrdFAQProblems = new System.Windows.Forms.Button();
            this.buttonThrdFaq = new System.Windows.Forms.Button();
            this.panelThrdToolsSubMenu = new System.Windows.Forms.Panel();
            this.buttonThrdSpeedSetUp = new System.Windows.Forms.Button();
            this.buttonThrdProgramList = new System.Windows.Forms.Button();
            this.buttonThrdMachineGeometry = new System.Windows.Forms.Button();
            this.buttonThrdTools = new System.Windows.Forms.Button();
            this.panelThrdOffsetSubMenu = new System.Windows.Forms.Panel();
            this.buttonThrdOffsetView = new System.Windows.Forms.Button();
            this.buttonThrdOffsetAdd = new System.Windows.Forms.Button();
            this.buttonThrdOffset = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelChildFormName = new System.Windows.Forms.Panel();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMinimizeApp = new System.Windows.Forms.Button();
            this.buttonFullScreenApp = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.labelHeaderName = new System.Windows.Forms.Label();
            this.panelSidaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelThrdDocuments.SuspendLayout();
            this.panelThrdFaqSubMenu.SuspendLayout();
            this.panelThrdToolsSubMenu.SuspendLayout();
            this.panelThrdOffsetSubMenu.SuspendLayout();
            this.panelChildFormName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidaMenu
            // 
            this.panelSidaMenu.AutoScroll = true;
            this.panelSidaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.panelSidaMenu.Controls.Add(this.pictureBox2);
            this.panelSidaMenu.Controls.Add(this.buttonSettings);
            this.panelSidaMenu.Controls.Add(this.panelThrdDocuments);
            this.panelSidaMenu.Controls.Add(this.buttonThrdDocuments);
            this.panelSidaMenu.Controls.Add(this.panelThrdFaqSubMenu);
            this.panelSidaMenu.Controls.Add(this.buttonThrdFaq);
            this.panelSidaMenu.Controls.Add(this.panelThrdToolsSubMenu);
            this.panelSidaMenu.Controls.Add(this.buttonThrdTools);
            this.panelSidaMenu.Controls.Add(this.panelThrdOffsetSubMenu);
            this.panelSidaMenu.Controls.Add(this.buttonThrdOffset);
            this.panelSidaMenu.Controls.Add(this.panelLogo);
            this.panelSidaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidaMenu.Location = new System.Drawing.Point(1, 39);
            this.panelSidaMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidaMenu.Name = "panelSidaMenu";
            this.panelSidaMenu.Size = new System.Drawing.Size(247, 841);
            this.panelSidaMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 754);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 62);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Image = global::Cluster.UI.Properties.Resources.setting;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 708);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(247, 46);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "         Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelThrdDocuments
            // 
            this.panelThrdDocuments.BackColor = System.Drawing.Color.Teal;
            this.panelThrdDocuments.Controls.Add(this.buttonThrdSetUpCards);
            this.panelThrdDocuments.Controls.Add(this.buttonThrdKPVOTubeTime);
            this.panelThrdDocuments.Controls.Add(this.buttonThrdKPVOThread);
            this.panelThrdDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThrdDocuments.Location = new System.Drawing.Point(0, 571);
            this.panelThrdDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThrdDocuments.Name = "panelThrdDocuments";
            this.panelThrdDocuments.Size = new System.Drawing.Size(247, 137);
            this.panelThrdDocuments.TabIndex = 7;
            // 
            // buttonThrdSetUpCards
            // 
            this.buttonThrdSetUpCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdSetUpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdSetUpCards.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdSetUpCards.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdSetUpCards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdSetUpCards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdSetUpCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdSetUpCards.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdSetUpCards.ForeColor = System.Drawing.Color.White;
            this.buttonThrdSetUpCards.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdSetUpCards.Image")));
            this.buttonThrdSetUpCards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSetUpCards.Location = new System.Drawing.Point(0, 92);
            this.buttonThrdSetUpCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdSetUpCards.Name = "buttonThrdSetUpCards";
            this.buttonThrdSetUpCards.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdSetUpCards.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdSetUpCards.TabIndex = 9;
            this.buttonThrdSetUpCards.TabStop = false;
            this.buttonThrdSetUpCards.Text = "     Карты наладки";
            this.buttonThrdSetUpCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSetUpCards.UseVisualStyleBackColor = false;
            this.buttonThrdSetUpCards.Click += new System.EventHandler(this.buttonThrdSetUpCards_Click);
            // 
            // buttonThrdKPVOTubeTime
            // 
            this.buttonThrdKPVOTubeTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdKPVOTubeTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdKPVOTubeTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdKPVOTubeTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdKPVOTubeTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdKPVOTubeTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdKPVOTubeTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdKPVOTubeTime.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdKPVOTubeTime.ForeColor = System.Drawing.Color.White;
            this.buttonThrdKPVOTubeTime.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdKPVOTubeTime.Image")));
            this.buttonThrdKPVOTubeTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdKPVOTubeTime.Location = new System.Drawing.Point(0, 46);
            this.buttonThrdKPVOTubeTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdKPVOTubeTime.Name = "buttonThrdKPVOTubeTime";
            this.buttonThrdKPVOTubeTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdKPVOTubeTime.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdKPVOTubeTime.TabIndex = 8;
            this.buttonThrdKPVOTubeTime.TabStop = false;
            this.buttonThrdKPVOTubeTime.Text = "     Производительность";
            this.buttonThrdKPVOTubeTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdKPVOTubeTime.UseVisualStyleBackColor = false;
            this.buttonThrdKPVOTubeTime.Click += new System.EventHandler(this.buttonThrdKPVOTubeTime_Click);
            // 
            // buttonThrdKPVOThread
            // 
            this.buttonThrdKPVOThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdKPVOThread.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdKPVOThread.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdKPVOThread.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdKPVOThread.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdKPVOThread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdKPVOThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdKPVOThread.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdKPVOThread.ForeColor = System.Drawing.Color.White;
            this.buttonThrdKPVOThread.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdKPVOThread.Image")));
            this.buttonThrdKPVOThread.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdKPVOThread.Location = new System.Drawing.Point(0, 0);
            this.buttonThrdKPVOThread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdKPVOThread.Name = "buttonThrdKPVOThread";
            this.buttonThrdKPVOThread.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdKPVOThread.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdKPVOThread.TabIndex = 7;
            this.buttonThrdKPVOThread.TabStop = false;
            this.buttonThrdKPVOThread.Text = "     КПВО по РНС";
            this.buttonThrdKPVOThread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdKPVOThread.UseVisualStyleBackColor = false;
            this.buttonThrdKPVOThread.Click += new System.EventHandler(this.buttonThrdKPVOThread_Click);
            // 
            // buttonThrdDocuments
            // 
            this.buttonThrdDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdDocuments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdDocuments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdDocuments.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdDocuments.Image = global::Cluster.UI.Properties.Resources.google_docs;
            this.buttonThrdDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdDocuments.Location = new System.Drawing.Point(0, 525);
            this.buttonThrdDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdDocuments.Name = "buttonThrdDocuments";
            this.buttonThrdDocuments.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdDocuments.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdDocuments.TabIndex = 6;
            this.buttonThrdDocuments.TabStop = false;
            this.buttonThrdDocuments.Text = "         Документация";
            this.buttonThrdDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdDocuments.UseVisualStyleBackColor = false;
            this.buttonThrdDocuments.Click += new System.EventHandler(this.buttonThrdDocuments_Click);
            // 
            // panelThrdFaqSubMenu
            // 
            this.panelThrdFaqSubMenu.BackColor = System.Drawing.Color.Teal;
            this.panelThrdFaqSubMenu.Controls.Add(this.buttonThrdSetUpProblems);
            this.panelThrdFaqSubMenu.Controls.Add(this.buttonThrdFAQProblems);
            this.panelThrdFaqSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThrdFaqSubMenu.Location = new System.Drawing.Point(0, 436);
            this.panelThrdFaqSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThrdFaqSubMenu.Name = "panelThrdFaqSubMenu";
            this.panelThrdFaqSubMenu.Size = new System.Drawing.Size(247, 89);
            this.panelThrdFaqSubMenu.TabIndex = 1;
            // 
            // buttonThrdSetUpProblems
            // 
            this.buttonThrdSetUpProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdSetUpProblems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdSetUpProblems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdSetUpProblems.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdSetUpProblems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdSetUpProblems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdSetUpProblems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdSetUpProblems.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdSetUpProblems.ForeColor = System.Drawing.Color.White;
            this.buttonThrdSetUpProblems.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdSetUpProblems.Image")));
            this.buttonThrdSetUpProblems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSetUpProblems.Location = new System.Drawing.Point(0, 46);
            this.buttonThrdSetUpProblems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdSetUpProblems.Name = "buttonThrdSetUpProblems";
            this.buttonThrdSetUpProblems.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdSetUpProblems.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdSetUpProblems.TabIndex = 8;
            this.buttonThrdSetUpProblems.TabStop = false;
            this.buttonThrdSetUpProblems.Text = "     Настройка станка";
            this.buttonThrdSetUpProblems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSetUpProblems.UseVisualStyleBackColor = false;
            this.buttonThrdSetUpProblems.Click += new System.EventHandler(this.buttonThrdSetUpProblems_Click);
            // 
            // buttonThrdFAQProblems
            // 
            this.buttonThrdFAQProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdFAQProblems.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdFAQProblems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdFAQProblems.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdFAQProblems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdFAQProblems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdFAQProblems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdFAQProblems.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdFAQProblems.ForeColor = System.Drawing.Color.White;
            this.buttonThrdFAQProblems.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdFAQProblems.Image")));
            this.buttonThrdFAQProblems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdFAQProblems.Location = new System.Drawing.Point(0, 0);
            this.buttonThrdFAQProblems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdFAQProblems.Name = "buttonThrdFAQProblems";
            this.buttonThrdFAQProblems.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdFAQProblems.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdFAQProblems.TabIndex = 7;
            this.buttonThrdFAQProblems.TabStop = false;
            this.buttonThrdFAQProblems.Text = "     Проблемы с резьбой";
            this.buttonThrdFAQProblems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdFAQProblems.UseVisualStyleBackColor = false;
            this.buttonThrdFAQProblems.Click += new System.EventHandler(this.buttonThrdFAQProblems_Click);
            // 
            // buttonThrdFaq
            // 
            this.buttonThrdFaq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdFaq.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdFaq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdFaq.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdFaq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdFaq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdFaq.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdFaq.Image = global::Cluster.UI.Properties.Resources.information;
            this.buttonThrdFaq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdFaq.Location = new System.Drawing.Point(0, 390);
            this.buttonThrdFaq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdFaq.Name = "buttonThrdFaq";
            this.buttonThrdFaq.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdFaq.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdFaq.TabIndex = 5;
            this.buttonThrdFaq.TabStop = false;
            this.buttonThrdFaq.Text = "         FAQ ";
            this.buttonThrdFaq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdFaq.UseVisualStyleBackColor = false;
            this.buttonThrdFaq.Click += new System.EventHandler(this.buttonThrdFaq_Click);
            // 
            // panelThrdToolsSubMenu
            // 
            this.panelThrdToolsSubMenu.BackColor = System.Drawing.Color.Teal;
            this.panelThrdToolsSubMenu.Controls.Add(this.buttonThrdSpeedSetUp);
            this.panelThrdToolsSubMenu.Controls.Add(this.buttonThrdProgramList);
            this.panelThrdToolsSubMenu.Controls.Add(this.buttonThrdMachineGeometry);
            this.panelThrdToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThrdToolsSubMenu.Location = new System.Drawing.Point(0, 258);
            this.panelThrdToolsSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThrdToolsSubMenu.Name = "panelThrdToolsSubMenu";
            this.panelThrdToolsSubMenu.Size = new System.Drawing.Size(247, 132);
            this.panelThrdToolsSubMenu.TabIndex = 4;
            // 
            // buttonThrdSpeedSetUp
            // 
            this.buttonThrdSpeedSetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdSpeedSetUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdSpeedSetUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdSpeedSetUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdSpeedSetUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdSpeedSetUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdSpeedSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdSpeedSetUp.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdSpeedSetUp.ForeColor = System.Drawing.Color.White;
            this.buttonThrdSpeedSetUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdSpeedSetUp.Image")));
            this.buttonThrdSpeedSetUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSpeedSetUp.Location = new System.Drawing.Point(0, 92);
            this.buttonThrdSpeedSetUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdSpeedSetUp.Name = "buttonThrdSpeedSetUp";
            this.buttonThrdSpeedSetUp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdSpeedSetUp.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdSpeedSetUp.TabIndex = 6;
            this.buttonThrdSpeedSetUp.TabStop = false;
            this.buttonThrdSpeedSetUp.Text = "     Скорость резания";
            this.buttonThrdSpeedSetUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdSpeedSetUp.UseVisualStyleBackColor = false;
            this.buttonThrdSpeedSetUp.Click += new System.EventHandler(this.buttonThrdSpeedSetUp_Click);
            // 
            // buttonThrdProgramList
            // 
            this.buttonThrdProgramList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdProgramList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdProgramList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdProgramList.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdProgramList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdProgramList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdProgramList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdProgramList.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdProgramList.ForeColor = System.Drawing.Color.White;
            this.buttonThrdProgramList.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdProgramList.Image")));
            this.buttonThrdProgramList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdProgramList.Location = new System.Drawing.Point(0, 46);
            this.buttonThrdProgramList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdProgramList.Name = "buttonThrdProgramList";
            this.buttonThrdProgramList.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdProgramList.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdProgramList.TabIndex = 5;
            this.buttonThrdProgramList.TabStop = false;
            this.buttonThrdProgramList.Text = "     Исходные программы";
            this.buttonThrdProgramList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdProgramList.UseVisualStyleBackColor = false;
            this.buttonThrdProgramList.Click += new System.EventHandler(this.buttonThrdProgramList_Click);
            // 
            // buttonThrdMachineGeometry
            // 
            this.buttonThrdMachineGeometry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdMachineGeometry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdMachineGeometry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdMachineGeometry.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdMachineGeometry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdMachineGeometry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdMachineGeometry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdMachineGeometry.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdMachineGeometry.ForeColor = System.Drawing.Color.White;
            this.buttonThrdMachineGeometry.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdMachineGeometry.Image")));
            this.buttonThrdMachineGeometry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdMachineGeometry.Location = new System.Drawing.Point(0, 0);
            this.buttonThrdMachineGeometry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdMachineGeometry.Name = "buttonThrdMachineGeometry";
            this.buttonThrdMachineGeometry.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdMachineGeometry.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdMachineGeometry.TabIndex = 4;
            this.buttonThrdMachineGeometry.TabStop = false;
            this.buttonThrdMachineGeometry.Text = "     Геометрия станка";
            this.buttonThrdMachineGeometry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdMachineGeometry.UseVisualStyleBackColor = false;
            this.buttonThrdMachineGeometry.Click += new System.EventHandler(this.buttonThrdMachineGeometry_Click);
            // 
            // buttonThrdTools
            // 
            this.buttonThrdTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdTools.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdTools.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdTools.Image = global::Cluster.UI.Properties.Resources.support;
            this.buttonThrdTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdTools.Location = new System.Drawing.Point(0, 212);
            this.buttonThrdTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdTools.Name = "buttonThrdTools";
            this.buttonThrdTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdTools.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdTools.TabIndex = 0;
            this.buttonThrdTools.TabStop = false;
            this.buttonThrdTools.Text = "         Инструменты";
            this.buttonThrdTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdTools.UseVisualStyleBackColor = false;
            this.buttonThrdTools.Click += new System.EventHandler(this.buttonThrdTools_Click);
            // 
            // panelThrdOffsetSubMenu
            // 
            this.panelThrdOffsetSubMenu.BackColor = System.Drawing.Color.Teal;
            this.panelThrdOffsetSubMenu.Controls.Add(this.buttonThrdOffsetView);
            this.panelThrdOffsetSubMenu.Controls.Add(this.buttonThrdOffsetAdd);
            this.panelThrdOffsetSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThrdOffsetSubMenu.Location = new System.Drawing.Point(0, 122);
            this.panelThrdOffsetSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThrdOffsetSubMenu.Name = "panelThrdOffsetSubMenu";
            this.panelThrdOffsetSubMenu.Size = new System.Drawing.Size(247, 90);
            this.panelThrdOffsetSubMenu.TabIndex = 2;
            // 
            // buttonThrdOffsetView
            // 
            this.buttonThrdOffsetView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdOffsetView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdOffsetView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdOffsetView.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdOffsetView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdOffsetView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdOffsetView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdOffsetView.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdOffsetView.ForeColor = System.Drawing.Color.White;
            this.buttonThrdOffsetView.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdOffsetView.Image")));
            this.buttonThrdOffsetView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffsetView.Location = new System.Drawing.Point(0, 46);
            this.buttonThrdOffsetView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdOffsetView.Name = "buttonThrdOffsetView";
            this.buttonThrdOffsetView.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdOffsetView.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdOffsetView.TabIndex = 1;
            this.buttonThrdOffsetView.TabStop = false;
            this.buttonThrdOffsetView.Text = "     Просмотреть оффсет";
            this.buttonThrdOffsetView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffsetView.UseVisualStyleBackColor = false;
            this.buttonThrdOffsetView.Click += new System.EventHandler(this.buttonThrdOffsetView_Click);
            // 
            // buttonThrdOffsetAdd
            // 
            this.buttonThrdOffsetAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdOffsetAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdOffsetAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdOffsetAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdOffsetAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdOffsetAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdOffsetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdOffsetAdd.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdOffsetAdd.ForeColor = System.Drawing.Color.White;
            this.buttonThrdOffsetAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonThrdOffsetAdd.Image")));
            this.buttonThrdOffsetAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffsetAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonThrdOffsetAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdOffsetAdd.Name = "buttonThrdOffsetAdd";
            this.buttonThrdOffsetAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonThrdOffsetAdd.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdOffsetAdd.TabIndex = 0;
            this.buttonThrdOffsetAdd.TabStop = false;
            this.buttonThrdOffsetAdd.Text = "     Добавить оффсет";
            this.buttonThrdOffsetAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffsetAdd.UseVisualStyleBackColor = false;
            this.buttonThrdOffsetAdd.Click += new System.EventHandler(this.buttonThrdOffsetAdd_Click);
            // 
            // buttonThrdOffset
            // 
            this.buttonThrdOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.buttonThrdOffset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThrdOffset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.buttonThrdOffset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonThrdOffset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThrdOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonThrdOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThrdOffset.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThrdOffset.Image = global::Cluster.UI.Properties.Resources.data_integration;
            this.buttonThrdOffset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffset.Location = new System.Drawing.Point(0, 76);
            this.buttonThrdOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThrdOffset.Name = "buttonThrdOffset";
            this.buttonThrdOffset.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonThrdOffset.Size = new System.Drawing.Size(247, 46);
            this.buttonThrdOffset.TabIndex = 0;
            this.buttonThrdOffset.TabStop = false;
            this.buttonThrdOffset.Text = "         Оффсет";
            this.buttonThrdOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThrdOffset.UseVisualStyleBackColor = false;
            this.buttonThrdOffset.Click += new System.EventHandler(this.buttonThrdOffset_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.panelLogo.BackgroundImage = global::Cluster.UI.Properties.Resources.Основной__Горизантальная__светлая__версия;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelLogo.Size = new System.Drawing.Size(247, 76);
            this.panelLogo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(248, 39);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1304, 841);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelChildFormName
            // 
            this.panelChildFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.panelChildFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChildFormName.Controls.Add(this.labelHeaderName);
            this.panelChildFormName.Controls.Add(this.buttonCloseChildForm);
            this.panelChildFormName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildFormName.Location = new System.Drawing.Point(248, 39);
            this.panelChildFormName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildFormName.Name = "panelChildFormName";
            this.panelChildFormName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildFormName.Size = new System.Drawing.Size(1304, 76);
            this.panelChildFormName.TabIndex = 1;
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseChildForm.BackgroundImage = global::Cluster.UI.Properties.Resources.close;
            this.buttonCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseChildForm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCloseChildForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(1258, 39);
            this.buttonCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(39, 30);
            this.buttonCloseChildForm.TabIndex = 0;
            this.buttonCloseChildForm.UseVisualStyleBackColor = false;
            this.buttonCloseChildForm.Visible = false;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cluster.UI.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizeApp.BackgroundImage = global::Cluster.UI.Properties.Resources.dropdown;
            this.buttonMinimizeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimizeApp.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMinimizeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeApp.Location = new System.Drawing.Point(1423, 5);
            this.buttonMinimizeApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimizeApp.Name = "buttonMinimizeApp";
            this.buttonMinimizeApp.Size = new System.Drawing.Size(39, 30);
            this.buttonMinimizeApp.TabIndex = 5;
            this.buttonMinimizeApp.UseVisualStyleBackColor = false;
            this.buttonMinimizeApp.Click += new System.EventHandler(this.buttonMinimizeApp_Click);
            // 
            // buttonFullScreenApp
            // 
            this.buttonFullScreenApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullScreenApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonFullScreenApp.BackgroundImage = global::Cluster.UI.Properties.Resources.maximize;
            this.buttonFullScreenApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFullScreenApp.FlatAppearance.BorderSize = 0;
            this.buttonFullScreenApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFullScreenApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonFullScreenApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullScreenApp.Location = new System.Drawing.Point(1465, 6);
            this.buttonFullScreenApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFullScreenApp.Name = "buttonFullScreenApp";
            this.buttonFullScreenApp.Size = new System.Drawing.Size(39, 30);
            this.buttonFullScreenApp.TabIndex = 4;
            this.buttonFullScreenApp.UseVisualStyleBackColor = false;
            this.buttonFullScreenApp.Click += new System.EventHandler(this.buttonFullScreenApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseApp.BackgroundImage = global::Cluster.UI.Properties.Resources.close;
            this.buttonCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Location = new System.Drawing.Point(1508, 6);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(39, 30);
            this.buttonCloseApp.TabIndex = 3;
            this.buttonCloseApp.UseVisualStyleBackColor = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // labelHeaderName
            // 
            this.labelHeaderName.AutoSize = true;
            this.labelHeaderName.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderName.ForeColor = System.Drawing.Color.Black;
            this.labelHeaderName.Location = new System.Drawing.Point(466, 29);
            this.labelHeaderName.Name = "labelHeaderName";
            this.labelHeaderName.Size = new System.Drawing.Size(278, 36);
            this.labelHeaderName.TabIndex = 1;
            this.labelHeaderName.Text = "Главный экран";
            this.labelHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelChildFormName);
            this.Controls.Add(this.buttonMinimizeApp);
            this.Controls.Add(this.buttonFullScreenApp);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSidaMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1533, 862);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1, 39, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLUSTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelThrdDocuments.ResumeLayout(false);
            this.panelThrdFaqSubMenu.ResumeLayout(false);
            this.panelThrdToolsSubMenu.ResumeLayout(false);
            this.panelThrdOffsetSubMenu.ResumeLayout(false);
            this.panelChildFormName.ResumeLayout(false);
            this.panelChildFormName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelSidaMenu;
        private System.Windows.Forms.Panel panelThrdOffsetSubMenu;
        private System.Windows.Forms.Button buttonThrdOffsetView;
        private System.Windows.Forms.Button buttonThrdOffsetAdd;
        private System.Windows.Forms.Button buttonThrdOffset;
        private System.Windows.Forms.Panel panelThrdFaqSubMenu;
        private System.Windows.Forms.Button buttonThrdSetUpProblems;
        private System.Windows.Forms.Button buttonThrdFAQProblems;
        private System.Windows.Forms.Button buttonThrdFaq;
        private System.Windows.Forms.Panel panelThrdToolsSubMenu;
        private System.Windows.Forms.Button buttonThrdSpeedSetUp;
        private System.Windows.Forms.Button buttonThrdProgramList;
        private System.Windows.Forms.Button buttonThrdMachineGeometry;
        private System.Windows.Forms.Button buttonThrdTools;
        private System.Windows.Forms.Panel panelThrdDocuments;
        private System.Windows.Forms.Button buttonThrdSetUpCards;
        private System.Windows.Forms.Button buttonThrdKPVOTubeTime;
        private System.Windows.Forms.Button buttonThrdKPVOThread;
        private System.Windows.Forms.Button buttonThrdDocuments;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelChildFormName;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonFullScreenApp;
        private System.Windows.Forms.Button buttonMinimizeApp;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Button buttonSettings;
        private PictureBox pictureBox1;
        private Panel panelLogo;
        private PictureBox pictureBox2;
        private Label labelHeaderName;
    }
}

