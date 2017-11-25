using School.Application.Dto;
using School.Domain.Model;
using School.Domain.Repostories;
using School.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application
{
    public class SchoolApplicationService
    {

     private IStudentRepository iStudentRepository = new StudentRepository() ;

	public List<Student> GetStudents(){

       List<Student> students = new List<Student>();
       students = iStudentRepository.GetStudents();
        return students;

    }

	}

}
