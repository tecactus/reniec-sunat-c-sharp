﻿using RestSharp;
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
            httpClient = new TecactusHttp(this, token);
            httpClient.setRequest("reniec/dni", Method.POST, "Tecactus.Api.Reniec.Person");
        }

        public Person get(string dni)
        {
            if (validate(dni))
            {
                httpClient.addParameter("dni", dni);
                return httpClient.execute<Person>();
            } else
            {
                throw new InvalidDniException("DNI no es válido.");
            }
        }

        public static bool validate(string dni)
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
