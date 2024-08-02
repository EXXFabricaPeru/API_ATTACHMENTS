using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebAPIComsatel.Models;

namespace WebAPIComsatel.Domain
{
    public static class CompaniesDomain
    {
        public static List<CompanyModel> ListarCompanias()
        {
            List<CompanyModel> companies = new List<CompanyModel>();
            string stringQuery = string.Empty;
            string path = AppDomain.CurrentDomain.BaseDirectory + "bin\\Resources\\Company.json";

            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                companies = JsonConvert.DeserializeObject<List<CompanyModel>>(json);
            }
            return companies;
        }
        public static List<ResponseCompanyModel> ParseCompanies(List<CompanyModel> companies)
        {
            List<ResponseCompanyModel> responses = new List<ResponseCompanyModel>();


            foreach (var item in companies)
            {
                ResponseCompanyModel model = new ResponseCompanyModel
                {
                    id = item.ID,
                    name = item.NAME,
                    background_url = item.URLBACKGROUND,
                    logo_url = item.URLLOGO,
                    thumbnail_url = item.URLTHUMBNAIL
                };
                responses.Add(model);
            }
            return responses;
        }

    }
}