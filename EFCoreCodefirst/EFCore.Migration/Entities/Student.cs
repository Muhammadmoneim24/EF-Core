using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodefirst.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public ICollection<Section> Sections { get; set; }= new List<Section>();
        //public ICollection<Enrollments> Enrollments { get; set; }= new List<Enrollments>();


    }
}
