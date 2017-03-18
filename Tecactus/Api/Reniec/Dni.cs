using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecactus.Api.Common;
using Tecactus.Api.Exception;

namespace Tecactus.Api.Reniec
{
    public class Dni
    {
        private TecactusHttp httpClient;

        public Dni(string token)
        {
            this.httpClient = new TecactusHttp(this, token);
            this.httpClient.setRequest("reniec/dni", Method.POST, "Tecactus.Api.Reniec.Person");
        }

        public Person get(string dni)
        {
            if (this.validate(dni))
            {
                this.httpClient.addParameter("dni", dni);
                return this.httpClient.execute<Person>();
            } else
            {
                throw new InvalidDniException("DNI no es válido.");
            }
        }

        private bool validate(string dni)
        {
            int num;
            if (int.TryParse(dni, out num))
            {
                return dni.Length == 8;
            }
            return false;
        }
    }
}
