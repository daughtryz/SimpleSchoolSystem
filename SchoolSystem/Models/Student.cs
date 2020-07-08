using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Student : Person
    {
        public string Id { get; set; }

        public Student()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string FacultyNumber { get; set; }

        public int NumberInClass { get; set; }
    }
}
