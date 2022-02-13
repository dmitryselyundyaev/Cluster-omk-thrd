using Cluster.BL;
using Cluster.BL.Model.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class Main : Form
    {
        readonly ClusterDbContext database;
        public Main()
        {

            InitializeComponent();
            CustomizeDesing();
            database = new ClusterDbContext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Main design and core functions
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;
        /// <summary>
        /// Border sizing and frame moving
        /// </summary>
        /// <param name="m"></param>


        protected override void WndProc(ref Message m)
        {
            //none border moving
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HT_CAPTION;
            }
            //none border sizing
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
        }
        /// <summary>
        /// Current form.
        /// </summary>
        private Form ActiveForm = null;
        /// <summary>
        /// Opening child form method.
        /// </summary>
        /// <param name="childForm">Form to open</param>
        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            buttonCloseChildForm.Visible = true;
        }
        /// <summary>
        /// Initialize design things.
        /// </summary>
        private void CustomizeDesing()
        {
            panelThrdOffsetSubMenu.Visible = false;
            panelThrdToolsSubMenu.Visible = false;
            panelThrdFaqSubMenu.Visible = false;
            panelThrdDocuments.Visible = false;
        }
        /// <summary>
        /// If sub menu is visible == close it.
        /// </summary>
        /// 
        public void ChildFormHeaderName()
        {
            if(ActiveButton != null)
            {
                labelHeaderName.Text = ActiveButton.Text;
            }
            else
            {
                labelHeaderName.Text = "Главный экран";
            }
        }
        private void HideSubMenu()
        {
            if (panelThrdOffsetSubMenu.Visible == true)
            {
                panelThrdOffsetSubMenu.Visible = false;
            }
            if (panelThrdToolsSubMenu.Visible == true)
            {
                panelThrdToolsSubMenu.Visible = false;
            }
            if (panelThrdFaqSubMenu.Visible == true)
            {
                panelThrdFaqSubMenu.Visible = false;
            }
            if (panelThrdDocuments.Visible == true)
            {
                panelThrdDocuments.Visible = false;
            }
        }
        /// <summary>
        /// Open sub menu.
        /// </summary>
        /// <param name="subMenu">Sub menu to open.</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        public Button ActiveButton;
        public void ButtonHoldColor(Button btn)
        {
            if (btn == buttonCloseChildForm)
            {
                ActiveButton.BackColor = Color.FromArgb(37, 94, 126);
                ActiveButton.Enabled = true;
                ActiveButton = null;
                ChildFormHeaderName();
            }
            else if (ActiveButton != null)
            {
                ActiveButton.Enabled = true;
                ActiveButton.BackColor = Color.FromArgb(37, 94, 126);
                ActiveButton = btn;
                ActiveButton.BackColor = System.Drawing.Color.Maroon;
                ActiveButton.Enabled = false;
                ChildFormHeaderName();
            }
            else
            {
                ActiveButton = btn;
                ActiveButton.BackColor = System.Drawing.Color.Maroon;
                ActiveButton.Enabled = false;
                ChildFormHeaderName();
            }

            
            
        }
        private void buttonThrdOffset_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThrdOffsetSubMenu);
        }

        private void buttonThrdTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThrdToolsSubMenu);
        }

        private void buttonThrdFaq_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThrdFaqSubMenu);
        }

        private void buttonThrdDocuments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelThrdDocuments);
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            ButtonHoldColor(buttonCloseChildForm);
            HideSubMenu();
            buttonCloseChildForm.Visible = false;
        }

        private void buttonFullScreenApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void buttonMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelChildFormName_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Click's

        private void buttonThrdOffsetAdd_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdOffsetAdd);
            OpenChildForm(new ThrdCreateOffset<OffsetData>(database.OffsetDatas, database));
        }

        private void buttonThrdOffsetView_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdOffsetView);
            OpenChildForm(new ThrdViewOffset<OffsetData>(database.OffsetDatas, database));
        }

        private void buttonThrdMachineGeometry_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdMachineGeometry);
            OpenChildForm(new ThrdGeometry<OffsetData>(database.OffsetDatas, database));
        }

        private void buttonThrdProgramList_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdProgramList);
            OpenChildForm(new ThrdProgram());
        }

        private void buttonThrdSpeedSetUp_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdSpeedSetUp);
            OpenChildForm(new ThrdCuttingSpeed());
        }

        private void buttonThrdFAQProblems_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdFAQProblems);
            OpenChildForm(new ThrdFaqThread());
        }

        private void buttonThrdSetUpProblems_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdSetUpProblems);
            OpenChildForm(new ThrdFaqMachine());
        }

        private void buttonThrdKPVOThread_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdKPVOThread);
            OpenChildForm(new ThrdKpvo());
        }

        private void buttonThrdKPVOTubeTime_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdKPVOTubeTime);
            OpenChildForm(new ThrdPlanPerfomance());
        }

        private void buttonThrdSetUpCards_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonThrdSetUpCards);
            OpenChildForm(new ThrdSetUpCard());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ButtonHoldColor(buttonSettings);
            OpenChildForm(new MainSetting());
        }
        #endregion
    }
}
