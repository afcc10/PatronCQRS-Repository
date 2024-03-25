using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("empleados")]
    public class Empleados
    {
        [Column("id_empleado")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("apellido")]
        public string Apellido { get; set; }
        [Column("departamento")]
        public string Departamento { get; set; }
        [Column("correo_electronico")]
        public string Email { get; set; }
        [Column("telefono")]
        public string Telefono { get; set; }
    }
}
