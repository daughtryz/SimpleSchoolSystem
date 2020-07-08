using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Services.Contracts;
using SchoolSystem.ViewModels.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }
        public IActionResult GetAllStudents()
        {
            var allStudents = this.studentsService.GetAllStudents();
            var studentViewModel = new AllStudentsViewModel
            {
                Students = allStudents
            };
            
                return this.View(studentViewModel);
        }

        [HttpPost]
        public IActionResult CreateStudent(string firstName, string lastName, DateTime birthDate, string egn, string gender, string facultyNumber, int numberInClass)
        {
            this.studentsService.CreateStudent(firstName, lastName, birthDate, egn, gender, facultyNumber, numberInClass);

            return this.Redirect("/");
        }

        public IActionResult CreateStudent()
        {
            return this.View();
        }

    }
}
