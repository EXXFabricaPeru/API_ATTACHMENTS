using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIComsatel.Models;

namespace WebAPIComsatel.Helper
{
    public static class ResponseHelper
    {
        public static ResponseError DevolverError(int code, string message)
        {
            ResponseError response = new ResponseError();
            ResponseError.Error error = new ResponseError.Error();
            error.code = code;
            error.message = message;
            response.error = error;

            return response;
        }
    }
}