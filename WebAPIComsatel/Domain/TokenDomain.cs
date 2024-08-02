using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Domain
{
    public class TokenDomain
    {
        internal static bool validar(string access)
        {
            if (access == "5245shsynspoujhgvn85")
            {
                return true;
            }
            else
            { return false; }
        }
    }
}