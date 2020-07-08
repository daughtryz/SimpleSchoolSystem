using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModels.Students
{
    public class AllStudentsViewModel
    {
        public IEnumerable<Student> Students { get; set; }
    }
}
