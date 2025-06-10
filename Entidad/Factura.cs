using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class Factura
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }      
        public string? Especialidad { get; set; }   
        public string? Email { get; set; }


         public decimal Monto { get; set; }
         public DateTime Fecha { get; set; }

    }
}
