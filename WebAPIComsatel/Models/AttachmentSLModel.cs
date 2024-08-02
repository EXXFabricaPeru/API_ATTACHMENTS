using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class AttachmentSLModel
    {
        public class Attachments2Line
        {
            public int AbsoluteEntry { get; set; }
            public int LineNum { get; set; }
            public string SourcePath { get; set; }
            public string FileName { get; set; }
            public string FileExtension { get; set; }
            public DateTime AttachmentDate { get; set; }
            public string Override { get; set; }
            public string FreeText { get; set; }
            public string CopyToTargetDoc { get; set; }
            public string CopyToProductionOrder { get; set; }
        }


        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<Attachments2Line> Attachments2_Lines { get; set; }

    }
}