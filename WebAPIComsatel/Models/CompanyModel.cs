using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class CompanyModel
    {
        public string ID { get; set; }
        public string BD { get; set; }
        public string USERBD { get; set; }
        public string PWBD { get; set; }
        public string URL { get; set; }
        public string USER { get; set; }
        public string PSW { get; set; }
        public string SERVERBD { get; set; }
        public string SERVERLIC { get; set; }
        public string NAME { get; set; }
        public string URLTHUMBNAIL { get; set; }
        public string URLLOGO { get; set; }
        public string URLBACKGROUND { get; set; }
        [JsonIgnore]
        public string SessionId { get;  set; }
        [JsonIgnore]
        public Boolean bEstaConectado;
        [JsonIgnore]
        public String sUrlSAP;
    }
}