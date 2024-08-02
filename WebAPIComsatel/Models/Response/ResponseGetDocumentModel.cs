using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseGetDocumentModel
    {
        public ResponseGetDocumentModel()
        {
            amounts = new Amounts();
            items = new List<Item>();
            information = new Information();
        }
        public class Amounts
        {
            public string before_discount { get; set; }
            public string discount { get; set; }
            public string tax { get; set; }
            public string total { get; set; }
        }


        public string id { get; set; }
        public int status { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string description { get; set; }
        public Information information { get; set; }
        public List<Item> items { get; set; }
        public Amounts amounts { get; set; }
        public string note { get; set; }


        public class Information
        {
            public string supplier_code { get; set; }
            public string supplier_name { get; set; }
            public string contact { get; set; }
            public string cost_center { get; set; }
            public string accounting_date { get; set; }
            public string delivery_date { get; set; }
            public string document_date { get; set; }
            public string project { get; set; }

            public string paycontidion { get; set; }
            public string tcompra { get; set; }
        }

        public class Item
        {
            public double quantity { get; set; }
            public string description { get; set; }
            public string unit_price { get; set; }
            public string total_price { get; set; }
        }
    }
}