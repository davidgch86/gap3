using System.Data.Entity;

namespace GAP.Model
{
    public class GAPContext : DbContext
    {
        #region Constructor
        public GAPContext()
            : base("GAPContext")
        {
            DbConfiguration();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GAPContext, Migrations.Configuration>());
        }
        #endregion

        #region DbSet
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<UsersGAP> UserGAP { get; set; }
        #endregion

        #region Config
        private void DbConfiguration()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.ValidateOnSaveEnabled = true;
        }
        #endregion

    }
}
