using Assignment20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___20
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Library library = new Library();

                while (true)
                {
                    Console.WriteLine("\n**Library Management System**");
                    Console.WriteLine("1. Add a book");
                    Console.WriteLine("2. View all books");
                    Console.WriteLine("3. Search by ID");
                    Console.WriteLine("4. Search by title");
                    Console.WriteLine("5. Exit");

                    Console.Write("\nEnter your choice: ");
                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Book ID: ");
                            int bookId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Author Name: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Book Genre: ");
                            string genre = Console.ReadLine();
                            Book newBook = new Book
                            {
                                BookId = bookId,
                                Title = title,
                                Author = author,
                                Genre = genre,
                                IsAvailable = true 
                            };
                            library.AddBook(newBook);
                            Console.WriteLine("Book added successfully.");
                            break;
                        case 2:
                            library.ViewAllBooks();
                            break;
                        case 3:
                            Console.Write("Enter Book ID to search: ");
                            int searchBookId = int.Parse(Console.ReadLine());
                            Book bookById = library.SearchBookById(searchBookId);
                            if (bookById != null)
                            {
                                Console.WriteLine($"ID: {bookById.BookId}, Title: {bookById.Title}, Author: {bookById.Author}, Genre: {bookById.Genre}, Available: {(bookById.IsAvailable ? "Yes" : "No")}");
                            }
                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter Book Title to search: ");
                            string searchTitle = Console.ReadLine();
                            Book bookByTitle = library.SearchBookByTitle(searchTitle);
                            if (bookByTitle != null)
                            {
                                Console.WriteLine($"ID: {bookByTitle.BookId}, Title: {bookByTitle.Title}, Author: {bookByTitle.Author}, Genre: {bookByTitle.Genre}, Available: {(bookByTitle.IsAvailable ? "Yes" : "No")}");
                            }
                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exiting Library Management System.");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                            break;
                    }
                Console.ReadKey();
                }
        }
    }

}


