using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
using Context;
using WebServices.Entities;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VehicleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VehicleService.svc or VehicleService.svc.cs at the Solution Explorer and start debugging.
    public class VehicleService : IVehicleService
    {
        private VehiclesData dataVehicles = new VehiclesData();

        public List<Vehicle> Get()
        {
            try
            {
                List<Vehicle> vehicles = dataVehicles.SelectAll();
                return vehicles;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public Pagination<Vehicle> Page(int pageNumber, int rowsPerPage)
        {
            try
            {
                int totalRows = 0;
                List<Vehicle> vehicles = dataVehicles.Page(pageNumber, rowsPerPage, out totalRows);

                Pagination<Vehicle> pagination = new Pagination<Vehicle>
                {
                    Items = vehicles,
                    PageNumber = pageNumber,
                    RowsPerPage = rowsPerPage,
                    TotalPages = totalRows / rowsPerPage,
                    TotalRows = totalRows
                };

                return pagination;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Vehicle vehicle)
        {
            try
            {
                dataVehicles.Insert(vehicle);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
