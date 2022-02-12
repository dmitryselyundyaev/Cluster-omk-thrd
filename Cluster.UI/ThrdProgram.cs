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
            string[] folderContent = Directory.GetFiles("/Projects/Cluster/Cluster.BL/CncProgramms/CH1");
            SelectedPath = "/Projects/Cluster/Cluster.BL/CncProgramms/CH1";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void ch2_Click(object sender, System.EventArgs e)
        {
            DesignButtons(ch2);
            listBoxFolderContent.Items.Clear();
            string[] folderContent = Directory.GetFiles("/Projects/Cluster/Cluster.BL/CncProgramms/CH2");
            SelectedPath = "/Projects/Cluster/Cluster.BL/CncProgramms/CH2";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void tableAndPlug_Click(object sender, System.EventArgs e)
        {
            DesignButtons(tableAndPlug);
            listBoxFolderContent.Items.Clear();
            string[] folderContent = Directory.GetFiles("/Projects/Cluster/Cluster.BL/CncProgramms/TABLE+PLUG");
            SelectedPath = "/Projects/Cluster/Cluster.BL/CncProgramms/TABLE+PLUG";
            foreach (var file in folderContent)
            {
                listBoxFolderContent.Items.Add(Path.GetFileName(file));
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
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
    }
}
