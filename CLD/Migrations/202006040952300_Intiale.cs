namespace CLD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intiale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExistenceBasses",
                c => new
                    {
                        ExistenceId = c.Int(nullable: false, identity: true),
                        ExistenceName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ExistenceId);
            
            CreateTable(
                "dbo.ExistenceGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(nullable: false, maxLength: 100),
                        ExistenceBass_ExistenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroupID)
                .ForeignKey("dbo.ExistenceBasses", t => t.ExistenceBass_ExistenceId, cascadeDelete: true)
                .Index(t => t.ExistenceBass_ExistenceId);
            
            CreateTable(
                "dbo.GroupsProperties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                        Property = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                        ExistenceGroup_GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyID)
                .ForeignKey("dbo.ExistenceGroups", t => t.ExistenceGroup_GroupID, cascadeDelete: true)
                .Index(t => t.ExistenceGroup_GroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupsProperties", "ExistenceGroup_GroupID", "dbo.ExistenceGroups");
            DropForeignKey("dbo.ExistenceGroups", "ExistenceBass_ExistenceId", "dbo.ExistenceBasses");
            DropIndex("dbo.GroupsProperties", new[] { "ExistenceGroup_GroupID" });
            DropIndex("dbo.ExistenceGroups", new[] { "ExistenceBass_ExistenceId" });
            DropTable("dbo.GroupsProperties");
            DropTable("dbo.ExistenceGroups");
            DropTable("dbo.ExistenceBasses");
        }
    }
}
