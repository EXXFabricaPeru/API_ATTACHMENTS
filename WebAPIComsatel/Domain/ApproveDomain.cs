using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;
using WebAPIComsatel.Models.Response;

namespace WebAPIComsatel.Domain
{
    public class ApproveDomain
    {
        public static ResponseSuccessModel AprobarDesaprobarDocumento(CompanyModel company, string SessionID, RequestApprovalModel request,string estado)
        {
            ResponseSuccessModel responseSuccess = new ResponseSuccessModel();

            RequestApprovalSLModel requestApprovalSLModel = new RequestApprovalSLModel();

            requestApprovalSLModel.ApprovalRequestDecisions.Add(new RequestApprovalSLModel.ApprovalRequestDecision
            {
                Status = estado,
                Remarks = request.note
            });

            var jsonBody = JsonConvert.SerializeObject(requestApprovalSLModel, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            });//.Replace("\\", "");

            var _response = RestHelper.PatchSL(company.SERVERLIC + ConstantsHelper.APPROVALREQUESTS + "(" + request.id_doc + ")", jsonBody, SessionID);


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
            return null;
            
        }

       
    }
}