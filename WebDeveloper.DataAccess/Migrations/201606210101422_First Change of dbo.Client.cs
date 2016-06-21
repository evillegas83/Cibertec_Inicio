namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChangeofdboClient : DbMigration
    {
        public override void Up()
        {
            //Para que no se pierda la data
            RenameColumn("dbo.Client", "Apellidos", "LastName");
            //AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "Apellidos");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Client", "Apellidos", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "LastName");
            RenameColumn("dbo.Client", "LastName", "Apellidos");
        }
    }
}
