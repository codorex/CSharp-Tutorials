using DankLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankLibrary.Data.Data
{
    public class InMemoryContext
    {
        private static InMemoryContext _instance;

        private List<Book> _books;

        public static InMemoryContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InMemoryContext();
                }

                return _instance;
            }
        }

        public InMemoryContext()
        {
            this._books = new List<Book>();
        }

        public List<Book> Books
        {
            get => this._books;
        }

        public void SaveChanges()
        {
            foreach (var book in this._books.Where(b => b.Id == 0))
            {
                book.Id = this._books.Max(b => b.Id) + 1;
            }
        }
    }
}
