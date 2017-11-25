using School.Domain.Model;
using School.Domain.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repository
{
    public class StudentRepository:IStudentRepository
    {
        public List<Domain.Model.Student> GetStudents()
        {

            SchoolContext context = new SchoolContext(Funciones.GetConnectionString());

            var Students = from c in context.Students
                            select c;

            return context.Students.Select(r => new Domain.Model.Student
            {
                StudentId = r.StudentId,
                FirstName = r.FirstName,
                LastName = r.LastName
            }).ToList();

        }

    }
}
