using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdSetUpCard : Form
    {
        public string SelectedPath;
        public ThrdSetUpCard()
        {

            InitializeComponent();
            listBoxListOfPrograms.Items.Clear();
            string[] folderContent = Directory.GetFiles(@".\\SetUpCards");
            SelectedPath = @".\\SetUpCards";
            foreach (var file in folderContent)
            {
                listBoxListOfPrograms.Items.Add(Path.GetFileName(file));
            }
        }

        private void buttonOpenDocument_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedPath) && listBoxListOfPrograms.SelectedItem != null)
            {
                Process.Start(@".\\SetUpCards\\"+listBoxListOfPrograms.SelectedItem.ToString());
            }
        }
    }
}
