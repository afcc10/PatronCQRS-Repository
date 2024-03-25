using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("permisos")]
    public class Permisos
    {
        [Column("id_permiso")]
        public int Id { get; set; }
        [Column("id_empleado")]
        public int IdEmpleado { get; set; }
        [Column("fecha_solicitud")]
        public DateTime FechaSolicitud { get; set; }
        [Column("motivo")]
        public string Motivo { get; set; }
        [Column("estado")]
        public string Estado { get; set; }
    }
}
