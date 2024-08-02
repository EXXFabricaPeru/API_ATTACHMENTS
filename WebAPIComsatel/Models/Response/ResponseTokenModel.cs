using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseTokenModel
    {
        public string token { get; set; }
        public int time_min { get; set; }
    }
}