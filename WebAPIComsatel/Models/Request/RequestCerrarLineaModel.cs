using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestCerrarLineaModel
    {
        public string id_emp { get; set; }
        public string docentry { get; set; }
        public string linenum { get; set; }
    }
}