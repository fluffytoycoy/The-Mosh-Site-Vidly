namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetusers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.AspNetUsers",
              c => new
              {
                  Id = c.String(nullable: false, maxLength: 128),
                  Email = c.String(maxLength: 256),
                  EmailConfirmed = c.Boolean(nullable: false),
                  PasswordHash = c.String(),
                  SecurityStamp = c.String(),
                  PhoneNumber = c.String(),
                  PhoneNumberConfirmed = c.Boolean(nullable: false),
                  TwoFactorEnabled = c.Boolean(nullable: false),
                  LockoutEndDateUtc = c.DateTime(),
                  LockoutEnabled = c.Boolean(nullable: false),
                  AccessFailedCount = c.Int(nullable: false),
                  UserName = c.String(nullable: false, maxLength: 256),
              })
              .PrimaryKey(t => t.Id)
              .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
    "dbo.AspNetUserRoles",
    c => new
    {
        UserId = c.String(nullable: false, maxLength: 128),
        RoleId = c.String(nullable: false, maxLength: 128),
    })
    .PrimaryKey(t => new { t.UserId, t.RoleId })
    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
    .Index(t => t.UserId)
    .Index(t => t.RoleId);
        }
        
        public override void Down()
        {
        }
    }
}
