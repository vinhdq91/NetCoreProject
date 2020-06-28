using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMan.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Authors { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
        public string Publisher { get; set; }
        public string Description { get; set; }
    }
}
