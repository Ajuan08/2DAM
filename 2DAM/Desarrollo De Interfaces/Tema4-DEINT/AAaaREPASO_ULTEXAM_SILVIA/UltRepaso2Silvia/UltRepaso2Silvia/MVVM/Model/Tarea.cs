using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltRepaso2Silvia.Abstraction;

namespace UltRepaso2Silvia.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]

    [Table("Tareas")]
    public class Tarea : TableData
    {
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }
    }
}
