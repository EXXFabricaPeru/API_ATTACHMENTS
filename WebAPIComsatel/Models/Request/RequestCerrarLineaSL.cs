using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestCerrarLineaSL
    {
        public List<LineSL> DocumentLines { get; set; }
    }

    public class LineSL
    {
        public int LineNum { get; set; }
        public string LineStatus { get; set; }
    }
}