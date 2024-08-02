﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Response
{
    public class ResponseProjectsSLModel
    {
        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; }
        public List<ProjectsModel> value { get; set; }
    }
}