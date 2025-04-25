using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class Library
    {
        List<Person> Members { get; set; }
        List<Book> Books { get; set; }

        public Library()
        {
            Members = new List<Person>();
            Books = new List<Book>();
        }
        public bool AddBook(Book book)
        {
            if (Books.Contains(book))
            {


                return false;
            }
            Books.Add(book);
            return true;
        }


        public bool AddMember(Person member)
        {

            Members.Add(member);
            return true;
        }
    



    public Book FindBookById(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                {
                    return book; 
                }
            }
            return null; // ما وجدنا الكتاب
        }

        public Person FindMemberById(int id)
        {
            foreach (Person member in Members)
            {
                if (member.Id == id)
                {
                    return member; // وجدنا الكتاب
                }
            }
            return null; // ما وجدنا الكتاب
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Books:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("Members:");
            foreach (var member in Members)
            {
                Console.WriteLine($"ID: {member.Id}, Name: {member.Name}");
            }
        }


    }
}
