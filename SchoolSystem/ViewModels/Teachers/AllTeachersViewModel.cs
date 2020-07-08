using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModels.Teachers
{
    public class AllTeachersViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
