namespace Spital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpitalDB3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        IdDoctor = c.Guid(nullable: false, identity: true),
                        Nume = c.String(),
                    })
                .PrimaryKey(t => t.IdDoctor);
            
            CreateTable(
                "dbo.Pacients",
                c => new
                    {
                        IdPacient = c.Guid(nullable: false, identity: true),
                        Nume = c.String(),
                        Buget = c.Int(nullable: false),
                        Doctor_IdDoctor = c.Guid(),
                        Tratament_IdTratament = c.Guid(),
                    })
                .PrimaryKey(t => t.IdPacient)
                .ForeignKey("dbo.Doctors", t => t.Doctor_IdDoctor)
                .ForeignKey("dbo.Trataments", t => t.Tratament_IdTratament)
                .Index(t => t.Doctor_IdDoctor)
                .Index(t => t.Tratament_IdTratament);
            
            CreateTable(
                "dbo.Trataments",
                c => new
                    {
                        IdTratament = c.Guid(nullable: false, identity: true),
                        Nume = c.String(),
                        Doctor_IdDoctor = c.Guid(),
                    })
                .PrimaryKey(t => t.IdTratament)
                .ForeignKey("dbo.Doctors", t => t.Doctor_IdDoctor)
                .Index(t => t.Doctor_IdDoctor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trataments", "Doctor_IdDoctor", "dbo.Doctors");
            DropForeignKey("dbo.Pacients", "Tratament_IdTratament", "dbo.Trataments");
            DropForeignKey("dbo.Pacients", "Doctor_IdDoctor", "dbo.Doctors");
            DropIndex("dbo.Trataments", new[] { "Doctor_IdDoctor" });
            DropIndex("dbo.Pacients", new[] { "Tratament_IdTratament" });
            DropIndex("dbo.Pacients", new[] { "Doctor_IdDoctor" });
            DropTable("dbo.Trataments");
            DropTable("dbo.Pacients");
            DropTable("dbo.Doctors");
        }
    }
}
