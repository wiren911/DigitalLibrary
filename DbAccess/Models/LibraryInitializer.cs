using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess.Models
{
    public class LibraryInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
                new Book {Title ="", ISBN ="" , Year =  },
                new Book {}
            };
            books.ForEach (b => context.Books.Add(b)) ;
            context.SaveChanges();

            var genres = new List<Genre>
            {
                new Genre {},
                new Genre {}
            };
        }
    }
}
