﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20801859_HW05.Models
{
    public class Borrows
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public string TakenDate { get; set; }
        public string BroughtDate { get; set; }
        public string StudentName { get; set; }
    }
}