using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIComsatel.Domain;
using WebAPIComsatel.Domain.Interface;
using WebAPIComsatel.Helper;
using WebAPIComsatel.Models.Request;

namespace WebAPIComsatel.Controllers
{
    public class AttachmentsController : ApiController
    {
        // GET: Attachments


        static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public IHttpActionResult Post([FromBody] RequestAttachmentModel model, [FromUri] int id)
        {
            try
            {

                IAttachmentsDomain attachmentsDomain = GetDomain<AttachmentsDomain>(); ;
                var response = attachmentsDomain.ActualizarAttachments(model,id);

                return Ok(response);
            }
            catch (Exception ex)
            {

                log.Error(ex.Message, ex);

                return Content(HttpStatusCode.BadRequest, ResponseHelper.DevolverError(104, ex.Message + " - " + ex.StackTrace));
            }
            return Ok();
        }

       
        public IHttpActionResult Post([FromBody] RequestAttachmentModel model)
        {
            try
            {

                //return Ok(model.attachmentLines);
                IAttachmentsDomain attachmentsDomain = GetDomain<AttachmentsDomain>(); ;
                var response = attachmentsDomain.GenerarAttachments(model);

                return Ok(response);
            }
            catch (Exception ex)
            {

                log.Error(ex.Message, ex);

                return Content(HttpStatusCode.BadRequest, ResponseHelper.DevolverError(104, ex.Message+" - " + ex.StackTrace));
            }
            return Ok();
        }

        private T GetDomain<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}