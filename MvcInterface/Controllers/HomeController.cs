using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using Context;

namespace MvcInterface.Controllers
{
    public class HomeController : Controller
    {
        private VehiclesData _data = new VehiclesData();

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            int totalRows = 0;

            List<Vehicle> vehiclesList = _data.Page(page, 10, out totalRows);

            ViewBag.Vehicles = vehiclesList;
            return View();
        }
    }
}