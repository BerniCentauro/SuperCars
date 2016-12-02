using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInterface.Models
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }

        public int RowsPerPage { get; set; }

        public int PageNumber { get; set; }

        public int TotalRows { get; set; }

        public int TotalPages { get; set; }
    }
}