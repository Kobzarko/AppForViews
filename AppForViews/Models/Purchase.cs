using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppForViews.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}