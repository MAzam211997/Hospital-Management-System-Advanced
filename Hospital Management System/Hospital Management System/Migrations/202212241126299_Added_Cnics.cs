namespace Hospital_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Cnics : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Cnic", c => c.String());
            AddColumn("dbo.Patients", "Cnic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Cnic");
            DropColumn("dbo.Doctors", "Cnic");
        }
    }
}
