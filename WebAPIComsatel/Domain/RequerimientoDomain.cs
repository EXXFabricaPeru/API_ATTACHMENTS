using Newtonsoft.Json;
using RestSharp;
using Swashbuckle.Swagger;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;
using WebAPIComsatel.Models.Response;
using static WebAPIComsatel.Models.ResponseGetDocumentModel;

namespace WebAPIComsatel.Domain
{
    public class RequerimientoDomain
    {
        public static ResponseSuccessModel CerrarLinea(RequestCerrarLineaModel model, CompanyModel company)
        {
            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();
            try
            {
                var responseLogin = LoginDomain.Login(company);

                if (responseLogin.Item1)
                {


                    RequestCerrarLineaSL reqSL = new RequestCerrarLineaSL();
                    reqSL.DocumentLines = new List<LineSL>
                    {
                        new LineSL
                        {
                            LineNum = int.Parse(model.linenum),
                            LineStatus = "bost_Close"
                        }
                    };

                    var jsonBody = JsonConvert.SerializeObject(reqSL, new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                    });//.Replace("\\", "");


                    var _response = RestHelper.PatchSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + "(" + model.docentry + ")", jsonBody, responseLogin.Item2);


                    if (_response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        responseSuccess.result = ConstantsHelper.SUCCESS;
                        return responseSuccess;
                    }
                    else
                    {
                        var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                        throw new Exception(error.error.message.value);
                    }

                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + company.ID + " - " + error.error.message.value);

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        internal static dynamic CrearRequerimiento(RequestCrearRequerimientoModel model, List<CompanyModel> companies)
        {
            try
            {
                ResponseSuccessModel responseSuccess = new ResponseSuccessModel();
                if (model.id_emp == null)
                {
                    throw new Exception("No se encontraron empresas");
                }



                var company = companies.Where(t => t.ID == model.id_emp).FirstOrDefault();


                string filePath = "D:/DEV/prueba2.txt";
                //enviarAsync(filePath, company);
                var responseLogin = LoginDomain.Login(company);

                if (responseLogin.Item1)
                {


                    SapDocumentModel document = ParseObjectRequerimiento(model);

                    var jsonBody = JsonConvert.SerializeObject(document, new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                    });//.Replace("\\", "");

                    ////
                    ///




                    ////////////////////////

                    var _response = RestHelper.PostSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS, jsonBody, responseLogin.Item2);


                    if (_response.StatusCode == System.Net.HttpStatusCode.Created)

                    {
                        var sapDocument = JsonConvert.DeserializeObject<SapDocumentModel>(_response.Content);



                        // Convertir el archivo a un array de bytes
                        //byte[] fileBytes = File.ReadAllBytes(filePath);
                        //model.attachments.FirstOrDefault().data = fileBytes;
                        int atttEntry = CrearAdjunto(model, responseLogin.Item2, company);

                        jsonBody = "{\r\n    \"AttachmentEntry\":" + atttEntry + "\r\n}";
                        var _response2 = RestHelper.PatchSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + "(" + sapDocument.DocEntry + ")", jsonBody, responseLogin.Item2);

                        if (_response2.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {

                        }

                        responseSuccess.result = ConstantsHelper.SUCCESS;
                        return sapDocument;
                    }
                    else
                    {
                        var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                        throw new Exception(error.error.message.value);
                    }
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                    throw new Exception("Error - " + company.ID + " - " + error.error.message.value);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //public dynamic CrearRequerimientoV2(RequestCrearRequerimientoModel model, List<CompanyModel> companies)
        //{
        //    string filePath = "D:/DEV/prueba2.txt";

        //    ServiceLayerHelper serviceLayerHelper = new ServiceLayerHelper();

        //    var company = companies.Where(t => t.ID == model.id_emp).FirstOrDefault();

        //    var responseLogin = LoginDomain.Login(company);

        //    byte[] fileBytes = File.ReadAllBytes(filePath);

        //    //model.attachments.FirstOrDefault().data = fileBytes;

        //    RestHelper.PostSLAttachment(company.SERVERLIC + ConstantsHelper.ATTACHMENTS, model.attachments, responseLogin.Item2);

        //    SLConnection _serviceLayer = serviceLayerHelper.Login("https://10.0.0.4:50000/b1s/v1/", company.BD, company.USER, company.PSW);


        //    enviarAsync(filePath, company, _serviceLayer);
        //    var asdas = PTdsds(_serviceLayer);
        //    while (asdas.Status == TaskStatus.WaitingForActivation)
        //    {

        //    }
        //    return null;
        //}

        //async Task PTdsds(SLConnection _serviceLayer)
        //{
        //     await _serviceLayer.Request("PurchaseQuotations", 6782).GetAsync<SapDocumentModel>();

        //}
        //private  async Task enviarAsync(string filePath, CompanyModel company, SLConnection _serviceLayer)
        //{

        //    //var _serviceLayer = Login(company.SERVERLIC + "/b1s/v1/", company.BD, company.USER, company.PSW);

        //    //var cx= _serviceLayer.LoginAsync(true);
        //    //while (cx.Status == TaskStatus.WaitingForActivation)
        //    //{

        //    //}



        //    var  attachment =   _serviceLayer.PostAttachmentAsync(filePath);

        //    while (attachment.Status == TaskStatus.WaitingForActivation)
        //    {

        //    }
        //    if (attachment.Status == TaskStatus.RanToCompletion)
        //    {
        //        var x = ";";
        //    }
        //    if (attachment.Status == TaskStatus.Faulted)
        //    {
        //        var x = ";";
        //    }
        //}

        //public  SLConnection Login(string IP_ServiceLayer, string bD, string uSER, string pSW)
        //{


        //    var serviceLayer = new SLConnection(IP_ServiceLayer, bD, uSER, pSW);
        //    serviceLayer.AfterCall(async call =>
        //    {
        //        Console.WriteLine($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
        //        Console.WriteLine($"Body sent: {call.RequestBody}");
        //        Console.WriteLine($"Response: {call.HttpResponseMessage?.StatusCode}");
        //        Console.WriteLine(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
        //        Console.WriteLine($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
        //    });

        //    return serviceLayer;
        //}
        private static dynamic CrearAdjunto(RequestCrearRequerimientoModel model, string sessionID, CompanyModel company)
        {
            var ruta = DocumentsDomain.ObtenerUrlAnexo(company, sessionID);


            AttachmentSLModel atta = new AttachmentSLModel();
            atta.Attachments2_Lines = new List<AttachmentSLModel.Attachments2Line>();
            foreach (var item in model.attachments)
            {
                var path = ruta + item.nombre + "." + item.extension;
                File.WriteAllBytes(path, Convert.FromBase64String(item.data));

                var line = new AttachmentSLModel.Attachments2Line();

                line.SourcePath = ruta;
                line.FileExtension = item.extension;
                line.FileName = item.nombre;

                atta.Attachments2_Lines.Add(line);
            }





            var jsonBody = JsonConvert.SerializeObject(atta, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            });//.Replace("\\", "");


            var _response = RestHelper.PostSL(company.SERVERLIC + ConstantsHelper.ATTACHMENTS, jsonBody, sessionID);

            var sapDocument = JsonConvert.DeserializeObject<AttachmentSLModel>(_response.Content);

            return sapDocument.Attachments2_Lines.FirstOrDefault().AbsoluteEntry;

        }


        private static SapDocumentModel ParseObjectRequerimiento(RequestCrearRequerimientoModel model)
        {
            SapDocumentModel sapDocument = new SapDocumentModel();

            sapDocument.CardCode = model.cardcode;
            sapDocument.DocCurrency = model.doccur;
            sapDocument.DocDate = DateTime.ParseExact(model.docdate, "dd-MM-yyyy", null);
            sapDocument.TaxDate = DateTime.ParseExact(model.taxdate, "dd-MM-yyyy", null);
            sapDocument.DocDueDate = DateTime.ParseExact(model.docduedate, "dd-MM-yyyy", null);
            sapDocument.RequriedDate = DateTime.ParseExact(model.reqDate, "dd-MM-yyyy", null);
            sapDocument.Project = model.project;
            sapDocument.U_SYP_TIPOSC = model.U_SYP_TIPOSC;

            List<SapDocumentLineModel> lines = new List<SapDocumentLineModel>();

            foreach (var item in model.lines)
            {
                SapDocumentLineModel newLine = new SapDocumentLineModel();

                if (!string.IsNullOrEmpty(item.itemcode))
                {
                    newLine.ItemCode = item.itemcode;

                    newLine.Quantity = item.quantity;
                    newLine.UnitPrice = item.unitprice;
                    newLine.TaxCode = item.taxcode;

                    if (!string.IsNullOrEmpty(item.reqdate))
                        newLine.RequiredDate = DateTime.ParseExact(item.reqdate, "dd-MM-yyyy", null);

                    if (!string.IsNullOrEmpty(item.shipdate))
                        newLine.ShipDate = DateTime.ParseExact(item.shipdate, "dd-MM-yyyy", null);

                    if (item.reqquantity != null)
                        newLine.RequiredQuantity = item.reqquantity;

                    if (!string.IsNullOrEmpty(item.costingcode))
                        newLine.CostingCode = item.costingcode;

                    if (!string.IsNullOrEmpty(item.costingcode2))
                        newLine.CostingCode2 = item.costingcode2;

                    if (!string.IsNullOrEmpty(item.costingcode3))
                        newLine.CostingCode3 = item.costingcode3;

                    if (!string.IsNullOrEmpty(item.costingcode4))
                        newLine.CostingCode4 = item.costingcode4;

                    if (!string.IsNullOrEmpty(item.costingcode5))
                        newLine.CostingCode5 = item.costingcode5;

                    if (!string.IsNullOrEmpty(item.project))
                        newLine.ProjectCode = item.project;

                    newLine.WarehouseCode = item.whscode;

                    lines.Add(newLine);
                }
            }
            sapDocument.DocumentLines = lines;

            return sapDocument;
        }

        internal static List<SapDocumentModel> ListarRequerimientos(RequestListaRequerimientosModel model, List<CompanyModel> companies)
        {
            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();
            try
            {
                List<SapDocumentModel> documents = new List<SapDocumentModel>();
                if (model.empresas == null)
                {
                    throw new Exception("No se encontraron empresas");
                }
                foreach (var emp in model.empresas)
                {
                    var company = companies.Where(t => t.ID == emp.id_emp).FirstOrDefault();

                    var responseLogin = LoginDomain.Login(company);
                    if (responseLogin.Item1)
                    {

                        DateTime fechaInicio = DateTime.ParseExact(model.fechainicio, "dd-MM-yyyy", null);
                        DateTime fechaFin = DateTime.ParseExact(model.fechafin, "dd-MM-yyyy", null);
                        string fechasFilter = "?$filter=DocDate ge '" + fechaInicio.ToString("yyyyMMdd") + "' and DocDate le '" + fechaFin.ToString("yyyyMMdd") + "' ";
                        string fechasFilterFamily = " and PurchaseQuotations/DocDate ge '" + fechaInicio.ToString("yyyyMMdd") + "' and PurchaseQuotations/DocDate le '" + fechaFin.ToString("yyyyMMdd") + "' ";

                        bool onlyDates = true;
                        if (model.familias != null)
                        {
                            onlyDates = false;
                            string asdasd = "and Items/U_SYP_FAMILIA";
                            string familiaFilter = "and (";
                            int cont = 0;
                            foreach (var item in model.familias)
                            {
                                familiaFilter += " Items/U_SYP_FAMILIA eq '" + item.id_fam + "' ";
                                cont++;
                                if (cont < model.familias.Count)
                                {
                                    familiaFilter += " or ";
                                }
                            }
                            familiaFilter += " ) ";

                            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS_FAMILIA + fechasFilterFamily + familiaFilter, responseLogin.Item2);

                            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseSuccess.result = ConstantsHelper.SUCCESS;
                                var sapDocument = JsonConvert.DeserializeObject<ResponseDocumentsJoinSLModel>(_response.Content);

                                var documentsSAP = ParseJoinDocuments(sapDocument);
                                documents.AddRange(documentsSAP);
                            }
                            else
                            {
                                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                throw new Exception(error.error.message.value);
                            }
                        }
                        if (model.subfamilias != null)
                        {
                            onlyDates = false;
                            string asdasd = "and Items/U_SYP_SUBFAMILIA";
                            string familiaFilter = "and (";
                            int cont = 0;
                            foreach (var item in model.subfamilias)
                            {
                                familiaFilter += " Items/U_SYP_SUBFAMILIA eq '" + item.id_subfam + "' ";
                                cont++;
                                if (cont < model.familias.Count)
                                {
                                    familiaFilter += " or ";
                                }
                            }
                            familiaFilter += " ) ";

                            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS_FAMILIA + fechasFilterFamily + familiaFilter, responseLogin.Item2);

                            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseSuccess.result = ConstantsHelper.SUCCESS;
                                var sapDocument = JsonConvert.DeserializeObject<ResponseDocumentsJoinSLModel>(_response.Content);

                                var documentsSAP = ParseJoinDocuments(sapDocument);
                                documents.AddRange(documentsSAP);
                            }
                            else
                            {
                                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                throw new Exception(error.error.message.value);
                            }
                        }

                        if (model.proyectos != null)
                        {
                            onlyDates = false;
                            string proyectosfilter = "and (";
                            int cont = 0;
                            foreach (var item in model.proyectos)
                            {
                                proyectosfilter += " Project eq '" + item.id_proj + "' ";
                                cont++;
                                if (cont < model.proyectos.Count)
                                {
                                    proyectosfilter += " or ";
                                }
                            }
                            proyectosfilter += " ) ";
                            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + fechasFilter + proyectosfilter, responseLogin.Item2);

                            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseSuccess.result = ConstantsHelper.SUCCESS;
                                var sapDocument = JsonConvert.DeserializeObject<ResponseListDocumentSL>(_response.Content);
                                documents.AddRange(sapDocument.value);
                            }
                            else
                            {
                                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                throw new Exception(error.error.message.value);
                            }
                        }


                        if (model.estados != null)
                        {
                            onlyDates = false;
                            string estadosFilter = " and (";
                            string canceledFilter = "";
                            int cont = 0;
                            var status = "";
                            foreach (var item in model.estados)
                            {

                                switch (item.estado)
                                {
                                    case "Abierto":
                                        status = "O";
                                        break;
                                    case "Cerrado":
                                        status = "C";
                                        break;
                                    case "Cancelado":
                                        canceledFilter = " and Cancelled eq 'Y' ";
                                        break;
                                }
                                estadosFilter += " DocumentStatus eq '" + status + "' ";
                                cont++;
                                if (cont < model.estados.Count)
                                {
                                    estadosFilter += " or ";
                                }
                            }
                            estadosFilter += " ) ";

                            if (!string.IsNullOrEmpty(status))
                            {
                                var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + fechasFilter + estadosFilter, responseLogin.Item2);

                                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    responseSuccess.result = ConstantsHelper.SUCCESS;
                                    var sapDocument = JsonConvert.DeserializeObject<ResponseListDocumentSL>(_response.Content);
                                    documents.AddRange(sapDocument.value);
                                }
                                else
                                {
                                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                    throw new Exception(error.error.message.value);
                                }
                            }


                            if (!string.IsNullOrEmpty(canceledFilter))
                            {
                                var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + fechasFilter + canceledFilter, responseLogin.Item2);

                                if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    responseSuccess.result = ConstantsHelper.SUCCESS;
                                    var sapDocument = JsonConvert.DeserializeObject<ResponseListDocumentSL>(_response.Content);
                                    documents.AddRange(sapDocument.value);
                                }
                                else
                                {
                                    var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                    throw new Exception(error.error.message.value);
                                }
                            }



                        }


                        if (onlyDates)
                        {
                            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.PURCHASE_QUOTATIONS + fechasFilter, responseLogin.Item2);

                            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                responseSuccess.result = ConstantsHelper.SUCCESS;
                                var sapDocument = JsonConvert.DeserializeObject<ResponseListDocumentSL>(_response.Content);
                                documents.AddRange(sapDocument.value);
                            }
                            else
                            {
                                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                                throw new Exception(error.error.message.value);
                            }

                        }



                    }
                    else
                    {
                        var error = JsonConvert.DeserializeObject<ErrorSLModel>(responseLogin.Item2);
                        throw new Exception("Error - " + company.ID + " - " + error.error.message.value);
                    }

                }


                return documents.Distinct().ToList();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private static List<SapDocumentModel> ParseJoinDocuments(ResponseDocumentsJoinSLModel sapDocument)
        {
            List<SapDocumentModel> list = new List<SapDocumentModel>();

            foreach (var item in sapDocument.value)
            {
                SapDocumentModel doc = new SapDocumentModel();

                if (!list.Where(t => t.DocEntry == item.PurchaseQuotations.DocEntry).Any())
                {
                    doc.DocEntry = item.PurchaseQuotations.DocEntry;
                    doc.DocNum = item.PurchaseQuotations.DocNum;
                    doc.TaxDate = DateTime.ParseExact(item.PurchaseQuotations.TaxDate, "yyyy-MM-dd", null);
                    doc.DocDate = DateTime.ParseExact(item.PurchaseQuotations.DocDate, "yyyy-MM-dd", null);
                    doc.DocDueDate = DateTime.ParseExact(item.PurchaseQuotations.DocDueDate, "yyyy-MM-dd", null);
                    doc.CardCode = item.PurchaseQuotations.CardCode;
                    doc.CardName = item.PurchaseQuotations.CardName;
                    doc.Project = item.PurchaseQuotations.Project;
                    doc.DocTotal = item.PurchaseQuotations.DocTotal;
                    doc.DocTotalFc = item.PurchaseQuotations.DocTotalFc;
                    doc.DocCurrency = item.PurchaseQuotations.DocCurrency;
                    doc.DocRate = item.PurchaseQuotations.DocRate;
                    doc.VatSum = item.PurchaseQuotations.VatSum;
                    doc.VatSumFc = item.PurchaseQuotations.VatSumFc;
                    doc.RequriedDate = DateTime.ParseExact(item.PurchaseQuotations.RequriedDate, "yyyy-MM-dd", null);
                    doc.DocumentLines = new List<SapDocumentLineModel>();
                    list.Add(doc);
                }

                if (list.Where(t => t.DocEntry == item.PurchaseQuotations.DocEntry).Any())
                {
                    SapDocumentLineModel line = new SapDocumentLineModel();

                    line.DocEntry = item.PurchaseQuotationsDocumentLines.DocEntry;
                    line.LineNum = item.PurchaseQuotationsDocumentLines.LineNum;
                    line.ItemCode = item.PurchaseQuotationsDocumentLines.ItemCode;
                    line.ItemDescription = item.PurchaseQuotationsDocumentLines.ItemDescription;
                    line.Quantity = item.PurchaseQuotationsDocumentLines.Quantity;
                    line.Price = item.PurchaseQuotationsDocumentLines.Price;
                    line.UnitPrice = item.PurchaseQuotationsDocumentLines.UnitPrice;
                    line.RequiredQuantity = item.PurchaseQuotationsDocumentLines.RequiredQuantity;
                    line.LineTotal = item.PurchaseQuotationsDocumentLines.LineTotal;
                    line.TaxTotal = item.PurchaseQuotationsDocumentLines.TaxTotal;
                    if (!string.IsNullOrEmpty(item.PurchaseQuotationsDocumentLines.RequiredDate))
                        line.RequiredDate = DateTime.ParseExact(item.PurchaseQuotationsDocumentLines.RequiredDate, "yyyy-MM-dd", null);
                    line.WarehouseCode = item.PurchaseQuotationsDocumentLines.WarehouseCode;
                    if (!string.IsNullOrEmpty(item.PurchaseQuotationsDocumentLines.ShipDate))
                        line.ShipDate = DateTime.ParseExact(item.PurchaseQuotationsDocumentLines.ShipDate, "yyyy-MM-dd", null);
                    line.CostingCode = item.PurchaseQuotationsDocumentLines.CostingCode;
                    line.CostingCode2 = item.PurchaseQuotationsDocumentLines.CostingCode2;
                    line.CostingCode3 = item.PurchaseQuotationsDocumentLines.CostingCode3;
                    line.CostingCode4 = item.PurchaseQuotationsDocumentLines.CostingCode4;
                    line.CostingCode5 = item.PurchaseQuotationsDocumentLines.CostingCode5;

                    list.Where(t => t.DocEntry == item.PurchaseQuotations.DocEntry).FirstOrDefault().DocumentLines.Add(line);
                }

            }

            return list;
        }
    }
}