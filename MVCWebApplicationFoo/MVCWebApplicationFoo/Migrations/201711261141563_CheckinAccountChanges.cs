namespace MVCWebApplicationFoo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckinAccountChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "FirstName", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "FirstName", c => c.String(nullable: false));
        }
    }
}
