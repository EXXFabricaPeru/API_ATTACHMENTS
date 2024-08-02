using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebAPIComsatel.Domain.Interface;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;

namespace WebAPIComsatel.Domain
{
    public class AttachmentsDomain : IAttachmentsDomain
    {
        public AttachmentSLModel GenerarAttachments(RequestAttachmentModel model)
        {
            try
            {
                AttachmentSLModel attachment = new AttachmentSLModel();

                var company = ParseCompany(model);
                var responseLogin = LoginDomain.Login(company);

                if (responseLogin.Item1)
                {
                    var responAtt = new AttachmentSLModel();
                    attachment = CrearAdjunto(model, responseLogin.Item2, company,null, false);

                    responAtt = EnviarAttachment(attachment, company, responseLogin.Item2);
                    return responAtt;
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + model.company + " - " + error.error.message.value);
                }

                return attachment;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " -  "+ ex.StackTrace);
            }
        }

        private CompanyModel ParseCompany(RequestAttachmentModel model)
        {
            CompanyModel companyModel = new CompanyModel();

            companyModel.BD = model.company;
            companyModel.PSW = model.passSAP;
            companyModel.SERVERLIC = model.urlSAP;
            companyModel.USER = model.userSAP;

            return companyModel;
        }

        private AttachmentSLModel CrearAdjunto(RequestAttachmentModel model, string sessionID, CompanyModel company, AttachmentSLModel attachmentGet, bool isUpdate)
        {
            var ruta = ObtenerUrlAnexo(company, sessionID);


            AttachmentSLModel atta = new AttachmentSLModel();
            atta.Attachments2_Lines = new List<AttachmentSLModel.Attachments2Line>();


            foreach (var item in model.attachmentLines)
            {
                var path = ruta + item.fileName;// + "." + item.extension;
                File.WriteAllBytes(path, Convert.FromBase64String(item.data));
                //File.WriteAllBytes(path, item.data);

                var line = new AttachmentSLModel.Attachments2Line();

                string extension = System.IO.Path.GetExtension(item.fileName);
                string nombreArchivoSinExtension = System.IO.Path.GetFileNameWithoutExtension(item.fileName);

                line.SourcePath = ruta;
                line.FileExtension = extension.Substring(1);
                line.FileName = nombreArchivoSinExtension;
                //line.FreeText = item.data;

                if (isUpdate)
                {
                    var lineGet = attachmentGet.Attachments2_Lines.Where(t => t.FileName == nombreArchivoSinExtension).FirstOrDefault();

                    if (lineGet != null)
                    {
                        line.LineNum = lineGet.LineNum;
                    }
                }
                atta.Attachments2_Lines.Add(line);
            }



            return atta;//pruebas



        }

        private AttachmentSLModel ValidarAttachment(string url ,string sessionID)
        {
            var _response = RestHelper.GetSL(url, sessionID);
            var sapDocument = JsonConvert.DeserializeObject<AttachmentSLModel>(_response.Content);

            return sapDocument;
        }

        private AttachmentSLModel EnviarAttachment(AttachmentSLModel atta, CompanyModel company, string sessionID, int id = 0)
        {
            var jsonBody = JsonConvert.SerializeObject(atta, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            });//.Replace("\\", "");

            var url = company.SERVERLIC + ConstantsHelper.ATTACHMENTS;

            if (id != 0)
            {
                url = url + "(" + id.ToString() + ")";

                var _response = RestHelper.PatchSL(url, jsonBody, sessionID);
                var sapDocument = new AttachmentSLModel();
                if (_response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    _response = RestHelper.GetSL(url, sessionID);
                    sapDocument = JsonConvert.DeserializeObject<AttachmentSLModel>(_response.Content);

                    var lines = new List<AttachmentSLModel.Attachments2Line>();
                    foreach (var item in atta.Attachments2_Lines)
                    {
                        var line = sapDocument.Attachments2_Lines.Where(t => t.FileName == item.FileName).FirstOrDefault();

                        if (line != null)
                        {
                            lines.Add(line);
                        }

                    }

                    sapDocument.Attachments2_Lines = lines;

                    return sapDocument;
                }
                return sapDocument;
            }
            else
            {
                var _response = RestHelper.PostSL(url, jsonBody, sessionID);

                var sapDocument = JsonConvert.DeserializeObject<AttachmentSLModel>(_response.Content);

                return sapDocument;
            }

        }

        public string ObtenerUrlAnexo(CompanyModel company, string SessionId)
        {
            string body = "";
            var _response = RestHelper.PostSL(company.SERVERLIC + ConstantsHelper.PATH_ADMIN, body, SessionId);
            try
            {
                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    JObject responseContent = JObject.Parse(_response.Content);
                    var value = responseContent["AttachmentsFolderPath"].ToString();

                    if (!string.IsNullOrEmpty(value))
                    {
                        return value;
                    }
                    else
                        throw new Exception("La ruta compartida de SAP está vacía");
                }
                else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception("Error al obtener la ruta compartida de SAP");
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener la ruta compartida de SAP");
            }

            return null;
        }

        public AttachmentSLModel ActualizarAttachments(RequestAttachmentModel model, int id)
        {
            try
            {
                AttachmentSLModel attachment = new AttachmentSLModel();

                var company = ParseCompany(model);
                var responseLogin = LoginDomain.Login(company);

                if (responseLogin.Item1)
                {
                    var responAtt = new AttachmentSLModel();

                    var url = company.SERVERLIC + ConstantsHelper.ATTACHMENTS;
                    var attachmentGet = ValidarAttachment( url + "(" + id.ToString() + ")", responseLogin.Item2);

                    attachment = CrearAdjunto(model, responseLogin.Item2, company, attachmentGet,true);

                    responAtt = EnviarAttachment(attachment, company, responseLogin.Item2, id);
                    return responAtt;
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + model.company + " - " + error.error.message.value);
                }

                return attachment;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " -  " + ex.StackTrace);
            }
        }
    }
}