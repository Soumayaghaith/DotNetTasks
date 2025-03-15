using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreA1.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(CourseTopic))]
        public int TopId { get; set; }

        public Topic CourseTopic { get; set; } //I didn't create a navigational property in the topic module as this is one-to-one
    }
}
