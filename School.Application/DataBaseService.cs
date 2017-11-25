using School.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application
{

    public class DataBaseService
    {
        public void CreateSchool(string nameOrConnectionString)
        {
            SchoolContext school = new SchoolContext(nameOrConnectionString);
            school.RunMigrations();
        }

    }
}
