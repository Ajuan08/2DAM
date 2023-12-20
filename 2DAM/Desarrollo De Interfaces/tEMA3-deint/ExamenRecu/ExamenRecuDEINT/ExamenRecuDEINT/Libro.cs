using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuDEINT
{
    public enum TipoGenero
    {
        LITERARURA,CLASICA,OBRA_MAESTRA
    }
    public class Libro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public DateTime anoPublicacion { get; set; }
        public int Editorial { get; set; }
        public TipoGenero Genero { get; set; }

        public Libro() { }
        public Libro(int iSBN, string titulo, string autor, DateTime anoPublicacion, int editorial, TipoGenero genero)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            this.anoPublicacion = anoPublicacion;
            Editorial = editorial;
            Genero = genero;
        }
    }
}
