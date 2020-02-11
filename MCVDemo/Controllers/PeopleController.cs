using MCVDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCVDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Raf", LastName = "Ruci", Age = 40 });
            people.Add(new PersonModel { FirstName = "Woj", LastName = "Ruc", Age = 15 });


            
            return View(people);
        }
    }
}