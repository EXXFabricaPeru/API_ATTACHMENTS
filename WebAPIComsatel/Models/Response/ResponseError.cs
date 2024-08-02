using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseError
    {
        public string result { get; set; }
        public Error error { get; set; }


        public ResponseError()
        {
            result = "Error";
            error = new Error();
        }
        public class Error
        {
            public int code { get; set; }
            public string message { get; set; }
        }

    }
}