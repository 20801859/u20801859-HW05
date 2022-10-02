using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20801859_HW05.Models
{
    public class StudentViewModel
    {
        public List<Students> Students { get; set; }
        public Books Book { get; set; }
        public List<Class> Class { get; set; }
    }
}