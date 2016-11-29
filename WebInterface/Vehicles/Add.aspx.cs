using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebInterface.SuperCarsService;

namespace WebInterface.Vehicles
{
    public partial class Add : System.Web.UI.Page
    {
        private VehicleServiceClient _client;

        protected void Page_Load(object sender, EventArgs e)
        {
            _client = new VehicleServiceClient();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Vehicle newVehicle = new Vehicle();
            newVehicle.Title = tbxTitle.Value;
            newVehicle.Description = tbxDescription.Value;
            newVehicle.Price = Convert.ToDecimal(tbxPrice.Value);
            newVehicle.Type = tbxType.Value;
            newVehicle.Brand = tbxBrand.Value;
            newVehicle.Model = tbxModel.Value;
            newVehicle.Year = Convert.ToInt32(tbxYear.Value);
            newVehicle.Color = tbxColor.Value;
            newVehicle.Status = tbxStatus.Value;
            newVehicle.Url = tbxUrl.Value;
            newVehicle.Name = tbxName.Value;
            newVehicle.Email = tbxEmail.Value;
            newVehicle.Telephone = Convert.ToInt32(tbxTelephone.Value);

            _client.Add(newVehicle);

            Response.Redirect("/Vehicles");
        }
    }
}