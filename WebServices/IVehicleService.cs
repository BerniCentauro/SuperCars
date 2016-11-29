using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServices.Entities;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVehicleService" in both code and config file together.
    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        List<Vehicle> Get();

        [OperationContract]
        Pagination<Vehicle> Page(int pageNumber, int rowsPerPage);

        [OperationContract]
        void Add(Vehicle vehicle);
    }
}
