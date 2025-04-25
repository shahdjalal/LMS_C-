using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class Book
    {
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool  IsAvailiable { get; set; } = true;

        public override string ToString()
        {
            return $"Id:{Id}  ,  Title:{Title}  , Author Name :{AuthorName} , IsAvailiable : {IsAvailiable} ";
        }
        


    }
}
