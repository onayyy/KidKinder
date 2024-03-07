namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookASeats", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookASeats", "Email", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
