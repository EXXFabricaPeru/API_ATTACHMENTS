using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseCompanyModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string logo_url { get; set; }
        public string background_url { get; set; }
    }
}