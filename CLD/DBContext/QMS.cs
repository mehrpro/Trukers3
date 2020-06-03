using System.Data.Entity;


namespace CLD
{
    public class QMS : DbContext
    {
        public QMS():base("name=QMS") { }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<SalesSerial> SalesSerials { get; set; }
        public DbSet<TruckDriver> TruckDrivers { get; set; }

    }
}