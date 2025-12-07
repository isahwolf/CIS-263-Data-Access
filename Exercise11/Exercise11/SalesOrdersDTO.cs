using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class SalesOrdersDTO
    {
        [Required]
        public int SalesOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalDue { get; set; }
    }
}
