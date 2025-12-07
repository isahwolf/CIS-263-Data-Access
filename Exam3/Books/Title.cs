using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books
{
    internal class Title
    {
        [Key]
        [StringLength(13)]
        public string ISBN {  get; set; }
        [StringLength(100)]
        public string BookTitle {  get; set; }
        public int Edition { get; set; } = 1;
        public int Year { get; set; } = DateTime.Now.Year;

        //public int PublisherId { get; set; }
        //public Publisher Publisher { get; set; }

    }
}
