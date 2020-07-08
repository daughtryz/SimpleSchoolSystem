using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Services.Contracts;
using SchoolSystem.ViewModels.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeachersService teachersService;

        public TeachersController(ITeachersService teachersService)
        {
            this.teachersService = teachersService;
        }
        public IActionResult GetAllTeachers()
        {
            var allTeachers = this.teachersService.GetAllTeachers();
            var studentViewModel = new AllTeachersViewModel
            {
                Teachers = allTeachers
            };
            return this.View(studentViewModel);
        }

        [HttpPost]
        public IActionResult CreateTeacher(string firstName, string lastName, DateTime birthDate, string egn, string gender, string subject)
        {
            this.teachersService.CreateTeacher(firstName, lastName, birthDate, egn, gender, subject);
            return this.Redirect("/");
        }
        
        public IActionResult CreateTeacher()
        {
            return this.View();
        }

    }
}
