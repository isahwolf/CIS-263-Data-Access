using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    [PrimaryKey("ISBN","AuthorId")]
    internal class AuthorTitle
    {
        [StringLength(13)]
        public string ISBN { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public Title Title { get; set; }
    }
}
