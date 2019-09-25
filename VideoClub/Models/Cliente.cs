using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Cliente : Usuario
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string dni { get; set; }
        private string domicilio { get; set; }
        private string email { get; set; }

        private List<Alquiler> alquileres { get; set; }
    }
}
