using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaServicios;
using CapaDatos;
using CapaInterfaces;


namespace CapaNegocios
{
    public class UsuarioCN
    {

        public string Login (Usuario LoginUsuario)
        {

            if (SingletonSesion.Instancia.IsLogged())

                throw new Exception("Ya hay una sesión iniciada");
            //return "Ya hay una sesión iniciada";


            Usuario objUsuLogin = new Usuario();
            UsuarioCD objUsuLoginCD = new UsuarioCD();
            objUsuLogin = objUsuLoginCD.ListarUsuario(LoginUsuario);


            if (objUsuLogin == null)

                throw new Exception("El Usuario es Invalido");
            //return "El Usuario es Invalido";

            //if (!Encryption.Hash(LoginUsuario.Password).Equals(objUsuLogin.Password))
            if ((LoginUsuario.Password) != (objUsuLogin.Password))
            {
                throw new Exception("El Password es Invalido");
                //return "El Password es Invalido";
            }
            else
            {
                SingletonSesion.Instancia.Login(objUsuLogin);


                throw new Exception("Se ha logeado correctamente");

                //return "Se ha logeado correctamente";
            }
        }
    }
}
