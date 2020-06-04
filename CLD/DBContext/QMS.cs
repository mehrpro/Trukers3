using System.Data.Entity;


namespace CLD
{
    public class QMS : DbContext
    {
        public QMS():base("name=QMS") { }
        public DbSet<ExistenceGroup> ExistenceGroups { get; set; }
        public DbSet<ExistenceBass> ExistenceBasses { get; set; }
        public DbSet<GroupsProperty> GroupsProperties { get; set; }


    }
}