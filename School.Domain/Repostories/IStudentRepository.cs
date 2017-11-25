using School.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Repostories
{
    public interface IStudentRepository
    {
         List<Student> GetStudents();

    }
}
