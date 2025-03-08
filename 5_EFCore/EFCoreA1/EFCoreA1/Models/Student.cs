using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20,MinimumLength = 3)]
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }

        [Range(25,40)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}
