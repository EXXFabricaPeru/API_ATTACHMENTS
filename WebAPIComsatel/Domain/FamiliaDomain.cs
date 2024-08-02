using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models.Request;
using WebAPIComsatel.Models.Response;
using WebAPIComsatel.Models;

namespace WebAPIComsatel.Domain
{
    public class FamiliaDomain
    {
        public static List<FamilyModel> ListarFamiliasxCompanies(RequestFamiliaModel request, List<CompanyModel> companies)
        {

            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();

            List<FamilyModel> listModels = new List<FamilyModel>();

            foreach (var item in request.empresas)
            {

                var company = companies.Where(t => t.ID == item.id_emp).FirstOrDefault();

                var responseLogin = LoginDomain.Login(company);
                if (responseLogin.Item1)
                {
                    var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.FAMILIA+ "?$filter=U_SYP_ACTIVO eq 'Y'", responseLogin.Item2);

                    if (_response.StatusCode == HttpStatusCode.OK)
                    {
                        var models = JsonConvert.DeserializeObject<ResponseFamilySLModel>(_response.Content);

                        listModels.AddRange(models.value);
                    }

                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + company.ID + " - " + error.error.message.value);

                }
            }

            var _list = listModels.Distinct().ToList();

            if (_list.Count > 0)
            {
                return _list;
            }
            else
            {
                throw new Exception("No se encontraron Familias");
            }





        }
    }
}