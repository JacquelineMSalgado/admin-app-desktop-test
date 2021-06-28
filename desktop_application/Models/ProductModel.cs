using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_application.Models
{
    class ProductModel
    {
        public int IDProductos { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public int Existencias { get; set; }
        public float Total { get; set; }
        public int CantidadVendida { get; set; }
        public string Mes { get; set; }
    }

    class VentasModel
    {
        public int CantidadVendida { get; set; }
        public float Total { get; set; }
        public string Mes { get; set; }
    }
}
