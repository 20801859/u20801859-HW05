using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20801859_HW05.Models
{
    public class BookDetailsVM
    {
        public Books Book { get; set; }
        public List<Borrows> BorrowedBooks { get; set; }
    }
}