namespace bizzart_proj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.Int(nullable: false),
                        DeathDate = c.Int(nullable: false),
                        BirthPlace = c.String(),
                        Biography = c.String(),
                        Picture_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pictures", t => t.Picture_Id)
                .Index(t => t.Picture_Id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                        ArtistId = c.Int(nullable: false),
                        WriteDate = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Size = c.Single(nullable: false),
                        PictureHistory = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EmploymentDate = c.DateTime(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artists", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Pictures", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Pictures", new[] { "Department_Id" });
            DropIndex("dbo.Artists", new[] { "Picture_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Galleries");
            DropTable("dbo.Departments");
            DropTable("dbo.Pictures");
            DropTable("dbo.Artists");
        }
    }
}
