using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public decimal Salary { get; set; }
        [StringLength(50,MinimumLength=10)]
        public string Address { get; set; }
        public int HourRate { get; set; }

        [ForeignKey(nameof(InstructorDepartment))]
        public int Dept_Id { get; set; }

        public Department InstructorDepartment { get; set; } = null!;

        [InverseProperty(nameof(Department.DepartmentManager))]
        public Department ManagedDeparment { get; set; }

        public ICollection<Course_Inst> InstructorCourses { get; set; } = new HashSet<Course_Inst>();




    }
}
