using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Model
{
   public class Student
    {

       public Student()
       {
          
       }

       public int StudentId {get; set;}
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public List<Course> courses { get; set; }

       public String getFullName()
       {
           return this.FirstName + " " + this.LastName;
       }


    }
}
