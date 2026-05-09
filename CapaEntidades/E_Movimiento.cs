using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Movimiento
    {
        public int Id_Movimiento { get; set; }
        public string Tipo_Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Usuario { get; set; }
    }
}
