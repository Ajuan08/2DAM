using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Exam_DEINT.Clases
{
    public class Vehiculo
    {
        public int IdenNum {  get; set; }

        public string Matricula { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }
        public int AñoFabricacion { get; set; }

        public string Estado {  get; set; }

        public Vehiculo() { }

        public Vehiculo(int idenNum, string matricula, string modelo, string marca, int añoFabricacion, string estado)
        {
            IdenNum = idenNum;
            Matricula = matricula;
            Modelo = modelo;
            Marca = marca;
            AñoFabricacion = añoFabricacion;
            Estado = estado;
        }
    }
}
