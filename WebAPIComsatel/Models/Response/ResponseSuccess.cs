using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseSuccess
    {
        public string result { get; set; }
        public dynamic data { get; set; }

        public ResponseSuccess()
        {
            result = "Sucess";
        }
    }
}