namespace MolvenoLakeResort.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        Email = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        UserLevel = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Name = c.String(),
                        Created = c.DateTimeOffset(nullable: false, precision: 7),
                        Altered = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedBy = c.Guid(nullable: false),
                        AlteredBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataUsers");
        }
    }
}
