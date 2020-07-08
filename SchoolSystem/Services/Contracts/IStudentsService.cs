using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Services.Contracts
{
    public interface IStudentsService
    {
        public void CreateStudent(string firstName,string lastName,DateTime birthDate,string egn,string gender,string facultyNumber,int numberInClass);


        public IEnumerable<Student> GetAllStudents();

    }
}
