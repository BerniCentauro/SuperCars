using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebInterface.SuperCarsService;

namespace WebInterface.Home
{
    public partial class Default : System.Web.UI.Page
    {
        private VehicleServiceClient _client = new VehicleServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        public void LoadVehicles()
        {
            int page = 1;

            if (Request.QueryString.Get("page") != null)
            {
                page = Convert.ToInt32(Request.QueryString.Get("page"));
            }

            PaginationOfVehicleRHchMops pages = _client.Page(page, 10);
            lstVehicles.DataSource = pages.Items;
            lstVehicles.DataBind();
        }
    }
}