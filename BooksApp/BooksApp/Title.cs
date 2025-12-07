using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BooksApp
{
    internal class Title
    {
        [Key]
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public int EditionNumber { get; set; }
        public string Copyright { get; set; }

    }
}
