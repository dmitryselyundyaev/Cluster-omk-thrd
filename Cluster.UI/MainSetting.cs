using System.IO;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class MainSetting : Form
    {
        public MainSetting()
        {
            InitializeComponent();
        }


        private void buttonRestoreDataBase_Click(object sender, System.EventArgs e)
        {
            if (textBoxPassword.Text == "yfkflxbr")
            {
                folderBrowserDialog.Description = "Укажите путь к файлу";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceDir = folderBrowserDialog.SelectedPath.ToString();
                    string backupDir = @".\";
                    try
                    {
                        File.Copy(Path.Combine(sourceDir, "Cluster.sqlite"), Path.Combine(backupDir, "Cluster.sqlite"));
                    }
                    catch (IOException)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Введите пароль");
            }
        }

        private void buttonBackUpDataBase_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Укажите путь для сохранения";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceDir = @".\";
                string backupDir = folderBrowserDialog.SelectedPath.ToString();
                try
                {
                    File.Copy(Path.Combine(sourceDir, "Cluster.sqlite"), Path.Combine(backupDir, "Cluster.sqlite"));
                }
                catch (IOException)
                {

                }
            }

        }

    }
}
