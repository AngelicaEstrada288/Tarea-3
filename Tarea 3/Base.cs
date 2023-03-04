using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_3.Models
{
    internal class Base
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string nombre { get; set; }
        [MaxLength(100)]
        public string apellido { get; set; }
        [MaxLength(20)]
        public string edad { get; set; }
        [MaxLength(100)]
        public string correo { get; set; }
        [MaxLength(100)]
        public string direccion { get; set; }
    }
}
