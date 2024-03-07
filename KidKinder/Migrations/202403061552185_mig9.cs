namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ParentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Parents");
            DropTable("dbo.Galleries");
        }
    }
}
