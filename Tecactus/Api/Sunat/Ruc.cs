using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecactus.Api.Common;
using Tecactus.Api.Exception;

namespace Tecactus.Api.Sunat
{
    public class Ruc
    {
        private TecactusHttp httpClient;

        public Ruc(string token)
        {
            httpClient = new TecactusHttp(this, token);
        }

        public Company get(string ruc)
        {
            httpClient.setRequest("sunat/query/ruc", Method.POST, "Tecactus.Api.Sunat.Company");
            if (validate(ruc))
            {
                httpClient.addParameter("ruc", ruc);
                return httpClient.execute<Company>();
            }
            else
            {
                throw new InvalidRucException("RUC no es válido.");
            }
        }

        public static bool validate(string ruc)
        {
            double num;
            if (Double.TryParse(ruc, out num))
            {
                return ruc.Length == 11;
            }
            return false;
        }
    }
}
