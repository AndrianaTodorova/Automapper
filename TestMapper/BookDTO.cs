using System;
using System.Collections.Generic;
using System.Text;

namespace TestMapper
{
    public class BookDTO
    {
        public BookDTO()
        {

        }
        public string Title { get; set; }
        public string Content { get; set; }

        public string[] Authors { get; set; }
        public MessageDTO Message { get; set; }

        public MessageDTO[] Messages { get; set; }
    }
}
