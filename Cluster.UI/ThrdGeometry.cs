using Cluster.BL;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdGeometry<T> : Form
        where T : class
    {
        readonly ClusterDbContext database;
        readonly DbSet<T> set;
        public ThrdGeometry(DbSet<T> set, ClusterDbContext db)
        {
            database = new ClusterDbContext();
            InitializeComponent();
            this.database = db;
            this.set = set;
            set.Load();
        }
        private void AxisCheckButton_Click(object sender, System.EventArgs e)
        {
            using (var cont = new ClusterDbContext())
            {
                var channelOneDataX = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel1.X2).Average();
                Channel1X.Text = string.Format("{0:N4}", channelOneDataX);
                // Based on finishing pass.
                var channelOneDataY = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel1.Y4).Average();
                Channel1Y.Text = string.Format("{0:N4}", channelOneDataY);
                // Based on zajust.
                var channelOneDataZ = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Macro.Zajust).Average();
                Channel1Z.Text = string.Format("{0:N4}", channelOneDataZ);
                // Based on chamfer.
                var channelTwoDataX = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel2.X2).Average();
                Channel2X.Text = string.Format("{0:N4}", channelTwoDataX);
                // Based on facing.
                var channelTwoDataZ = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).Take(10).Select(u => u.Channel2.Z1).Average();
                Channel2Z.Text = string.Format("{0:N4}", channelTwoDataZ);
            }

        }
    }
}
