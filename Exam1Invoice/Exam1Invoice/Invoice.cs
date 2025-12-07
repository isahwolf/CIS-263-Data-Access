using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1Invoice
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public string CustEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Shipping { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Total { get; set; }
        public string? CardNumber { get; set; }
    }
}
