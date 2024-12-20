﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Book
    {
        public int BookId {  get; set; }
        public string ?Title { get; set; }
        public string ?Author { get; set; }
        public string ?ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public DateTime PublicationDate { get; set; }
        public ICollection<Loan> ?loans { get; set; }


    }
}
