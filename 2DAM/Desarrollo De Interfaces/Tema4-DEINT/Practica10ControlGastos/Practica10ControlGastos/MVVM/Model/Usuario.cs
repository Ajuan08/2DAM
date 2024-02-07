using Practica10ControlGastos.Abstraction;
using PropertyChanged;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10ControlGastos.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    [Table("Usuario")]
    public class Usuario : TableData
    {
        [Column("Nombre"), NotNull]
        public string Nombre { get; set; }

        [Column("Saldo"), NotNull]
        public double Saldo { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Transaccion> Transacciones { get; set; }
    }
}
