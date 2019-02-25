namespace TestMapper
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class User
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string Mag { get; set; }
        public Product Product { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<string> BooksToRead { get; set; }
    }
}
