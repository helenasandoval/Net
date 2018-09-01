using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp2.Models;

namespace MvcApp2.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        ServiceReference1.MyServiceClient sr = new ServiceReference1.MyServiceClient();
        public ActionResult Index()
        {
            List<User> lstResultados = new List<User>();

            var lst = sr.ObtenerUsuarios();

            foreach (var item in lst) {

                User usr = new User();

                usr.IdUsuario = item.IdUsuario;
                usr.Nombre = item.Nombre;
                usr.Direccion = item.Direccion;
                usr.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
                usr.Cedula = item.Cedula;
                usr.TipoDocumento = Convert.ToInt32(item.TipoDocumento);
                usr.Pais = item.Pais;
                usr.Departamento = item.Departamento;
                usr.CiudadNacimiento = item.CiudadNacimiento;
                lstResultados.Add(usr);

            }


            return View(lstResultados);
        }

        public ActionResult Add()
        {
            return View();       
        }

        [HttpPost]
        public ActionResult Add(User item) {

            User usr = new User();
            usr.Nombre = item.Nombre;
            usr.Direccion = item.Direccion;
            usr.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
            usr.Cedula = item.Cedula;
            usr.TipoDocumento = Convert.ToInt32(item.TipoDocumento);
            usr.Pais = item.Pais;
            usr.Departamento = item.Departamento;
            usr.CiudadNacimiento = item.CiudadNacimiento;
            sr.AgregarUsuario(usr.IdUsuario,usr.Nombre, usr.Direccion,usr.FechaNacimiento, usr.Cedula, usr.TipoDocumento,usr.Pais,usr.Departamento,usr.CiudadNacimiento);
            return RedirectToAction("Index","Usuario");
        }

        public ActionResult Edit(int id)
        {

            var item = sr.ObtenerPorId(id);

            User usr = new User();
            usr.IdUsuario = item.IdUsuario;
            usr.Nombre = item.Nombre;
            usr.Direccion = item.Direccion;
            usr.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
            usr.Cedula = item.Cedula;
            usr.TipoDocumento = Convert.ToInt32(item.TipoDocumento);
            usr.Pais = item.Pais;
            usr.Departamento = item.Departamento;
            usr.CiudadNacimiento = item.CiudadNacimiento;
            return View(usr);
        }

        [HttpPost]
        public ActionResult Edit(User item) {

            User usr = new User();
            usr.IdUsuario = item.IdUsuario;
            usr.Nombre = item.Nombre;
            usr.Direccion = item.Direccion;
            usr.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
            usr.Cedula = item.Cedula;
            usr.TipoDocumento = Convert.ToInt32(item.TipoDocumento);
            usr.Pais = item.Pais;
            usr.Departamento = item.Departamento;
            usr.CiudadNacimiento = item.CiudadNacimiento;

            int ValorRetorno = sr.ActualizarUsuario(usr.IdUsuario, usr.Nombre, usr.Direccion, usr.FechaNacimiento, usr.Cedula, usr.TipoDocumento, usr.Pais, usr.Departamento, usr.CiudadNacimiento);

            if (ValorRetorno > 0)
            {
                return RedirectToAction("Index","Usuario");
            }

            return View();

        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            int ValorRetorno = sr.EliminarUsuario(Convert.ToInt32(id));
            if (ValorRetorno > 0)
            {
                return RedirectToAction("Index", "Usuario");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {

            var item = sr.ObtenerPorId(id);

            User usr = new User();
            usr.IdUsuario = item.IdUsuario;
            usr.Nombre = item.Nombre;
            usr.Direccion = item.Direccion;
            usr.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
            usr.Cedula = item.Cedula;
            usr.TipoDocumento = Convert.ToInt32(item.TipoDocumento);
            usr.Pais = item.Pais;
            usr.Departamento = item.Departamento;
            usr.CiudadNacimiento = item.CiudadNacimiento;
            return View(usr);
        }



    }
}