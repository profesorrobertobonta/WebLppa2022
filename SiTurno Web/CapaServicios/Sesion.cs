using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces;

namespace CapaServicios
{
    public class Sesion
    { 

    static IUsuario _session;
   
    public IUsuario Session
    {
        get
        {
            return _session;
        }
    }


    public void Login(IUsuario usuario)
    {
        _session = usuario;
    }

    public void Logout()
    {
        _session = null;
        //Notificar(TraductorRepo.ObtenerIdiomaDefault());
    }
    public bool IsLogged()
    {
        return _session != null;

    }

    }

 }
