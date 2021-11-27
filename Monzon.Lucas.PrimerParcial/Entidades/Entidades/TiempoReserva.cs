using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class TiempoReserva
    {
        string[] tiempoReserva = new string[3]
        {
            "MediaHora", "UnaHora", "Libre"
        };

        public string this[int index]
        {
            get
            {
                return tiempoReserva[index];
            }
        }
    }
}
