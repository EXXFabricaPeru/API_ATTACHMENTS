using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebAPIComsatel.Models.ApprovalRequestSLDetailModel;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseListDocumentSL
    {
   
        public List<SapDocumentModel> value { get; set; }
    }
}