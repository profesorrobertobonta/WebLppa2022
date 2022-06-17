using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces
{
    public class IUsuario
    {
        int Id { get; set; }
        string Usuario { get; set; }
        string Password { get; set; }
    }
}
