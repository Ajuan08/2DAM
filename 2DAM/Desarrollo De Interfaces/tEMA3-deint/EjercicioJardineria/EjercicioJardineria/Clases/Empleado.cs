using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJardineria.Clases
{
    public class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string CodigoOficina { get; set; }
        public int? CodigoJefe { get; set; }
        public string Puesto { get; set; }
        public Empleado()
        {
        }
        public Empleado(int codigoEmpleado, string nombre, string apellido1, string apellido2, string extension, string email, string codigoOficina, int? codigoJefe, string puesto)
        {
            CodigoEmpleado = codigoEmpleado;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Extension = extension;
            Email = email;
            CodigoOficina = codigoOficina;
            CodigoJefe = codigoJefe;
            Puesto = puesto;
        }
    }

}
