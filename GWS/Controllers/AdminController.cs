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

namespace GWS.Controllers
{
    public class AdminController : Controller
    {

        private IBaseRepository _baserep;

        public AdminController(IBaseRepository rep)
        {
            _baserep = rep;
        }

        public ActionResult Index()
        {
            var list = _baserep.GetAll<User>(); // UserRepository.GetAll();

           // Country obj = new Country() { CountryName = "Britan", CarMake = new List<CarMake>() { new CarMake() { Make = "BMW" } } };

           // BaseRepository.Save<Country>(obj);

            return View();
        }
    }
}
