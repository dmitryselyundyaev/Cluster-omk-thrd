using Cluster.BL.Model.Tables;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace Cluster.BL
{
    public class ClusterDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ClusterDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            _ = sqlGenerator.Generate(model.StoreModel);

        }

        public DbSet<ChannelOne> ChannelOneDatas { get; set; }
        public DbSet<ChannelTwo> ChannelTwoDatas { get; set; }
        public DbSet<Macro> Macros { get; set; }
        public DbSet<UserData> UsersData { get; set; }
        public DbSet<ProductType> ProductsTypes { get; set; }
        public DbSet<OffsetData> OffsetDatas { get; set; }

    }
}
