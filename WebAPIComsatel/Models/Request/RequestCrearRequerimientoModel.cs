using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestCrearRequerimientoModel
    {
        public string id_emp { get; set; }
        public string cardcode { get; set; }
        public string doccur { get; set; }
        public string docdate { get; set; }
        public string docduedate { get; set; }
        public string reqDate { get; set; }
        public string taxdate { get; set; }
        public string project { get; set; }
        public string U_SYP_TIPOSC { get; set; }

        public List<Detail> lines { get; set; }

        public List<Attachment> attachments { get; set; }
    }

    public class Detail 
    {
        public string itemcode { get; set; }
        public string itemname { get; set; }
        public string reqdate { get; set; }
        public string shipdate { get; set; }
        public double? reqquantity { get; set; }
        public double quantity { get; set; }
        public double unitprice { get; set; }
        public string taxcode { get; set; }
        public string costingcode { get; set; }
        public string costingcode2 { get; set; }
        public string costingcode3 { get; set; }
        public string costingcode4 { get; set; }
        public string costingcode5 { get; set; }
        public string project { get; set; }
        public string whscode { get; set; }
        public int basetype { get; set; }
        public int baseentry { get; set; }
        public int baseline { get; set; }
    }

    public class Attachment
    {
        public string extension { get; set; }
        public string nombre { get; set; }
        public string data { get; set; }
    }
}