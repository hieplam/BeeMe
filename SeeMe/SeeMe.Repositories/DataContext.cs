using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SeeMe.Repositories.DomainModels;

namespace SeeMe.Repositories
{
    public class DataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }

        public DataContext() : base("SeeMe")
        {
            //Refer to http://stackoverflow.com/questions/14033193/entity-framework-provider-type-could-not-be-loaded/19130718#19130718 
            //If no below code, will make error.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
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
