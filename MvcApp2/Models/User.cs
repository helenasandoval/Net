using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp2.Models
{
    public class User
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public int TipoDocumento { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string CiudadNacimiento { get; set; }
    }
}