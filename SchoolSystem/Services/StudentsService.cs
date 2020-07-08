using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly ApplicationDbContext db;

        public StudentsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void CreateStudent(string firstName, string lastName, DateTime birthDate, string egn, string gender, string facultyNumber, int numberInClass)
        {
            Student student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                EGN = egn,
                Gender = gender,
                FacultyNumber = facultyNumber,
                NumberInClass = numberInClass
            };

            this.db.Students.Add(student);
            this.db.SaveChanges();
            
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var allStudents = this.db.Students.Select(s => new Student
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Gender = s.Gender,
                FacultyNumber = s.FacultyNumber,
                NumberInClass = s.NumberInClass
            }).ToList();
            return allStudents;
        }
    }
}
