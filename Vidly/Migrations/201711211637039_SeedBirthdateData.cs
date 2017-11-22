namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBirthdateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '01-01-1990' WHERE Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
