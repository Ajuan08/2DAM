using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class GamaProducto
    {
        public string Gama { get; set; }
        public string DescripcionTexto { get; set; }
        public string DescripcionHtml { get; set; }
        public string Imagen { get; set; }
        public GamaProducto()
        {
        }
        public GamaProducto(string gama, string descripcionTexto, string descripcionHtml, string imagen)
        {
            Gama = gama;
            DescripcionTexto = descripcionTexto;
            DescripcionHtml = descripcionHtml;
            Imagen = imagen;
        }
    }

}
