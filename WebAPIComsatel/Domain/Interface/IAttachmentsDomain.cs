using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIComsatel.Models;
using WebAPIComsatel.Models.Request;

namespace WebAPIComsatel.Domain.Interface
{
    public interface IAttachmentsDomain
    {
        AttachmentSLModel GenerarAttachments(RequestAttachmentModel model);
        AttachmentSLModel ActualizarAttachments(RequestAttachmentModel model, int id);
    }
}
