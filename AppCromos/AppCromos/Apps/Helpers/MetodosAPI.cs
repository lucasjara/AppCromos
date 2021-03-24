using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace AppCromos.Apps.Helpers
{
    public class MetodosAPI
    {
        public string ObtenerJSON()
        {
            string respuestaString = "";
            try
            {
                Uri uri = new Uri("https://www.infest.cl/test/test.json");
                NameValueCollection parametros = new NameValueCollection
                    {
                        { "NickName", ""  }
                    };

                byte[] respuestaByte = new WebClient().UploadValues(uri, "POST", parametros);
                respuestaString = Encoding.UTF8.GetString(respuestaByte);
            }
            catch (Exception)
            {
                respuestaString = "[\"N\",\"Error al Enviar la petición.\"]";
            }
            return respuestaString;
        }
    }
}
