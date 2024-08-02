using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class RequestLoginModel
    {
        public string user { get; set; }
        public string password { get; set; }
        public string company_id { get; set; }
    }
}