using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Models
{
    internal class Login
    {
        [Key]
        public long StudentID { get; set; }
        [StringLength(100)]
        public string StudentPW { get; set; }
        public long UserRole { get; set; } 

    }
}
