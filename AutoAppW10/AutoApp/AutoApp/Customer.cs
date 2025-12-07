using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoApp
{
    internal class Customer
    {
        [Key]
        [StringLength(25)]

        public string Email {  get; set; }
        [StringLength(20)]

        public string LastName { get; set; }
        [StringLength(20)]

        public string FirstName { get; set; }
        [StringLength(20)]

        public string PhoneNumber { get; set; }
        public List<Sale> Sales { get; set; }

    }
}
