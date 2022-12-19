namespace Hospital_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OperationTheatre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OperationTheatres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        MedicalTestId = c.Int(nullable: false),
                        OperationDate = c.DateTime(),
                        Problem = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.MedicalTests", t => t.MedicalTestId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId)
                .Index(t => t.MedicalTestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OperationTheatres", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.OperationTheatres", "MedicalTestId", "dbo.MedicalTests");
            DropForeignKey("dbo.OperationTheatres", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.OperationTheatres", new[] { "MedicalTestId" });
            DropIndex("dbo.OperationTheatres", new[] { "DoctorId" });
            DropIndex("dbo.OperationTheatres", new[] { "PatientId" });
            DropTable("dbo.OperationTheatres");
        }
    }
}
