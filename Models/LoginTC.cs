using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Models
{
    internal class LoginTC
    {
        [Key]
        public long TeacherID { get; set; }
        [StringLength(100)]
        public string TeacherPW { get; set; }
    }
}
