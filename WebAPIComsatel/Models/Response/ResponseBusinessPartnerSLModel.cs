using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseBusinessPartnerSLModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);



        [JsonProperty("odata.metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string odatametadata { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<BusinessPartnerSLModel> value { get; set; }

        [JsonProperty("odata.nextLink", NullValueHandling = NullValueHandling.Ignore)]
        public string odatanextLink { get; set; }




    }
}