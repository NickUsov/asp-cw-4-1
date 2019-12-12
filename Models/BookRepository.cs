using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class BookRepository : IRepository
    {
        public int Count => books.Count;
        IList<Book> books = new List<Book>();
        public void Add(Book book)
        {
            books.Add(book);
        }
    }
}