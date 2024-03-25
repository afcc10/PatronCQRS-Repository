using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("tipo_de_permisos")]
    public class TipoPermisos
    {
        [Column("id_tipo_permiso")]
        public int Id { get; set; }
        [Column("tipo")]
        public string Tipo { get; set; }
    }
}
