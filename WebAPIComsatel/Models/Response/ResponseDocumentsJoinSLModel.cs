using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseDocumentsJoinSLModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Items
        {
            public string U_SYP_FAMILIA { get; set; }
            public string U_SYP_SUBFAMILIA { get; set; }
        }

        public class PurchaseQuotations
        {
            public int DocEntry { get; set; }
            public int DocNum { get; set; }
            public string CardCode { get; set; }
            public string CardName { get; set; }
            public string Project { get; set; }
            public string DocDate { get; set; }
            public string TaxDate { get; set; }
            public string DocDueDate { get; set; }
            public double DocTotal { get; set; }
            public double DocTotalFc { get; set; }
            public string DocCurrency { get; set; }
            public double DocRate { get; set; }
            public double VatSum { get; set; }
            public double VatSumFc { get; set; }
            public string RequriedDate { get; set; }
            
        }

        public class PurchaseQuotationsDocumentLines
        {
            public int DocEntry { get; set; }
            public int LineNum { get; set; }
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public double Quantity { get; set; }
            public double Price { get; set; }
            public double UnitPrice { get; set; }
            public double LineTotal { get; set; }
            public double TaxTotal { get; set; }
            public string RequiredDate { get; set; }
            public double RequiredQuantity { get; set; }
            public string WarehouseCode { get; set; }
            public string ShipDate { get; set; }
            public string CostingCode { get; set; }
            public string CostingCode2 { get; set; }
            public string CostingCode3 { get; set; }
            public string CostingCode4 { get; set; }
            public string CostingCode5 { get; set; }
        }


        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<Value> value { get; set; }

        [JsonProperty("odata.nextLink")]
        public string odatanextLink { get; set; }


        public class Value
        {
            public PurchaseQuotations PurchaseQuotations { get; set; }

            [JsonProperty("PurchaseQuotations/DocumentLines")]
            public PurchaseQuotationsDocumentLines PurchaseQuotationsDocumentLines { get; set; }
            public Items Items { get; set; }
        }


    }
}