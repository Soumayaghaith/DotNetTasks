using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    [PrimaryKey(nameof(Ins_Id),nameof(Course_Id))]
    internal class Course_Inst
    {
        
        public int Ins_Id { get; set; }
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

    }
}
