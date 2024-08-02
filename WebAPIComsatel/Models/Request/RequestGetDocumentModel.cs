using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class RequestGetDocumentModel :RequestLoginModel
    {
        public int id_doc { get; set; }
        public string type { get; set; }
    }
}