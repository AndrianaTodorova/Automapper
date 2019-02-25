using System.Collections.Generic;

namespace TestMapper
{
    public class UserDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public UserDTO()
        {
            this.Books = new List<BookDTO>();
        
        }
        public ProductDTO Product { get; set; }

        public ICollection<BookDTO> Books { get; set; }

        public ICollection<string> BooksToRead { get; set; }
    }
}
