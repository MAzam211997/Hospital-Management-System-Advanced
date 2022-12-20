namespace Hospital_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MedicalTests", "ChargesPerTest", c => c.Double(nullable: false));
            AddColumn("dbo.OperationTheatres", "AppointmentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OperationTheatres", "AppointmentId");
            DropColumn("dbo.MedicalTests", "ChargesPerTest");
        }
    }
}
