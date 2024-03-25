using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class EmpleadoDto
    {
        
        public int Id { get; set; }
        
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }
        
        public string Departamento { get; set; }
        
        public string Email { get; set; }
        
        public string Telefono { get; set; }
    }
}
