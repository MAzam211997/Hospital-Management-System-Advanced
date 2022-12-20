namespace Hospital_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OperationTheatres", "AppointmentId", c => c.Int());
            CreateIndex("dbo.OperationTheatres", "AppointmentId");
            AddForeignKey("dbo.OperationTheatres", "AppointmentId", "dbo.Appointments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OperationTheatres", "AppointmentId", "dbo.Appointments");
            DropIndex("dbo.OperationTheatres", new[] { "AppointmentId" });
            AlterColumn("dbo.OperationTheatres", "AppointmentId", c => c.Int(nullable: false));
        }
    }
}
