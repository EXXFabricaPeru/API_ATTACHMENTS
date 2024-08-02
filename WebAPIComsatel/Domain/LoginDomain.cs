using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;

namespace WebAPIComsatel.Domain
{
    public class LoginDomain
    {
        public static Tuple<bool, string> Login(CompanyModel company)
        {
            ResponseSuccess responseSuccess = new ResponseSuccess();
            //var companies = CompaniesDomain.ListarCompanias();

            RequestLoginSLModel request = new RequestLoginSLModel
            {
                CompanyDB = company.BD,
                Password = company.PSW,
                UserName = company.USER
            };

            var jsonbody = JsonConvert.SerializeObject(request);

            var _response = RestHelper.Post(company.SERVERLIC + ConstantsHelper.LOGIN, jsonbody);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject responseContent = JObject.Parse(_response.Content);
                company.bEstaConectado = true;
                company.SessionId = responseContent["SessionId"].ToString();
                return Tuple.Create(true, company.SessionId);
            }
            else
            {

                return Tuple.Create(false, _response.Content);

            }
        }

        public static Tuple<bool, string> Login(RequestLoginModel loginModel, CompanyModel company)
        {
            ResponseSuccess responseSuccess = new ResponseSuccess();
            //var companies = CompaniesDomain.ListarCompanias();

            RequestLoginSLModel request = new RequestLoginSLModel
            {
                CompanyDB = company.BD,
                Password = loginModel.password,
                UserName = loginModel.user
            };

            var jsonbody = JsonConvert.SerializeObject(request);

            var _response = RestHelper.Post(company.SERVERLIC + ConstantsHelper.LOGIN, jsonbody);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject responseContent = JObject.Parse(_response.Content);
                company.bEstaConectado = true;
                company.SessionId = responseContent["SessionId"].ToString();
                return Tuple.Create(true, company.SessionId);
            }
            else
            {

                return Tuple.Create(false, _response.Content);

            }
        }

        public static Tuple<bool, string> Login(RequestLoginModelList loginModel, CompanyModel company)
        {
            ResponseSuccess responseSuccess = new ResponseSuccess();
            //var companies = CompaniesDomain.ListarCompanias();

            RequestLoginSLModel request = new RequestLoginSLModel
            {
                CompanyDB = company.BD,
                Password = loginModel.password,
                UserName = loginModel.user
            };

            var jsonbody = JsonConvert.SerializeObject(request);

            var _response = RestHelper.Post(company.SERVERLIC + ConstantsHelper.LOGIN, jsonbody);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject responseContent = JObject.Parse(_response.Content);
                company.bEstaConectado = true;
                company.SessionId = responseContent["SessionId"].ToString();
                return Tuple.Create(true, company.SessionId);
            }
            else
            {

                return Tuple.Create(false, _response.Content);

            }
        }

    }
}