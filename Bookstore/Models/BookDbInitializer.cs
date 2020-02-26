using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class BookDbInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext database)
        {
            database.Books.Add(new Book { Name = "Атлант расправил плечи", Author = "Айн Рэнд", Price = 58 });
            database.Books.Add(new Book { Name = "Самый богатый человек в Вавилоне", Author = "Джордж Клейсон", Price = 10 });
            database.Books.Add(new Book { Name = "Война и мир", Author = "Л.Толстой", Price = 15 });
            database.Books.Add(new Book { Name = "CLR via C#", Author = "Джеффри Рихтер", Price = 50 });
            database.Books.Add(new Book { Name = "C# 4.0: полное руководство", Author = "Герберт Шилдт", Price = 14 });

            base.Seed(database);
        }
    }
}