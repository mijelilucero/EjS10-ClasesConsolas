using EjS10.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjS10.ClaseHija
{
    internal class Xbox : ClsConsola
    {
        public bool kinet { get; set; }
        public string MostrarDetalleXbox()
        {
            return MostrarDetalles() + " Kinet: " + kinet;
        }
    }
}
