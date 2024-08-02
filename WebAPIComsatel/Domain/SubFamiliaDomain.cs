using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;
using WebAPIComsatel.Models.Response;

namespace WebAPIComsatel.Domain
{
    public class SubFamiliaDomain
    {
        internal static object ListarSubFamiliasxCompanies(RequestSubFamiliaModel request, List<CompanyModel> companies)
        {
            List<SubFamiliaModel> listModels = new List<SubFamiliaModel>();

            foreach (var item in request.empresas)
            {

                var company = companies.Where(t => t.ID == item.id_emp).FirstOrDefault();

                var responseLogin = LoginDomain.Login(company);
                if (responseLogin.Item1)
                {
                    foreach (var fam in request.familias)
                    {
                        var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.FAMILIA + "('" + (fam.id_fam) + "')", responseLogin.Item2);

                        if (_response.StatusCode == HttpStatusCode.OK)
                        {
                            var models = JsonConvert.DeserializeObject<SubFamiliaSLModel>(_response.Content);

                            var subFamilias = models.SYP_FAMILIA1Collection.Where(t => t.U_SYP_ACTIVO == "Y").ToList();

                            if (subFamilias.Count > 0)
                            {
                                foreach (var subFam in subFamilias)
                                {
                                    listModels.Add(new SubFamiliaModel
                                    {
                                        Code = subFam.U_SYP_CODSUBFAM,
                                        Name = subFam.U_SYP_DESSUBFAM
                                    });
                                }
                            }

                        }
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
                throw new Exception("No se encontraron Sub Familias");
            }


        }
    }
}