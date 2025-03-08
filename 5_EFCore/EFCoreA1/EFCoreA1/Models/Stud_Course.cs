using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    [Table("Stud_Coourses")]
    internal class Stud_Course
    {
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        [Range(0,100)]
        public int Grade { get; set; }
    }
}
