using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestMapper
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var booksToRead = new List<string>();
            var stock = new List<int>();
            var authors = new string[] { "John", "Benjamin" };
            var authors2 = new string[] { "Maya", "Selena" };
            booksToRead.Add("Harry Potter");
            booksToRead.Add("Rocky");
            stock.Add(5);
            stock.Add(10);
            var mapper = new Mapper();
            var books = new List<Book>();
            books.Add(new Book()
            {
                AuthorName = "Mila Yovovich",
                Content = "biography",
                Title = "Best of me",
                Message = new Message()
                {
                    Name = "i love this book"
                },
                Authors = authors,
                Messages = new Message[] { new Message() { Name = "amazing book" } }

            });
            books.Add(new Book()
            {
                AuthorName = "Michael Liskov",
                Content = "history",
                Title = "Good vibes",
                Message = new Message()
                {
                    Name = "very simple and interesting book"
                },
                Authors = authors2,
                Messages = new Message[] { new Message() { Name = "this book should be the best of the year" } }
            });
            var source = new User()
            {
                Name = "Ana",
                Age = 21,
                Address = "Varshava str.",
                Product = new Product()
                {
                    Name = "Water",
                    Price = 12.2M,
                    Stock = stock
                },
                Books = books,
                BooksToRead = booksToRead,
         
            };

            var user = mapper.CreateMappedObject<UserDTO>(source);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("My names is: {0} and I am {1} years old", user.Name, user.Age));
            sb.AppendLine(string.Format("I love reading books and my favourite one is {0}. I want to read: {1}", user.Books.First().Title, string.Join(", ", user.BooksToRead)));


            Console.WriteLine(sb.ToString());
        }
    }
}
