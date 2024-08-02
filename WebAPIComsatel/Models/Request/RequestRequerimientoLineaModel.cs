using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestRequerimientoLineaModel
    {

        public string itemcode { get; set; }
        public string itemname { get; set; }
        public string reqdate { get; set; }
        public string shipdate { get; set; }
        public string reqty { get; set; }
        public string quantity { get; set; }
        public string unitprice { get; set; }
        public string taxcode { get; set; }
        public string costingcode { get; set; }
        public string costingcode2 { get; set; }
        public string costingcode3 { get; set; }
        public string costingcode4 { get; set; }
        public string costingcode5 { get; set; }
        public string project { get; set; }
        public string whscode { get; set; }
        public string basetype { get; set; }
        public string baseentry { get; set; }
        public string baseline { get; set; }


    }
}