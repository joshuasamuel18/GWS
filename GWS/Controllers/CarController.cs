using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GWS.Models;

namespace GWS.Controllers
{
    public class CarController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
    }
}