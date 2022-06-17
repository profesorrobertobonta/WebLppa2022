using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces;


namespace CapaEntidades
{
    public class Usuario :IUsuario
    {
        public int Id { get; set; }
        public string Usuarios { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Usuarios;
        }
    }
    
}
