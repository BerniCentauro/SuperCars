using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebInterface.SuperCarsService;

namespace WebInterface
{
    public partial class Default : System.Web.UI.Page
    {
        private VehicleServiceClient _client;
        private DataTable _table;

        protected void Page_Load(object sender, EventArgs e)
        {
            _client = new VehicleServiceClient();
            _table = new DataTable();
            _table.Columns.Add("Id");
            _table.Columns.Add("Título");
            _table.Columns.Add("Nombre");
            _table.Columns.Add("Teléfono");
            _table.Columns.Add("Precio");

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

            _table.Rows.Clear();
            foreach(Vehicle v in pages.Items)
            {
                DataRow row = _table.NewRow();
                row["Id"] = v.Id;
                row["Título"] = v.Title;
                row["Nombre"] = v.Name;
                row["Teléfono"] = v.Telephone;
                row["Precio"] = v.Price;

                _table.Rows.Add(row);
            }

            grdVehicles.DataSource = _table;
            grdVehicles.DataBind();
            
            lstPages.DataSource = GetPages(pages.TotalPages);
            lstPages.DataBind();
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

        protected void grdVehicles_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Console.WriteLine("Seleting!");
        }

        protected void grdVehicles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Console.WriteLine("Editing!");
        }

        protected void grdVehicles_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Console.WriteLine("Deleting!");
        }
    }
}