using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barista.api.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }

        public string DueDate { get; set; }
    }
}
