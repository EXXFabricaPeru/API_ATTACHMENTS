using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseApprovalRequestsSL
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ApprovalRequestLine
        {
            public int StageCode { get; set; }
            public int UserID { get; set; }
            public string Status { get; set; }
            public object Remarks { get; set; }
            public DateTime? UpdateDate { get; set; }
            public object UpdateTime { get; set; }
            public DateTime? CreationDate { get; set; }
            public string CreationTime { get; set; }
        }






        public int Code { get; set; }
        public int ApprovalTemplatesID { get; set; }
        public string ObjectType { get; set; }
        public string IsDraft { get; set; }
        public object ObjectEntry { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int CurrentStage { get; set; }
        public int OriginatorID { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationTime { get; set; }
        public int DraftEntry { get; set; }
        public string DraftType { get; set; }
        public List<ApprovalRequestLine> ApprovalRequestLines { get; set; }
        public List<object> ApprovalRequestDecisions { get; set; }



    }
}