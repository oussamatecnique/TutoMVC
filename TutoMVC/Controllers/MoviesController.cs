using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutoMVC.Models;
using TutoMVC.ViewModels;

namespace TutoMVC.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return Content("aaaaaaaaaaa");
        }
        // GET: Movies
        public ActionResult Random()
        {
            Movie M= new Movie() { Id = 1, Name = "Shrek" };
            List<Customer> List = new List<Customer>()
            {
                new Customer {name="Oussama"},
                new Customer {name="Imad"},
            };
            return View(new RandomMovieViewModel()
            {
                Movie = M,
                Customers = List
            });
        }
        public ActionResult Edit(int? id)
        {
            return Content("id= " + id);
        }
        [Route("Movies/Date")]
        public ActionResult ByReleaseDate(int? year,int? month)
        {
            return Content(year+"/"+month);
        }

    }
}