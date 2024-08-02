using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseDocumentsModel
    {
        public string id { get; set; }
        public int status { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string description { get; set; }
        public string cardcode { get; set; }
        public string project { get; set; }
        public string cardname { get; set; }
        public string tcompra { get; set; }

        public string EstadoDoc { get; set; }
        public string EstadoUser { get; set; }
        public string Comentario { get; set; }

        public string CreateDate { get; set; }
        public int CreateTime { get; set; }

        public string UpdateDate { get; set; }
        public int UpdateTime { get; set; }

        public string UpdateDate2 { get; set; }
        public int UpdateTime2 { get; set; }


    }
}