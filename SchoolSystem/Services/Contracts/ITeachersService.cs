using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Contracts
{
    public interface ITeachersService
    {
        public void CreateTeacher(string firstName, string lastName, DateTime birthDate, string egn, string gender, string subject);


        public IEnumerable<Teacher> GetAllTeachers();

    }
}
