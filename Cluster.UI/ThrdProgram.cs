using System;
using System.IO;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdProgram : Form
    {
        public ThrdProgram()
        {
            InitializeComponent();
        }
        public string SelectedPath;
        public void DesignButtons(Button btn)
        {
            ch1.BackColor = default;
            ch2.BackColor = default;
            tableAndPlug.BackColor = default;
            btn.BackColor = System.Drawing.Color.Maroon;
            
        }
        private void ch1_Click(object sender, System.EventArgs e)
        {
            DesignButtons(ch1);
            listBoxFolderContent.Items.Clear();
            string[] folderContent = Directory.GetFiles("./CncPrograms/CH1");
            SelectedPath = "./CncPrograms/CH1";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void ch2_Click(object sender, System.EventArgs e)
        {
            DesignButtons(ch2);
            listBoxFolderContent.Items.Clear();
            string[] folderContent = Directory.GetFiles("./CncPrograms/CH2");
            SelectedPath = "./CncPrograms/CH2";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void tableAndPlug_Click(object sender, System.EventArgs e)
        {
            DesignButtons(tableAndPlug);
            listBoxFolderContent.Items.Clear();
            string[] folderContent = Directory.GetFiles("./CncPrograms/TABLE+PLUG");
            SelectedPath = "./CncPrograms/TABLE+PLUG";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void buttonSelectProgramm_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedPath) && listBoxFolderContent.SelectedItem != null)
            {
                listBoxProgrammText.Items.Clear();
                string[] lines = File.ReadAllLines(SelectedPath+ "/" + listBoxFolderContent.SelectedItem.ToString());

                foreach (string r in lines)
                {
                    listBoxProgrammText.Items.Add(r);
                }
            }

        }

        private void buttonChangePlug_Click(object sender, System.EventArgs e)
        {
            try
            {
                tableAndPlug_Click(sender, e);
                listBoxFolderContent.SelectedItem = "O9001";
                buttonSelectProgramm_Click(sender,e);
                listBoxProgrammText.SelectedItem = "N0160M64(PLUG INFLATE)";
                
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}
