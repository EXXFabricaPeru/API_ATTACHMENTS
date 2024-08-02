using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestRequerimientoModel
    {

        public string id_emp { get; set; }
        public string cardcode { get; set; }
        public string doccur { get; set; }
        public string docdate { get; set; }
        public string docduedate { get; set; }
        public string taxdate { get; set; }
        public string project { get; set; }
        public string U_SYP_TIPOSC { get; set; }


    }
}