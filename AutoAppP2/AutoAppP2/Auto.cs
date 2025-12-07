using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAppP2
{
    public class Auto
    {
        [Key]
        [StringLength(17)]
        public string VIN { get; set; }
        [StringLength(25)]
        public string Make { get; set; } = "Ford";
        [StringLength(25)]
        public string Model { get; set; }
        [Range(1900, 2050)]
        public int Year { get; set; }
        [Range(0, double.MaxValue)]
        public double Cost { get; set; }


        public string BankId { get; set; }
        public Bank Bank { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
