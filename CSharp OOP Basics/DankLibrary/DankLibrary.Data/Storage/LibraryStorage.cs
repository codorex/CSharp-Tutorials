using DankLibrary.Data.Data;
using DankLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DankLibrary.Data.Storage
{
    public class LibraryStorage
    {
        private List<Book> _books;
        private InMemoryContext _context = InMemoryContext.Instance;

        public LibraryStorage()
        {
            this._books = _context.Books;
        }

        public void AddBook(Book book)
        {
            if (book is Book)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
        }

        public void AddToStock(int id, int quantity)
        {
            Book book = GetValidatedBook(id);
            book.Quantity += quantity;
        }

        public double GetProductTotal(int id)
        {
            Book book = GetValidatedBook(id);

            return book.Price * book.Quantity;
        }

        public double GetInventoryTotal()
        {
            double total = 0.0;

            foreach (var book in this._context.Books)
            {
                total += book.Price * book.Quantity;
            }

            return total;
        }

        private Book GetValidatedBook(int id)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                throw new ArgumentOutOfRangeException($"No book with id = {book.Id}");
            }

            return book;
        }
    }
}
