using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Title
    {
        [Key]
        [StringLength(13)]
        public string ISBN { get; set; }

        [StringLength(100)]
        public string BookTitle { get; set; }

        public int Edtion { get; set; }

        public int Year { get; set; }
    }
}
