using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIComsatel.Models
{
    public class  ApprovalRequestView
    {
        public int WddCode { get; set; }
        public string ObjType { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int DraftEntry { get; set; }
        public int UserID { get; set; }
        public int CurrStep { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Project { get; set; }
        public string U_SYP_TCOMPRA { get; set; }
        public int id__ { get; set; }

        public string EstadoUser { get; set; }
        public string EstadoDoc { get; set; }
        public string Comentario { get; set; }

        public string CreateDate { get; set; }
        public int? CreateTime { get; set; }

        public string UpdateDate { get; set; }
        public int? UpdateTime { get; set; }


        public string UpdateDate2 { get; set; }
        public int? UpdateTime2 { get; set; }
    }
}
