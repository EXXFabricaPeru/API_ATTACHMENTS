using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseFamilySLModel
    {
        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<FamilyModel> value { get; set; }
    }
}