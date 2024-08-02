using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class SubFamiliaSLModel
    {



        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("DocEntry", NullValueHandling = NullValueHandling.Ignore)]
        public int DocEntry { get; set; }

        [JsonProperty("Canceled", NullValueHandling = NullValueHandling.Ignore)]
        public string Canceled { get; set; }

        [JsonProperty("U_SYP_CODGPOSAP", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CODGPOSAP { get; set; }

        [JsonProperty("U_SYP_DESGPOSAP", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_DESGPOSAP { get; set; }

        [JsonProperty("U_SYP_DESFAMILIA", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_DESFAMILIA { get; set; }

        [JsonProperty("U_SYP_ACTIVO", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_ACTIVO { get; set; }

        [JsonProperty("U_SYP_AGRUPA", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_AGRUPA { get; set; }

        [JsonProperty("SYP_FAMILIA1Collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<SYPFAMILIA1Collection> SYP_FAMILIA1Collection { get; set; }
    }

    public class SYPFAMILIA1Collection
    {
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("LineId", NullValueHandling = NullValueHandling.Ignore)]
        public int LineId { get; set; }

        [JsonProperty("Object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        [JsonProperty("LogInst", NullValueHandling = NullValueHandling.Ignore)]
        public object LogInst { get; set; }

        [JsonProperty("U_SYP_CODSUBFAM", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CODSUBFAM { get; set; }

        [JsonProperty("U_SYP_DESSUBFAM", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_DESSUBFAM { get; set; }

        [JsonProperty("U_SYP_ACTIVO", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_ACTIVO { get; set; }
    }


}