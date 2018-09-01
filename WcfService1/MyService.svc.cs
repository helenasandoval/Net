using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MyService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MyService.svc o MyService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MyService : IMyService
    {
        public void DoWork()
        {
        }


        public List<Usuario> ObtenerUsuarios() {

            List<Usuario> userlst = new List<Usuario>();
            TestDBEntities tstDb = new TestDBEntities();
            var lstUsr = from k in tstDb.Usuario select k;

            foreach (var item in lstUsr) {
                Usuario usr = new Usuario();
                usr.IdUsuario = item.IdUsuario;
                usr.Nombre = item.Nombre;
                usr.Direccion = item.Direccion;
                usr.FechaNacimiento = item.FechaNacimiento;
                usr.Cedula = item.Cedula;
                usr.TipoDocumento = item.TipoDocumento;
                usr.Pais = item.Pais;
                usr.Departamento = item.Departamento;
                usr.CiudadNacimiento = item.CiudadNacimiento;
                userlst.Add(usr);
            }

            return userlst;

        }

        public int AgregarUsuario(int Id, string Nombre, string Direccion, DateTime FechaNacimiento, string Cedula, int TipoDocumento, string Pais, string Departamento, string CiudadNacimiento)
        {
            TestDBEntities tstDb = new TestDBEntities();
            Usuario usr = new Usuario();
            usr.Nombre = Nombre;
            usr.Direccion = Direccion;
            usr.FechaNacimiento = FechaNacimiento;
            usr.Cedula = Cedula;
            usr.TipoDocumento = TipoDocumento;
            usr.Pais = Pais;
            usr.Departamento = Departamento;
            usr.CiudadNacimiento = CiudadNacimiento;
            tstDb.Usuario.Add(usr);
            int ValorRetorno = tstDb.SaveChanges();
            return ValorRetorno;
        }

        public int ActualizarUsuario(int Id, string Nombre, string Direccion, DateTime FechaNacimiento, string Cedula, int TipoDocumento, string Pais, string Departamento, string CiudadNacimiento)
        {
            TestDBEntities tstDb = new TestDBEntities();
            Usuario usr = new Usuario();
            usr.IdUsuario = Id;
            usr.Nombre = Nombre;
            usr.Direccion = Direccion;
            usr.FechaNacimiento = FechaNacimiento;
            usr.Cedula = Cedula;
            usr.TipoDocumento = TipoDocumento;
            usr.Pais = Pais;
            usr.Departamento = Departamento;
            usr.CiudadNacimiento = CiudadNacimiento;
            tstDb.Entry(usr).State = System.Data.Entity.EntityState.Modified;
            int ValorRetorno = tstDb.SaveChanges();
            return ValorRetorno;
        }

        public int EliminarUsuario(int Id) {
            TestDBEntities tstDb = new TestDBEntities();
            Usuario usr = new Usuario();
            usr.IdUsuario = Id;
            tstDb.Entry(usr).State = System.Data.Entity.EntityState.Deleted;
            int ValorRetorno = tstDb.SaveChanges();
            return ValorRetorno;
        }

        public Usuario ObtenerPorId(int Id)
        {
            TestDBEntities tstDb = new TestDBEntities();
            var Lista = from k in tstDb.Usuario where k.IdUsuario == Id select k;
            Usuario usr = new Usuario();

            foreach (var item in Lista) {
                usr.IdUsuario = item.IdUsuario;
                usr.Nombre = item.Nombre;
                usr.Direccion = item.Direccion;
                usr.FechaNacimiento = item.FechaNacimiento;
                usr.Cedula = item.Cedula;
                usr.TipoDocumento = item.TipoDocumento;
                usr.Pais = item.Pais;
                usr.Departamento = item.Departamento;
                usr.CiudadNacimiento = item.CiudadNacimiento;

            }

            return usr;

        }



    }
}
