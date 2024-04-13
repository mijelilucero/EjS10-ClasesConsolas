using EjS10.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjS10.ClaseHija
{
    internal class SegaDreamCast:ClsConsola
    {
        public bool PantallaEnControl { get; set; }
        public string MostrarDetalleSegaDreamCast()
        {
            return MostrarDetalles() + " Pantalla en el control: " + PantallaEnControl;
        }
    }
}
