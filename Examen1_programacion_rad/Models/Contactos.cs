using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen1_programacion_rad.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
       
        public int id { get; set; }
        public string   Nombre { get; set; }
        [MaxLength(100), Unique]

        public string Telefono { get; set; }
        [MaxLength(100)]
        public string Edad { get; set; }
        [MaxLength(100)]

        public string Pais { get; set;}
        [MaxLength(300)]

        public string Nota { get; set;}

        public byte[] Foto { get; set; }
    }
}
