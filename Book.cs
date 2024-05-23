using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP2
{
    class Book
    {
        public Title title;
        public Author author;
        public Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title: {title}");
            Console.ResetColor();
        }
    }
    class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Author: {author}");
            Console.ResetColor();
        }
    }
    class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {content}");
            Console.ResetColor();
        }
    }
}
