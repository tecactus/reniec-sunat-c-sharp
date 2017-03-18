﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecactus.Api.Exception;
using Tecactus.Api.Reniec;
using Tecactus.Api.Sunat;

namespace Tecactus.Api.Common
{
    class TecactusHttp
    {
        private RestClient client;
        protected RestRequest request { get; set; }
        private object actionType;
        private string token;

        public TecactusHttp(object instance, string token)
        {
            this.actionType = instance;
            this.token = token;
            this.client = new RestClient("https://tecactus.com/api");
        }

        public void setRequest(string url, Method method, string rootElement)
        {
            this.request = new RestRequest(url, method);
            this.request.RootElement = rootElement;
            this.request.AddHeader("Accept", "application/json");
            this.request.AddHeader("Authorization", "Bearer " + this.token);
        }

        public void addParameter(string name, string data)
        {
            this.request.AddParameter(name, data);
        }

        public T execute<T>() where T : new()
        {
            var response = this.client.Execute<T>(this.request);
            
            switch (response.StatusCode.GetHashCode())
            {
                case 200:
                    if (this.actionType is Dni)
                    {
                        switch (response.Content)
                        {
                            case "\"DNI no es válido.\"":
                                throw new InvalidDniException("DNI no es válido.");

                            case "\"DNI no existe.\"":
                                throw new DniNotFoundException("DNI no existe.");

                            case "\"El DNI pertenece a un menor de edad.\"":
                                throw new DniUnderageException("El DNI pertenece a un menor de edad.");

                            case "\"Cancelado por fallecimiento.\"":
                                throw new CanceledByDeathException("Cancelado por fallecimiento.");

                            default:
                                return response.Data;
                        }

                    } else
                    {
                        switch (response.Content)
                        {
                            case "\"El RUC no es válido.\"":
                                throw new InvalidRucException("El RUC no es válido.");

                            case "\"No hay ningún registro RUC para el DNI.\"":
                                throw new RucNotfoundException("No hay ningún registro RUC para el DNI.");

                            default:
                                return response.Data;
                        }
                    }
                case 401:
                    throw new UnauthenticatedException("No estas autenticado.");

                case 404:
                    throw new PageNotFoundException("Página no encontrada.");

                case 503:
                    throw new TryAgainInSecondsException("Intenta nuevamente en unos segundos.");

                case 500:
                    throw new InternalServerErrorException("Error del Servidor. Contacte con un administrador.");

                case 429:
                    throw new TooManyRequestException("Demasiadas solicitudes. Has superado tu cuota.");

                default:
                    break;
            }

            return response.Data;
        }
    }
}
