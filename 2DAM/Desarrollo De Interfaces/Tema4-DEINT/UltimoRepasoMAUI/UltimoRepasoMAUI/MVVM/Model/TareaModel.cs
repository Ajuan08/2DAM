using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimoRepasoMAUI.Abstraction;

namespace UltimoRepasoMAUI.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    [SQLite.Table("Tarea")]
    public class TareaModel : TableData
    {
        [SQLite.Column("Nombre"),NotNull]
        public string Nombre { get; set; }

        [SQLite.Column("Descripcion")]
        public string Descripcion { get; set; }

    }
}
