using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoApp
{
    [PrimaryKey("VIN","Email")]
    internal class Sale
    {
        [StringLength(25)]

        public string Email {  get; set; }
        [StringLength(17)]
        public string VIN {  get; set; }
        public DateTime SaleDate { get; set; }
        public Customer Customer { get; set; }

        public Auto Auto { get; set; }

    }
}
