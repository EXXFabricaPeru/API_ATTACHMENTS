using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class UserSLModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
       

       
            public int InternalKey { get; set; }
            public object UserPassword { get; set; }
            public string UserCode { get; set; }
            public string UserName { get; set; }
            public string Superuser { get; set; }
            public string eMail { get; set; }
          
        


    }
}