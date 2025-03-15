using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(DepartmentManager))]
        public int Ins_Id { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; }

        [InverseProperty(nameof(Instructor.InstructorDepartment))]
        public ICollection<Instructor> Instructors { get; set; }
        [InverseProperty(nameof(Instructor.ManagedDeparment))]
        public Instructor DepartmentManager { get; set; }
    }
}
