namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover','Comedy',06-02-2009, GETDATE(),5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard','Action',01-02-2010, GETDATE(),10)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator','Action',06-02-2007, GETDATE(),1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story','Family',06-02-1997, GETDATE(),15)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic','Romance',06-02-1999, GETDATE(),100)");
        }
        
        public override void Down()
        {
        }
    }
}
