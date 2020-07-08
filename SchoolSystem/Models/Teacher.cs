using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Teacher : Person
    {
        public string Id { get; set; }

        public Teacher()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Subject { get; set; }
    }
}
