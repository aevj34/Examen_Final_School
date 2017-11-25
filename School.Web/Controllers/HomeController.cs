using School.Application;
using School.Application.Dto;
using School.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class HomeController : Controller
    {

          private SchoolApplicationService schoolApplicationService = new SchoolApplicationService() ;

          public ActionResult Index()
          {

              List<Student> students = new List<Student>();
              students = schoolApplicationService.GetStudents();

              return View(students);
          }
          

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}