using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GWS.Repository.Admin;
using GWS.Repository;
using GWS.Repository.Interfaces;
using GWS.Domain.Test;
using GWS.Domain.Admin;
using GWS.Filters;
using System.Threading;

namespace GWS.Controllers
{
    public class AdminController : Controller
    {

        private IBaseRepository _baserep;

        public AdminController(IBaseRepository rep)
        {
            _baserep = rep;
        }

        [SampleActionFilter]
        public ActionResult Index()
        {
           // var list = _baserep.GetAll<User>(); // UserRepository.GetAll();

           // Country obj = new Country() { CountryName = "Britan", CarMake = new List<CarMake>() { new CarMake() { Make = "BMW" } } };

           // BaseRepository.Save<Country>(obj);

            // Uncomment below to see the 1 second+ 
            // delay in action
            Thread.Sleep(1000);

            return View();
        }

        [SampleActionFilter]
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }
    }
}
