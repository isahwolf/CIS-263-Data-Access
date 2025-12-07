using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    public class Absence
    {
        [Key]
        public int Id { get; set; }

        public DateTime AbsDate { get; set; }

        public float Hours { get; set; }

        public string Excused { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

}
