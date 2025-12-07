using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AutoApp
{
    [PrimaryKey("Email", "VIN")]
    public class Sale
    {
        public string Email { get; set; }
        public string VIN { get; set; }
        public DateTime SaleDate { get; set; }

        public Customer Customer { get; set; }
        public Auto Auto { get; set; }
    }
}
