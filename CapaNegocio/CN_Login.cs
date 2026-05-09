using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Login
    {
        CD_Login datos = new CD_Login();
        public DataTable Entrar(string user, string pass)
        {
            return datos.Entrar(user, pass);
        }
    }
}
