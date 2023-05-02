namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenUserRelation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Tokens", "UserId");
            AddForeignKey("dbo.Tokens", "UserId", "dbo.Users", "Uname", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            AlterColumn("dbo.Tokens", "UserId", c => c.String(nullable: false));
        }
    }
}
