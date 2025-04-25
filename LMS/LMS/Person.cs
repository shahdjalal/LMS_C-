using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
   abstract class Person
    {
     

        public int Id { get;  set;}
        public string Name { get; set; }

        public abstract string DisplayInfo();
    }

 
        
}
