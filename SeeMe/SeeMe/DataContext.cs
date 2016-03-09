using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SeeMe.DomainModels;

namespace SeeMe
{
    public class DataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        public DataContext() : base("SeeMe")
        {
            Configuration.LazyLoadingEnabled = false;
            //Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DataContext).Assembly);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}