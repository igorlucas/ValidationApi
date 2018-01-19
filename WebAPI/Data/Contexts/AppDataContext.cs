using System.Data.Entity;
    
namespace Data.Contexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("ConnectionString")
        {
            //DropCreateDatabaseIfModelChanges<AppDataContext> initializer =
            //new DropCreateDatabaseIfModelChanges<AppDataContext>();

            //Database.SetInitializer<AppDataContext>(initializer);
        }
    }
}
