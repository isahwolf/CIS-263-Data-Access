using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutosMVC.Models
{
    public class Bank
    {
        [Key]
        [StringLength(9)]
        public string RoutingNum { get; set; }
        [StringLength(50)]

        public string Name { get; set; }
        [StringLength(2)]

        public string State { get; set; }
    }
}
