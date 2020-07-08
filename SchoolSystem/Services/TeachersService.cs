using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Services
{
    public class TeachersService : ITeachersService
    {
        private readonly ApplicationDbContext db;

        public TeachersService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void CreateTeacher(string firstName, string lastName, DateTime birthDate, string egn, string gender, string subject)
        {
            Teacher teacher = new Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                EGN = egn,
                Gender = gender,
                Subject = subject
            };
            this.db.Teachers.Add(teacher);
            this.db.SaveChanges();
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            var allTeachers = this.db.Teachers.Select(t => new Teacher
            {
                FirstName = t.FirstName,
                LastName = t.LastName,
                Gender = t.Gender,
                Subject = t.Subject
            }).ToList();

            return allTeachers;

        }
    }
}
