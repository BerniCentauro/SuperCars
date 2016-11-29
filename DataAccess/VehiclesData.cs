using Context;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class VehiclesData
    {
        public List<Vehicle> SelectAll()
        {
            using (SuperCarsModel ctx = new SuperCarsModel())
            {
                List<Vehicle> vehicleList = ctx.Vehicle.ToList();
                return vehicleList;
            }
        }

        public List<Vehicle> Page(int pageNumber, int rowsPerPage, out int totalRows)
        {
            using (SuperCarsModel ctx = new SuperCarsModel())
            {
                totalRows = ctx.Vehicle.Count();
                List<Vehicle> vehicleList = ctx.Vehicle
                    .ToList()
                    .Skip((pageNumber - 1) * rowsPerPage)
                    .Take(rowsPerPage)
                    .ToList();

                return vehicleList;
            }
        }

        public void Insert(Vehicle pVehicle)
        {
            using (SuperCarsModel ctx = new SuperCarsModel())
            {
                ctx.Vehicle.Add(pVehicle);
                ctx.SaveChanges();
            }
        }

        public void Update()
        {

        }

        public void Delete(int id)
        {

        }

    }
}
