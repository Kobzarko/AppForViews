using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppForViews.Models
{
    public class BookInitializer:DropCreateDatabaseIfModelChanges<BookContext>
    {
        // не забыть добавить в Global.asax для запуска приложения
        // Database.SetInitializer(new BookInitializer());
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and piece", Author = "L. Tolstoy", Price = 150 });
            db.Books.Add(new Book { Name = "Fairy Tails", Author = "Brother Grimm", Price = 250 });
            db.Books.Add(new Book { Name = "Lettuce", Author = "Lady Gaga", Price = 180 });
            db.Books.Add(new Book { Name = "Toilet Bowl", Author = "Bananas Eggs", Price = 80 });
        }
    }
}