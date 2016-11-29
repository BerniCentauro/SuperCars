using Context;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInterface.Controllers
{
    public class VehiclesController : Controller
    {
        private VehiclesData _data = new VehiclesData();

        // GET: Vehicles
        public ActionResult Index(int page = 1)
        {
            int totalRows = 0;

            List<Vehicle> vehiclesList = _data.Page(page, 10, out totalRows);

            ViewBag.Vehicles = vehiclesList;

            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Vehicle pVehicle)
        {
            try
            {
                _data.Insert(pVehicle);
                Response.Redirect("~/Vehicles");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Ha ocurrido un error";
                return View();
            }

        }
    }
}