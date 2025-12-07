using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BooksApp
{
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string? MidName { get; set; }
        public string LastName { get; set; }
    }
}
