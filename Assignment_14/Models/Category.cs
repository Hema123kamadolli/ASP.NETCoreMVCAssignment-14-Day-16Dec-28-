using System;
using System.Collections.Generic;

namespace Assignment_14.Models
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string CourseCategory { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
    }
}
