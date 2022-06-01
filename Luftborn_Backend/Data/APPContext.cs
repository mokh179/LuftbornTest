namespace Luftborn.Data
{
    public class APPContext:DbContext
    {
        public APPContext(DbContextOptions<APPContext> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }

    }
}
