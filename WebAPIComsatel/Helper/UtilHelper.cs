using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebAPIComsatel.Helper
{
    public class UtilHelper
    {
        public static int ValorSkip(string queryString)
        {
            //string queryString = "BusinessPartners?$filter=CardType%20eq%20%27cSupplier%27&$skip=200";
            string pattern = @"skip=(\d+)";
            Match match = Regex.Match(queryString, pattern);

            if (match.Success)
            {
                string skipValue = match.Groups[1].Value;
                Console.WriteLine("El valor de $skip es: " + skipValue);
                return int.Parse(skipValue);
            }
            else
            {
                Console.WriteLine("No se encontró el parámetro $skip en la cadena.");
                return 0;
            }
        }
    }
}