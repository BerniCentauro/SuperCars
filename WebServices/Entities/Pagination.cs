using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServices.Entities
{
    [DataContract]
    public class Pagination<T>
    {
        [DataMember]
        public List<T> Items { get; set; }

        [DataMember]
        public int RowsPerPage { get; set; }

        [DataMember]
        public int PageNumber { get; set; }

        [DataMember]
        public int TotalRows { get; set; }

        [DataMember]
        public int TotalPages { get; set; }
    }
}