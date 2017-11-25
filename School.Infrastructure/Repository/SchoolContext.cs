using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repository
{
    public class SchoolContext: DbContext
    {

        public SchoolContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Student> Students { get; set; }

        public void RunMigrations()
        {
            using (var context = new SchoolContext(Funciones.GetConnectionString()))
            {
                var customers = from c in context.Students
                                select c;

                if (customers.Any()) return;
                addStudent(context);
            }
        }


        void addStudent(SchoolContext context)
        {
            var Students = from c in context.Students
                             select c;

            if (Students.Any()) return;
            context.Students.Add(new Student { FirstName = "Anthony", LastName = "Vargas" });
            context.SaveChanges();
        }

      public class Student
    {
          public Student()
          {
              
          }

        public virtual int StudentId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

    }


    }
}
