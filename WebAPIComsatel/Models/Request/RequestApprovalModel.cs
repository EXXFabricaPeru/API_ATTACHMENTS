using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestApprovalModel : RequestLoginModel
    {
        public int id_doc { get; set; }
        public string type { get; set; }
        public string note { get; set; }
    }
}