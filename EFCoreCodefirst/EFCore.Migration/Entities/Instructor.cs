using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodefirst.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
      public string? Name { get; set; }

        public int? OfficeId { get; set; }
        public Office? Office { get; set; }

        public ICollection<Section> sections { get; set; }  = new List<Section>();
    }

}
