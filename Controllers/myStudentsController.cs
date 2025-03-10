using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsiziGumede2StudyGroup.Controllers
{
    public class myStudentsController : Controller
    {
        // GET: myStudents
        public ActionResult StudentsView()
        {
            List<Models.myStudents> students = new List<Models.myStudents>();

            students.Add(new Models.myStudents { StudentNumber = "u24784606", Name = "Msizi", Surname = "Gumede", Email = "u24784606@tuks.co.za", myLink =("~/HTML/Msizi.html") });
            students.Add(new Models.myStudents { StudentNumber = "u24634400", Name = "Boitshoko", Surname = "Mphahlele", Email = "u24634400@tuks.co.za", myLink = "~/HTML/Boitshoko.html" });
            students.Add(new Models.myStudents { StudentNumber = "u24717739", Name = "Ritshidze", Surname = "Nedzimauli", Email = "u24717739@tuks.co.za", myLink = "~/HTML/Ritshidze1.html" });
            students.Add(new Models.myStudents { StudentNumber = "u24924718", Name = "Gundo", Surname = "Ndou", Email = "u24924718@tuks.co.za", myLink = "~/HTML/Gundo.html" });
            students.Add(new Models.myStudents { StudentNumber = "u24768929", Name = "Lethabo", Surname = "Moses", Email = "u24768929@tuks.co.za", myLink = "~/HTML/Lethabo.html" });


            return View(students);
        }
    }
}