using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using Context;
using MvcInterface.Models;

namespace MvcInterface.Controllers
{
    public class HomeController : Controller
    {
        private VehiclesData _data = new VehiclesData();
        private const int ROWS_PER_PAGE = 1;

        // GET: Home
        public ActionResult Index(int page = 1)
        {
            int totalRows = 0;

            List<Vehicle> vehicleList = _data.Page(page, ROWS_PER_PAGE, out totalRows);

            Pagination<Vehicle> objPagination = new Pagination<Vehicle>();
            objPagination.Items = vehicleList;
            objPagination.PageNumber = page;
            objPagination.RowsPerPage = ROWS_PER_PAGE;
            objPagination.TotalRows = totalRows;
            objPagination.TotalPages = totalRows / ROWS_PER_PAGE;

            List<int> pagesList = GetPages(objPagination.TotalPages);

            ViewBag.Pages = pagesList;

            return View(objPagination);
        }

        public ActionResult Add()
        {
            return View();
        }
        
        private List<int> GetPages(int totalPages)
        {
            List<int> pages = new List<int>();

            for (int i = 1; i <= totalPages; i++)
            {
                pages.Add(i);
            }

            return pages;
        }
    }
}