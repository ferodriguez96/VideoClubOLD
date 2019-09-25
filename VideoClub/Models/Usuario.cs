using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public abstract class Usuario
    {
        private string id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
    }
}
