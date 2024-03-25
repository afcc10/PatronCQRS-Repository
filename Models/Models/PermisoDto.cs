using System;

namespace Models.Models
{
    public class PermisoDto
    {        
        public int Id { get; set; }      
        public int IdEmpleado { get; set; }       
        public DateTime FechaSolicitud { get; set; }       
        public string Motivo { get; set; }       
        public string Estado { get; set; }
    }
}
