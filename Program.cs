using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Title: ");
            string _title = Console.ReadLine();
            Title title = new Title(_title);

            Console.Write("Author: ");
            string _author = Console.ReadLine();
            Author author = new Author(_author);

            Console.Write("Content: ");
            string _content = Console.ReadLine();
            Content content = new Content(_content);

            Book book = new Book(title, author, content);

            book.Show();

            Console.ReadKey();
        }
    }
}
