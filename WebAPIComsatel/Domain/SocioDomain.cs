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
    public class SocioDomain
    {
        public static List<SocioModel> ListarProveedorersxCompanies(RequestProveedorModel request, List<CompanyModel> companies)
        {

            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();

            List<SocioModel> listModels = new List<SocioModel>();

            foreach (var item in request.empresas)
            {

                var company = companies.Where(t => t.ID == item.id_emp).FirstOrDefault();

                var responseLogin = LoginDomain.Login(company);
                if (responseLogin.Item1)
                {
                    int skip = 0;
                    bool next = true;
                    while (next)
                    {
                        var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.BUSINESS_PARTNERS + "?$filter=CardType eq 'cSupplier'", responseLogin.Item2,100, skip);

                        if (_response.StatusCode == HttpStatusCode.OK)
                        {
                            var models = JsonConvert.DeserializeObject<ResponseBusinessPartnerSLModel>(_response.Content);
                            List<SocioModel> backlistModels = new List<SocioModel>();
                            if (models.value.Count > 0)
                            {
                                backlistModels = models.value.Select(bp => new SocioModel { CardCode = bp.CardCode, Cardname = bp.CardName }).ToList();

                                listModels.AddRange(backlistModels);
                                if (string.IsNullOrEmpty(models.odatanextLink))
                                {
                                    skip = 0;
                                    next = false;
                                }
                                else
                                    skip = UtilHelper.ValorSkip(models.odatanextLink);


                                if(skip>1000)
                                    next = false; 
                            }
                            //listModels.AddRange(models.value);
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
                throw new Exception("No se encontraron Familias");
            }

        }
    }
}