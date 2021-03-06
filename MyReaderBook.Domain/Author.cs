using System;
using System.Collections.Generic;
using System.Text;

namespace MyReaderBook.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author()
        {
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

}
