namespace ExhibitionsRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exhibitions",
                c => new
                    {
                        ExhibitionId = c.Guid(nullable: false),
                        ExhibitionName = c.String(),
                        Location = c.String(),
                        OrganizerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ExhibitionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exhibitions");
        }
    }
}
