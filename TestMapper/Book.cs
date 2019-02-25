using System;
using System.Collections.Generic;
using System.Text;

namespace TestMapper
{
    public class Book
    {
        public Book()
        {

        }
        public string Content { get; set; }

        public string Title { get; set; }
        public string AuthorName { get; set; }

        public Message Message { get; set; }

        public string[] Authors { get; set; }

       public Message[] Messages { get; set; }
    }
}
