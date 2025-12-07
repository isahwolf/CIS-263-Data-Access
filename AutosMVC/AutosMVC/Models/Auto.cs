using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutosMVC.Models
{
    public class Auto
    {
        [Key]
        [StringLength(17)]
        public string VIN { get; set; }
        [StringLength(25)]
        public string Make { get; set; }
        [StringLength(25)]
        public string Model { get; set; }
        [Range(1950, 2050)]
        public int Year { get; set; }
        public double Cost { get; set; }
        [StringLength(9)]
        [ForeignKey("Bank")]
        public string RoutingNum { get; set; }
        public Bank? Bank { get; set; }
    }
}
