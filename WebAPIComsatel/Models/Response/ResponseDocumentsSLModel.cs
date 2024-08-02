using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class ResponseDocumentsSLModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<SapDocumentModel> value { get; set; }

        [JsonProperty("odata.nextLink")]
        public string odatanextLink { get; set; }



    }
}