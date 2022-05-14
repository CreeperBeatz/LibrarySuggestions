﻿namespace LibraryWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Book_BookId = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorId)
                .ForeignKey("dbo.Books", t => t.Book_BookId)
                .Index(t => t.Book_BookId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "Book_BookId", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_BookId" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
