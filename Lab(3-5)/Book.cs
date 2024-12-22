using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_5_
{
    // Task3

    public class Book
    {
        private static int _id;

        public  int Id { get; set; }
        public int PublicationYear { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(string name,string author,int publicationYear)
        {
            Id = ++_id;
            PublicationYear = publicationYear;
            Name = name;
            Author = author;

        }
        public Book() 
        {

        }   

    }
}
