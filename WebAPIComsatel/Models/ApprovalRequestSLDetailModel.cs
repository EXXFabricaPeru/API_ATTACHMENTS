using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ApprovalRequestSLDetailModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ApprovalRequests
        {
            public int Code { get; set; }
            public int DraftEntry { get; set; }
            public string Remarks { get; set; }
            public string ObjectType { get; set; }
            public string Status { get; set; }
        }

        public class ApprovalRequestsApprovalRequestLines
        {
            public int UserID { get; set; }
        }

        public class Drafts_
        {
            public string CardCode { get; set; }
            public string CardName { get; set; }
            public string Project { get; set; }
            public string U_SYP_TCOMPRA { get; set; }
        }

        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<Value> value { get; set; }

        [JsonProperty("odata.nextLink")]
        public string odatanextLink { get; set; }


        public class Value
        {
            public ApprovalRequests ApprovalRequests { get; set; }

            [JsonProperty("ApprovalRequests/ApprovalRequestLines")]
            public ApprovalRequestsApprovalRequestLines ApprovalRequestsApprovalRequestLines { get; set; }

            public Drafts_ Drafts { get; set; }
        }


    }
}