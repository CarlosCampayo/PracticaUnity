using PracticaContainer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaContainer.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryHospital repo;
        public HomeController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            return View(this.repo.GetEmpleados());
        }

       
    }
}