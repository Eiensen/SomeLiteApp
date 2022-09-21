namespace SomeLiteApp.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Smartphone>? Smartphones { get; set; }
    }    
}
