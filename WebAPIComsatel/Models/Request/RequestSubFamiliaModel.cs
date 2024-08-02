using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestSubFamiliaModel
    {
       
        public List<RequestEmpresa> empresas { get; set; }
        public List<RequestSubFamFamModel> familias { get; set; }

    }

   
}