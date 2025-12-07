using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoApp
{
    public class Bank
    {
        [Key]
        public string BankId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public List<Auto> Autos { get; set; }
    }
}
