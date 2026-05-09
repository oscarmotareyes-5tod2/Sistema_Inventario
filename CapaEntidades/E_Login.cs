using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Login
    {
        public static class Sesion
        {
            public static int IdUsuario { get; set; }
            public static string Nombre { get; set; }
            public static string Rol { get; set; }
        }
    }
}
