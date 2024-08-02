using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseGetDocumentAttachModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[] content { get; set; }
    }
}