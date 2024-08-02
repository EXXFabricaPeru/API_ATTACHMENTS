using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestAttachmentModel
    {
        public string company { get; set; }
        public string userSAP { get; set; }
        public string passSAP { get; set; }
        public string urlSAP { get; set; }

        public List<AttachmentLines> attachmentLines { get; set; }

    }

    public class AttachmentLines
    {
        public string fileName { get; set; }
        public string data { get; set; }
    }
}