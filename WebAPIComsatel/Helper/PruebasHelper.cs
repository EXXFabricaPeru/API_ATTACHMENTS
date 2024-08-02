using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebAPIComsatel.Helper
{
    public static class PruebasHelper
    {
        public static void WriteTxt(string x)//, string filename
        {
            string path = null; //= System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
            path = "C:\\Users\\TCONSULTING\\Documents\\TOUCH";
            //path = path + "\\" + Globals.BDSAP_2;

            string filename = String.Concat(DateTime.Now.ToString("yyyyMMdd"),DateTime.Now.Hour.ToString(),DateTime.Now.Minute.ToString());

            string FILE_NAME = path + "\\LOG\\" + filename + ".txt";
            if (System.IO.File.Exists(FILE_NAME) == false)
            {
                System.IO.File.Create(FILE_NAME).Dispose();
            }

            string texto = "***************************************************\n";

            texto += x;

            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(FILE_NAME, true);
            objWriter.WriteLine(texto);
            objWriter.Close();
        }
    }
}
