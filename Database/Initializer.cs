using System;
using BookKeeping.Models;
namespace BookKeeping.Database
{
    public class Initializer
    {
        public static void Initialize (BookContext context)
        { 
            
             context.Database.EnsureCreated();
            if (context.Books.Any())
            {
                return;
            }
            var vBooks = new books[]
            {
                new books{BookID=01,Title="Web Development",Price=20, Genre="Informative", Publishingyear=2020},
                new books{BookID=02,Title="Ios Development",Price=20, Genre="Informative", Publishingyear=2021},
                new books{BookID=01,Title="Harry Poter",Price=20, Genre="Fantasy", Publishingyear=2004},
                new books{BookID=01,Title="Romieo Juliet",Price=20, Genre="Romantic", Publishingyear= 1900},
            };
            foreach (books b in vBooks)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

            var authors = new Author[]
            {
                new Author{AuthorId=110,AuthorName="David",GenreSpecialty="WebDevelopment"},
                new Author{AuthorId=119,AuthorName="John",GenreSpecialty="SwiftProgramming"},
                new Author{AuthorId=116,AuthorName="xyz",GenreSpecialty="Fantasy"},
                new Author{AuthorId=115,AuthorName="Shakespear",GenreSpecialty="Romace"}

            };
            foreach ( Author a in authors )
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();
        }
    }
}

