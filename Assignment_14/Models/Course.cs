using System;
using System.Collections.Generic;

namespace Assignment_14.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Fee { get; set; }
        public DateTime? StartDate { get; set; }
        public int? CategoryName { get; set; }

        public virtual Category? CategoryNameNavigation { get; set; }
    }
}
