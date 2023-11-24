using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Exam
{
    abstract class Publicacion : Ipublicacion
    {
        public Publicacion() { }

        public Publicacion(string titulo, string autor, DateTime año):base(titulo,autor,año) 
        {
            try
            {
                if(string.IsNullOrEmpty(titulo)) 
                {
                    throw new ExcepcionTitulo("El Titulo no es correcto");    
                }else if (string.IsNullOrEmpty(autor))
                {
                    throw new ExcepcionAutor("El autor no es correcto");
                }else if (año.Equals(string.Empty))
                {
                    throw new ExcepcionAño("El año introducido no es correcto");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public override string ToString()
        {
            return MostrarDetalles();
        }


    }
}
