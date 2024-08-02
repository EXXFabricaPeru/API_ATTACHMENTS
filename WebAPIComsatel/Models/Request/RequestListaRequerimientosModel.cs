using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models.Request
{
    public class RequestListaRequerimientosModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Empresa
        {
            public string id_emp { get; set; }
        }

        public class Estado
        {
            public string estado { get; set; }
        }

        public class Familia
        {
            public string id_fam { get; set; }
        }

        public class Proyecto
        {
            public string id_proj { get; set; }
        }


        public string fechainicio { get; set; }
        public string fechafin { get; set; }
        public List<Familia> familias { get; set; }
        public List<Subfamilia> subfamilias { get; set; }
        public List<Empresa> empresas { get; set; }
        public List<Proyecto> proyectos { get; set; }
        public List<Estado> estados { get; set; }


        public class Subfamilia
        {
            public string id_subfam { get; set; }
        }

    }
}