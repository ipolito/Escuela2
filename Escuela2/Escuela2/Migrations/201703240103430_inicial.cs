namespace Escuela2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        pkAlumno = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sApellido = c.String(nullable: false, unicode: false),
                        sGrupo = c.String(nullable: false, unicode: false),
                        sImagen = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkAlumno);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumno");
        }
    }
}
