using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models.Request;
using WebAPIComsatel.Models.Response;
using WebAPIComsatel.Models;
using System.Net;
using System.Reflection;
using Swashbuckle.Swagger;
using System.Xml.Linq;

namespace WebAPIComsatel.Domain
{
    public class ProjectDomain
    {
        public static List<ProjectsModel> ListarProyectosxCompanies(RequestProyectoModel request, List<CompanyModel> companies)
        {

            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();

            RequestApprovalSLModel requestApprovalSLModel = new RequestApprovalSLModel();

            List<ProjectsModel> listProjects = new List<ProjectsModel>();

            foreach (var item in request.empresas)
            {

                var company = companies.Where(t => t.ID == item.id_emp).FirstOrDefault();

                var responseLogin = LoginDomain.Login(company);
                if (responseLogin.Item1)
                {
                    var _response = RestHelper.PostSL(company.SERVERLIC + ConstantsHelper.PROJECTS , "",responseLogin.Item2);

                    if(_response.StatusCode== HttpStatusCode.OK)
                    {
                        var projects = JsonConvert.DeserializeObject<ResponseProjectsSLModel>(_response.Content);

                        listProjects.AddRange(projects.value);
                    }

                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + company.ID+" - "+error.error.message.value  );

                }
            }

            var _list= listProjects.Distinct().ToList();

            if (_list.Count > 0)
            {
                return _list;
            }
            else
            {
                throw new Exception("No se encontraron proyectos");
            }



          

        }
    }
}