using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster.BL.Model
{
    public class ClusterDbContextInitializer: SqliteDropCreateDatabaseAlways<ClusterDbContext>

    {
        public ClusterDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(ClusterDbContext context)
        {
        }
    }
}
