using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class RutasSLModel
    {
        public string odatametadata { get; set; }
        public string WordTemplateFolderPath { get; set; }
        public string PicturesFolderPath { get; set; }
        public string AttachmentsFolderPath { get; set; }
        public string ExtensionsFolderPath { get; set; }
        public string PrintId { get; set; }
    }
}