using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAppP2
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
