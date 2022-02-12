using SQLite.CodeFirst;
using System.Data.Entity;

namespace Cluster.BL.Model
{
    public class ClusterDbContextInitializer : SqliteDropCreateDatabaseAlways<ClusterDbContext>

    {
        public ClusterDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(ClusterDbContext context)
        {
        }
    }
}
