using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class User : Person
    {



        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public bool BorrowBook(Book book)
        {
            Console.WriteLine($"Trying to borrow book: {book.Title}");

            if (book.IsAvailiable && !BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Add(book);
                book.IsAvailiable = false;
                Console.WriteLine("Book borrowed successfully!");
                Console.WriteLine($"BorrowedBooks count now: {BorrowedBooks.Count}");
                return true;
            }

            Console.WriteLine("Book not available or already borrowed.");
            return false;
        }


        public bool ReturnBook(Book book)
        {
            Console.WriteLine($"Trying to return book: {book.Title}");
            Console.WriteLine($"BorrowedBooks count: {BorrowedBooks.Count}");

            foreach (var b in BorrowedBooks)
            {
                Console.WriteLine($"- Borrowed: {b.Title}, Id: {b.Id}");
            }
            
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailiable = true;
                Console.WriteLine("Book returned successfully!");
                return true;
            }
            else
            {
                Console.WriteLine("Book not found in borrowed list.");
            }

            return false;
        }


        public override string DisplayInfo()
        {
            if (BorrowedBooks.Count == 0)
            {
                return "No borrowed books.";
            }

            return "Borrowed Books:\n" + string.Join("\n", BorrowedBooks);
        }



    }
}
