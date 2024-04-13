using EjS10.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjS10.ClaseHija
{
    internal class PlayStation:ClsConsola
    {
        public string ModeloControlador {  get; set; }
        public string MostrarDetallePlay()
        {
            return MostrarDetalles() + "Controlador: " + ModeloControlador;
        }
    }
}
