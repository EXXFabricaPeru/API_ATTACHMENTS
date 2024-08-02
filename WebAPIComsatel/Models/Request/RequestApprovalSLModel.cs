using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestApprovalSLModel
    {
        public class ApprovalRequestDecision
        {
            public string Status { get; set; }
            public string Remarks { get; set; }
        }


        public List<ApprovalRequestDecision> ApprovalRequestDecisions { get; set; }

        public RequestApprovalSLModel()
        {
            ApprovalRequestDecisions = new List<ApprovalRequestDecision>();
            
        }
    }
}