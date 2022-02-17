using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdKpvo : Form
    {
        public string SelectedPath;
        public ThrdKpvo()
        {
            InitializeComponent();
            listBoxListOfPdfs.Items.Clear();
            string[] folderContent = Directory.GetFiles(@".\\Kpvo");
            SelectedPath = @".\\Kpvo";
            foreach (var file in folderContent)
            {
                listBoxListOfPdfs.Items.Add(Path.GetFileName(file));
            }
        }
        private void buttonOpenDocument_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedPath) && listBoxListOfPdfs.SelectedItem != null)
            {
                Process.Start(@".\\Kpvo\\" + listBoxListOfPdfs.SelectedItem.ToString());
            }
        }
    }
}
