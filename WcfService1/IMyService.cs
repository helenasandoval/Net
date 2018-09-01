using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMyService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Usuario> ObtenerUsuarios();

        [OperationContract]
        int AgregarUsuario(int Id, string Nombre, string Direccion, DateTime FechaNacimiento, string Cedula, int TipoDocumento, string Pais, string Departamento, string CiudadNacimiento);

        [OperationContract]
        int ActualizarUsuario(int Id, string Nombre, string Direccion, DateTime FechaNacimiento, string Cedula, int TipoDocumento, string Pais, string Departamento, string CiudadNacimiento);

        [OperationContract]
        int EliminarUsuario(int Id);

        [OperationContract]
        Usuario ObtenerPorId(int Id);
    }
}
