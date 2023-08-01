using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("***All Books***");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            Console.WriteLine("----------------");
        }

        public Book SearchBookById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }

        public Book SearchBookByTitle(string title)
        {
            return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }


}
