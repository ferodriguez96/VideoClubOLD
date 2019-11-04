using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Devolucion
    {
        public Guid Id { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public float PrecioFinal { get; set; }
    }
}
