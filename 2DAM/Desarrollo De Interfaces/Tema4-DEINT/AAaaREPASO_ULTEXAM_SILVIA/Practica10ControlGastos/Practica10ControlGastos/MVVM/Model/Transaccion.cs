using Practica10ControlGastos.Abstraction;
using PropertyChanged;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10ControlGastos.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]

    [Table("Transaccion")]
    public class Transaccion : TableData
    {
        [Column("Descripcion"), NotNull]
        public string Descripcion { get; set; }

        [Column("Cantidad"), NotNull]
        public string Cantidad { get; set; }

        [Column("Fecha"), NotNull]
        public DateTime Fecha { get; set; }

        [Column("EsIngreso"), NotNull]
        public bool EsIngreso { get; set; }
    }
}
