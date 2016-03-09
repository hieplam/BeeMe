namespace SeeMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        JobTitle = c.String(),
                        AvatarUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Artwork",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ArtistId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Url = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artist", t => t.ArtistId, cascadeDelete: true)
                .Index(t => t.ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artwork", "ArtistId", "dbo.Artist");
            DropIndex("dbo.Artwork", new[] { "ArtistId" });
            DropTable("dbo.Artwork");
            DropTable("dbo.Artist");
        }
    }
}
