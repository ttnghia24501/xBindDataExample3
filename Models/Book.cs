using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBindDataExample3.Models
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }

    }
    public class BookManager
    { 
    public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage="Assets/1.jpg"});
            books.Add(new Book { BookId = 2, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/6.jpg" });
            books.Add(new Book { BookId = 7, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/7.jpg" });
            books.Add(new Book { BookId = 8, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/8.jpg" });
            books.Add(new Book { BookId = 9, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/9.jpg" });
            books.Add(new Book { BookId = 10,Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/10.jpg" });

            return books;
        }
    }
}
