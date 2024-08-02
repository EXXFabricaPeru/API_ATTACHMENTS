using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Response;
using static WebAPIComsatel.Models.ResponseGetDocumentModel;

namespace WebAPIComsatel.Domain
{
    public class DocumentsDomain
    {
        public static List<ResponseDocumentsModel> ListarDocumentos(CompanyModel company, string sessionId, RequestDocumentsModel loginModel)
        {
            try
            {
                List<ResponseDocumentsModel> documentsModels = new List<ResponseDocumentsModel>();

                var idUser = ObtenerIdUsuario(company, sessionId, loginModel);
                var pendientes = TraerPendientesAprobacion(company, sessionId, idUser, loginModel.status);
                if (pendientes != null)
                    documentsModels.AddRange(pendientes);


                return documentsModels;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static int ObtenerIdUsuario(CompanyModel company, string sessionId, RequestLoginModel loginModel)
        {
            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.USERS + ConstantsHelper.filterUsers + "'" + loginModel.user + "'", sessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject responseContent = JObject.Parse(_response.Content);
                var value = responseContent["value"].ToString();
                var listPendientes = JsonConvert.DeserializeObject<List<UserSLModel>>(value);

                return listPendientes.FirstOrDefault().InternalKey;
            }
            return 0;
        }

        //private static List<ResponseDocumentsModel> TraerPendientesAprobacion(CompanyModel company, string sessionId, int idUser)
        //{
        //    var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.APPROVALREQUESTS + ConstantsHelper.filterApprovalRequests + idUser.ToString(), sessionId);

        //    if (_response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        JObject responseContent = JObject.Parse(_response.Content);
        //        var value = responseContent["value"].ToString();
        //        var listPendientes = JsonConvert.DeserializeObject<List<ResponseApprovalRequestsSL>>(value);

        //        return ParseDocuments(listPendientes, "");
        //    }
        //    return null;
        //}
        private static List<ResponseDocumentsModel> TraerPendientesAprobacion(CompanyModel company, string sessionId, int idUser, int status)
        {
            IRestResponse _response = null;
            if (status == ConstantsHelper.status_ALL)
            {
                _response = RestHelper.GetSL(company.SERVERLIC + string.Format(ConstantsHelper.APPROVAL_REQUEST_VIEW, idUser.ToString()), sessionId);
            }
            else
            {
                var filtro = "";
                switch (status)
                {
                    case ConstantsHelper.status_Pendiente:
                        filtro = string.Format(ConstantsHelper.APPROVAL_REQUEST_VIEW_FILTER, ConstantsHelper.status_Pendiente_SAP, idUser.ToString());
                        //filtro =ConstantsHelper.filterApproval;
                        break;
                    case ConstantsHelper.status_Aprobado:
                        filtro = string.Format(ConstantsHelper.APPROVAL_REQUEST_VIEW_FILTER, ConstantsHelper.status_Aprobado_SAP, idUser.ToString());
                        break;
                    case ConstantsHelper.status_Rechazado:
                        filtro = string.Format(ConstantsHelper.APPROVAL_REQUEST_VIEW_FILTER, ConstantsHelper.status_Rechazado_SAP, idUser.ToString());
                        break;
                }

                _response = RestHelper.GetSL(company.SERVERLIC + filtro, sessionId);
            }

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject responseContent = JObject.Parse(_response.Content);
                var value = responseContent["value"].ToString();
                var listPendientes = JsonConvert.DeserializeObject<List<ApprovalRequestView>>(value);

                return ParseDocuments(listPendientes, "");
            }
            return null;
        }


        //private static List<ResponseDocumentsModel> ParseDocuments(List<ResponseApprovalRequestsSL> sapDocuments, string type)
        //{
        //    List<ResponseDocumentsModel> documentsModels = new List<ResponseDocumentsModel>();
        //    ResponseDocumentsModel model = new ResponseDocumentsModel();
        //    sapDocuments.ForEach((item) =>
        //    {
        //        switch (item.ObjectType)
        //        {
        //            case ConstantsHelper.OBJ_OFERTA_COMPRA:
        //                type = ConstantsHelper.OFERTA_COMPRA;
        //                break;
        //            case ConstantsHelper.OBJ_ORDEN_COMPRA:
        //                type = ConstantsHelper.ORDEN_COMPRA;
        //                break;
        //            case ConstantsHelper.OBJ_ENTRADA_COMPRA:
        //                type = ConstantsHelper.ENTRADA_COMPRA;
        //                break;
        //            case ConstantsHelper.OBJ_FACTURA_COMPRA:
        //                type = ConstantsHelper.FACTURA_COMPRA;
        //                break;
        //        }
        //        model = new ResponseDocumentsModel();

        //        model.id = item.Code.ToString();
        //        model.status = 0;
        //        model.type = type;
        //        model.number = item.DraftEntry.ToString();
        //        model.description = item.Remarks;

        //        documentsModels.Add(model);

        //    });

        //    return documentsModels;
        //}

        private static List<ResponseDocumentsModel> ParseDocuments(List<ApprovalRequestView> sapDocuments, string type)
        {
            List<ResponseDocumentsModel> documentsModels = new List<ResponseDocumentsModel>();
            ResponseDocumentsModel model = new ResponseDocumentsModel();
            sapDocuments.ForEach((item) =>
            {
                switch (item.ObjType)
                {
                    case ConstantsHelper.OBJ_OFERTA_COMPRA:
                        type = ConstantsHelper.OFERTA_COMPRA;
                        break;
                    case ConstantsHelper.OBJ_ORDEN_COMPRA:
                        type = ConstantsHelper.ORDEN_COMPRA;
                        break;
                    case ConstantsHelper.OBJ_ENTRADA_COMPRA:
                        type = ConstantsHelper.ENTRADA_COMPRA;
                        break;
                    case ConstantsHelper.OBJ_FACTURA_COMPRA:
                        type = ConstantsHelper.FACTURA_COMPRA;
                        break;
                    case ConstantsHelper.OBJ_ANTICIPO_COMPRA:
                        type = ConstantsHelper.ANTICIPO_COMPRA;
                        break;
                }
                model = new ResponseDocumentsModel();

                model.id = item.WddCode.ToString();

                switch (item.Status)
                {
                    case ConstantsHelper.status_Pendiente_SAP:
                        model.status = ConstantsHelper.status_Pendiente;
                        break;
                    case ConstantsHelper.status_Aprobado_SAP:
                        model.status = ConstantsHelper.status_Aprobado;
                        break;
                    case ConstantsHelper.status_Rechazado_SAP:
                        model.status = ConstantsHelper.status_Rechazado;
                        break;
                }
               ;
                model.type = type;
                model.number = item.DraftEntry.ToString();
                model.description = item.Remarks;

                model.cardcode = item.CardCode;
                model.project = item.Project;
                model.cardname = item.CardName;
                model.tcompra = GetTipoCompra(item.U_SYP_TCOMPRA);
                //model.EstadoUser = item.EstadoUser;
                //model.EstadoDoc = item.EstadoDoc;
                switch (item.EstadoUser)
                {
                    case "W":
                        model.EstadoUser = ConstantsHelper.status_Pendiente.ToString();
                        break;
                    case "Y":
                        model.EstadoUser = ConstantsHelper.status_Aprobado.ToString();
                        break;
                    case "N":
                        model.EstadoUser = ConstantsHelper.status_Rechazado.ToString();
                        break;
                }
                switch (item.EstadoDoc)
                {
                    case "W":
                        model.EstadoDoc = ConstantsHelper.status_Pendiente.ToString();
                        break;
                    case "Y":
                        model.EstadoDoc = ConstantsHelper.status_Aprobado.ToString();
                        break;
                    case "N":
                        model.EstadoDoc = ConstantsHelper.status_Rechazado.ToString();
                        break;
                }




                model.Comentario = item.Comentario;
                //nuevos campos
                model.CreateDate = item.CreateDate;
                model.CreateTime = Int32.Parse(item.CreateTime == null ? "0" : item.CreateTime.ToString());
                model.UpdateTime = Int32.Parse(item.UpdateTime == null ? "0" : item.UpdateTime.ToString());
                model.UpdateDate = item.UpdateDate;

                model.UpdateTime2 = Int32.Parse(item.UpdateTime2 == null ? "0" : item.UpdateTime2.ToString());
                model.UpdateDate2 = item.UpdateDate2;


                documentsModels.Add(model);

            });
            //List<ResponseDocumentsModel> documentsModels2 = documentsModels.DistinctBy(t => t.id).ToList().OrderByDescending(t => t.id).ToList();

            List<ResponseDocumentsModel> documentsModelsx = documentsModels.DistinctBy(t => t.id).ToList();
            
            var orderByResult = from s in documentsModelsx
                                orderby s.UpdateDate2 descending, s.UpdateTime2 descending, s.id descending
                                select s;

            List<ResponseDocumentsModel> documentsModels2 = orderByResult.ToList();

            return documentsModels2;
        }

        public static string GetTipoCompra(string TCompra)
        {
            try
            {
                string sTipo = "";

                switch (TCompra)
                {
                    case "*":
                        sTipo = "No asignado";
                        break;
                    case "01":
                        sTipo = "Compra Local";
                        break;
                    case "02":
                        sTipo = "Compra Importaciones";
                        break;
                    case "03":
                        sTipo = "Compra Servicios Generales";
                        break;
                    case "04":
                        sTipo = "Compra Servicios Publicos";
                        break;
                    case "05":
                        sTipo = "Honorarios";
                        break;
                    case "06":
                        sTipo = "Gasto de Importaciones";
                        break;
                    case "CC":
                        sTipo = "Sustento de caja chica";
                        break;
                    case "CG":
                        sTipo = "Consignación";
                        break;
                    case "DT":
                        sTipo = "Documeneto Detracción";
                        break;
                    case "ER":
                        sTipo = "Sustento de entregas a rendir";
                        break;
                    default:
                        sTipo = "No encontrado";
                        break;
                }

                return sTipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static ResponseGetDocumentModel ObtenerDetalleDocumento(CompanyModel company, string SessionId, RequestGetDocumentModel request)
        {
            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.APPROVALREQUESTS + "(" + request.id_doc + ")", SessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //JObject responseContent = JObject.Parse(_response.Content);
                //var value = responseContent["value"].ToString();
                var document = JsonConvert.DeserializeObject<ResponseApprovalRequestsSL>(_response.Content);

                return detalleDocumento(company.SERVERLIC + ConstantsHelper.DRAFTS + "(" + document.DraftEntry + ")", SessionId, request.type, document, company);
            }
            else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("No se encontró documento con el código enviado");
            }
            else
            {
                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                throw new Exception(error.error.message.value);
            }


        }

        private static ResponseGetDocumentModel detalleDocumento(string url, string SessionId, string type, ResponseApprovalRequestsSL document, CompanyModel company)
        {
            var _response = RestHelper.GetSL(url, SessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sapDocument = JsonConvert.DeserializeObject<SapDocumentModel>(_response.Content);
                return ParseDetalleDocuments(sapDocument, type, document, company, SessionId);
            }
            else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("No se encontró documento con el ID");
            }
            throw new Exception("Error al traer el documento");
        }

        private static ResponseGetDocumentModel ParseDetalleDocuments(SapDocumentModel model, string type, ResponseApprovalRequestsSL document, CompanyModel company, string SessionId)
        {
            ResponseGetDocumentModel documentModel = new ResponseGetDocumentModel();

            //Obtener moneda local
            var urlT = company.SERVERLIC + ConstantsHelper.COMPANY_SERVICES;
            var _responseT = RestHelper.PostSL(urlT,"", SessionId);
            JObject responseContentT = JObject.Parse(_responseT.Content);
            string monlocal = responseContentT["LocalCurrency"].ToString();
            

            documentModel.id = document.Code.ToString();//model.DocEntry.ToString();

            switch (document.Status)
            {
                case ConstantsHelper.status_Pendiente_SAP_Detalle:
                    documentModel.status = ConstantsHelper.status_Pendiente;
                    break;
                case ConstantsHelper.status_Aprobado_SAP_Detalle:
                    documentModel.status = ConstantsHelper.status_Aprobado;
                    break;
                case ConstantsHelper.status_Rechazado_SAP_Detale:
                    documentModel.status = ConstantsHelper.status_Rechazado;
                    break;
            }
               ;
            //documentModel.status = 0;
            documentModel.type = type;
            documentModel.number = model.DocNum.ToString();
            documentModel.description = model.Comments;
            documentModel.note = document.Remarks;

            documentModel.information.supplier_code = model.CardCode;
            documentModel.information.supplier_name = model.CardName;
            //documentModel.information.contact = model.ContactPersonCode.ToString();

            //Nuevo
            if (Int32.Parse(model.DocumentsOwner.ToString()) != 0 && Int32.Parse(model.DocumentsOwner.ToString()) != -1)
            {
                urlT = company.SERVERLIC + ConstantsHelper.EMPLOYEES + "(" + model.DocumentsOwner.ToString() + ")";
                _responseT = RestHelper.GetSL(urlT, SessionId);
                responseContentT = JObject.Parse(_responseT.Content);
                string sNombre = responseContentT["LastName"].ToString()+", "+
                                 responseContentT["FirstName"].ToString()+" "+
                                  responseContentT["MiddleName"].ToString();
                documentModel.information.contact = sNombre;
            }
            else
            {
                documentModel.information.contact = "";
            }
        

            documentModel.information.cost_center = model.Address2;
            documentModel.information.accounting_date = model.TaxDate.ToString("dd/MM/yyyy");
            documentModel.information.delivery_date = model.DocDueDate.ToString("dd/MM/yyyy");
            documentModel.information.document_date = model.DocDate.ToString("dd/MM/yyyy");
            documentModel.information.project = model.Project;
            documentModel.information.tcompra =GetTipoCompra( model.U_SYP_TCOMPRA);

            var url = company.SERVERLIC + ConstantsHelper.PAYMENT_TERMS_TYPES + "(" + model.PaymentGroupCode.ToString() + ")";
            var _response = RestHelper.GetSL(url, SessionId);
            JObject responseContent = JObject.Parse(_response.Content);
            var value = responseContent["PaymentTermsGroupName"].ToString();
            documentModel.information.paycontidion = value;//model.PaymentGroupCode.ToString();


            if (model.DocCurrency == monlocal)
            {
                documentModel.amounts.before_discount = model.DocCurrency + (model.DocTotal - model.VatSum+ model.TotalDiscount).ToString("0.00");
                documentModel.amounts.discount = model.DocCurrency + model.TotalDiscount.ToString("0.00");
                documentModel.amounts.tax = model.DocCurrency + model.VatSum.ToString("0.00");
                documentModel.amounts.total = model.DocCurrency + model.DocTotal.ToString("0.00");
            }
            else
            {
                documentModel.amounts.before_discount = model.DocCurrency + (model.DocTotalFc - model.VatSumFc+ model.TotalDiscountFC).ToString("0.00");
                documentModel.amounts.discount = model.DocCurrency + model.TotalDiscountFC.ToString("0.00");
                documentModel.amounts.tax = model.DocCurrency + model.VatSumFc.ToString("0.00");
                documentModel.amounts.total = model.DocCurrency + model.DocTotalFc.ToString("0.00");
            }

            //foreach (SapDocumentLineModel item in model.DocumentLines)
            //{
            //    ResponseGetDocumentModel.Item Item = new Item();
            //    Item.description = item.ItemDescription;
            //    Item.quantity = double.Parse(item.Quantity.ToString());
            //    Item.unit_price = model.DocCurrency + item.UnitPrice.ToString("0.00");
            //    Item.total_price = model.DocCurrency + (model.DocCurrency == monlocal ? item.LineTotal.ToString("0.00") : item.RowTotalFC.ToString("0.00"));

            //}



            model.DocumentLines.ForEach((item =>
            {
                documentModel.items.Add(new ResponseGetDocumentModel.Item
                {
                    description = item.ItemDescription,
                    quantity = double.Parse(item.Quantity.ToString()),
                    unit_price = model.DocCurrency + item.UnitPrice?.ToString("0.00"),
                    total_price = model.DocCurrency + (model.DocCurrency == monlocal ? item.LineTotal?.ToString("0.00") : item.RowTotalFC?.ToString("0.00"))

                });
            }));

            return documentModel;
        }

        public static List<ResponseGetDocumentAttachModel> ObtenerAnexoDocumento(CompanyModel company, string SessionId, RequestGetDocumentModel request)
        {

            var entryAttach = 0;
            var entryDocument = 0;
            var _response = RestHelper.GetSL(company.SERVERLIC + ConstantsHelper.APPROVALREQUESTS + "(" + request.id_doc + ")", SessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //JObject responseContent = JObject.Parse(_response.Content);
                //var value = responseContent["value"].ToString();
                var document = JsonConvert.DeserializeObject<ResponseApprovalRequestsSL>(_response.Content);
                entryDocument = document.DraftEntry;
            }
            else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("No se encontró documento con el código enviado");
            }
            else
            {
                var error = JsonConvert.DeserializeObject<ErrorSLModel>(_response.Content);
                throw new Exception(error.error.message.value);
            }


            entryAttach = detalleAttachmentEntry(company.SERVERLIC + ConstantsHelper.DRAFTS + "(" + entryDocument + ")", SessionId, request.type);

            List<ResponseGetDocumentAttachModel> doc = new List<ResponseGetDocumentAttachModel>();
            if (entryAttach > 0)
            {
                var url = company.SERVERLIC + ConstantsHelper.ATTACHMENTS + "(" + entryAttach + ")?$select=Attachments2_Lines";
                var files = obtenerDetalleAnexo(url, SessionId);
                var pathAnexo = ObtenerUrlAnexo(company, SessionId);

                foreach (var item in files.Attachments2_Lines)
                {
                    if (item.FileExtension.ToUpper() == "PDF")//"pdf"
                    {
                        ResponseGetDocumentAttachModel detail = new ResponseGetDocumentAttachModel();

                        detail.id = item.LineNum.ToString();
                        detail.name = item.FileName;
                        detail.description = item.FreeText == null ? "" :  item.FreeText;
                        string pdfFilePath = pathAnexo + item.FileName + "." + item.FileExtension;
                        byte[] bytes = System.IO.File.ReadAllBytes(pdfFilePath);


                        detail.content = bytes;

                        doc.Add(detail);
                    }
                }


                return doc;
            }
            throw new Exception("No se encontró documentos relacionados");
        }

        public static string ObtenerUrlAnexo(CompanyModel company, string SessionId)
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

        private static AttachmentSLModel obtenerDetalleAnexo(string url, string SessionId)
        {
            var _response = RestHelper.GetSL(url, SessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sapDocument = JsonConvert.DeserializeObject<AttachmentSLModel>(_response.Content);
                if (sapDocument.Attachments2_Lines.Where(t => t.FileExtension == "pdf").Count() > 0)
                    return sapDocument;
                else
                    throw new Exception("No se encontró documentos PDF relacionados");
            }
            else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("No se encontró documento con el ID");
            }
            throw new Exception("Error al buscar el documento");
        }

        private static int detalleAttachmentEntry(string url, string SessionId, string type)
        {
            var _response = RestHelper.GetSL(url, SessionId);

            if (_response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sapDocument = JsonConvert.DeserializeObject<SapDocumentModel>(_response.Content);
                if (sapDocument.AttachmentEntry != null)
                    return sapDocument.AttachmentEntry.Value;
                else
                    throw new Exception("No se encontró documentos relacionados");
            }
            else if (_response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("No se encontró documento con el ID");
            }
            throw new Exception("Error al traer el documento");
        }
    }
}