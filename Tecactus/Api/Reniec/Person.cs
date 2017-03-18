using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecactus.Api.Reniec
{
    public class Person
    {
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string caracter_verificacion { get; set; }
        public string caracter_verificacion_anterior { get; set; }
    }
}
