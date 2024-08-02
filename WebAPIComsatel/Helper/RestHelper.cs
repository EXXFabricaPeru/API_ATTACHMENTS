
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;
using Flurl.Http.Content;
using Flurl;
using Flurl.Http;
using System.Collections;
using System.Web.Routing;

namespace WebAPIComsatel.Helper
{
    public class RestHelper
    {

        public static IRestResponse Post(string url, string body)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);
            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // body = body.Replace("\\", "");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            //request.AddParameter("sessionId", "9c2f6224-8232-11ed-8000-0022481e1bfd", ParameterType.QueryString);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            return response;
        }
        public static IRestResponse PostSL(string url, string body, string SessionId)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);


            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            if (!string.IsNullOrEmpty(body))
                request.AddParameter("application/json", body, ParameterType.RequestBody);
            request.AddCookie("B1SESSION", SessionId);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            return response;
        }

        public static IRestResponse PostSLAttachment(string url, List<Attachment> body, string SessionId)
        {
            //pruea(url, SessionId, body);
           


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);         

            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            var request = new RestRequest(Method.POST);


            //request.AddHeader("Content-Type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");

            //if (!string.IsNullOrEmpty(body))
            //    request.AddParameter("application/json", body, ParameterType.RequestBody);

            //foreach (var item in body)
            //{
            //    request.AddFileBytes(item.nombre, item.data, item.nombre+"."+item.extension);
            //}
            ///
            //string filePath = "D:/DEV/prueba2.txt";
            //foreach (var item in body)
            //{
            //    request.AddFile(item.nombre, filePath, contentType: "application/octet-stream");
            //}


            //NameValueHeaderValue nameValueHeaderValue = new NameValueHeaderValue("Custom-Header", "HeaderValue");



            // mp.Headers.ContentType.Parameters.First((NameValueHeaderValue o) => o.Name.Equals("boundary", StringComparison.OrdinalIgnoreCase));
            //nameValueHeaderValue.Value = nameValueHeaderValue.Value.Replace("\"", string.Empty);
            //foreach (var file in body)
            //{
            //    mp.Add(new StreamContent(file.Value)
            //    {
            //        Headers =
            //            {
            //                {
            //                    "Content-Disposition",
            //                    "form-data; name=\"files\"; filename=\"" + file.nombre + "\""
            //                },
            //                { "Content-Type", "application/octet-stream" }
            //            }
            //    });
            //}

            //var files = new List<Files>();
            //foreach (var item in body)
            //{
            //    files.Add(new Files
            //    {
            //        key = item.nombre,
            //        value = new MemoryStream(item.data)
            //    });
            //}
            //request.AlwaysMultipartFormData = true;

            //foreach (var file in files)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        file.value.CopyTo(memoryStream);
            //        request.AddFile("files", memoryStream.ToArray(), file.key, "application/octet-stream");
            //    }

                
            //    //request.AddFile("",s => { file.value.CopyTo(s); file.value.Position = 0; }, file.key, "application/octet-stream");


            //}

            //foreach (var file in body)
            //{

            //    request.AddFileBytes(file.nombre + ".txt", file.data, "application/octet-stream");

            //}

            //foreach (var file in body)
            //{

            //    request.AddFile(file.nombre + ".txt", file.data, file.nombre,"application/octet-stream");

            //}

            //string filePath = "D:/DEV/prueba2.txt";
            //request.AddFile("prueba2.txt", filePath, "application/octet-stream");


            request.AddCookie("B1SESSION", SessionId);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            return response;
        }

        private class Files
        {
            public string key { get; set; }
            public Stream value { get; set; }
        }
        //private static void pruea(string url,string session, List<Attachment> body)
        //{

        //    Uri ServiceLayerRoot = new Uri("https://10.0.0.4:50000/b1s/v1/");
        //    CookieJar cookieJar = new CookieJar();
        //    cookieJar.AddOrReplace(new FlurlCookie("B1SESSION", session, ServiceLayerRoot.AppendPathSegment("Login"))
        //    {
        //        HttpOnly = true,
        //        Secure = true
        //    });

        //    cookieJar.AddOrReplace(new FlurlCookie("ROUTEID", ".node1", ServiceLayerRoot.AppendPathSegment("Login"))
        //    {
        //        HttpOnly = true,
        //        Secure = true
        //    });
          



        //    var files = new List<Files>();

            

        //    //foreach (var item in body)
        //    //{
        //    //    files.Add(new Files
        //    //    {
        //    //        key = item.nombre,
        //    //        value = new MemoryStream(item.data)
        //    //    });
        //    //}

        //    ServicePointManager.Expect100Continue = true;
        //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

        //    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

        //    var list = ServiceLayerRoot.AppendPathSegment("Attachments2").WithCookies(cookieJar).PostMultipartAsync(delegate (CapturedMultipartContent mp)
        //    {
        //        NameValueHeaderValue nameValueHeaderValue = mp.Headers.ContentType.Parameters.First((NameValueHeaderValue o) => o.Name.Equals("boundary", StringComparison.OrdinalIgnoreCase));
        //        nameValueHeaderValue.Value = nameValueHeaderValue.Value.Replace("\"", string.Empty);
        //        foreach (var file in files)
        //        {
        //            mp.Add(new StreamContent(file.value)
        //            {
        //                Headers =
        //                {
        //                    {
        //                        "Content-Disposition",
        //                        "form-data; name=\"files\"; filename=\"" + file.key + "\""
        //                    },
        //                    { "Content-Type", "application/octet-stream" }
        //                }
        //            });
        //        }
        //    })
        //        .ReceiveJson<SLAttachment>();
        //    while (list.Status == TaskStatus.WaitingForActivation)
        //    {

        //    }
        //    if (list.Status == TaskStatus.RanToCompletion)
        //    {
        //        var asdas = "";
        //    }


        //}
        public static IRestResponse GetSL(string url, string SessionId)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);
            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Prefer", "odata.maxpagesize=500");
            request.AddCookie("B1SESSION", SessionId);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response;
        }
        public static IRestResponse GetSL(string url, string SessionId, int pagesize = 0, int nextpage = 0)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);
            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            if (pagesize > 0)
                request.AddHeader("Prefer", "odata.maxpagesize="+pagesize.ToString());
            if (nextpage > 0)
                request.AddParameter("$skip", nextpage.ToString());
            request.AddCookie("B1SESSION", SessionId);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response;
        }
        public static IRestResponse Get(string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return response;
        }


        public static IRestResponse PatchSL(string url, string body, string SessionId)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var client = new RestClient(url);


            client.Timeout = -1;
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            request.AddCookie("B1SESSION", SessionId);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            return response;
        }

    }
}
