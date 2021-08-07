namespace ExhibitionsRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable_Organizer_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizers",
                c => new
                    {
                        OrganizerId = c.Guid(nullable: false),
                        OrganizerName = c.String(),
                    })
                .PrimaryKey(t => t.OrganizerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Organizers");
        }
    }
}
