using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Enum
    {
        public enum Tipo { A_Disco, Con_Teclado };
        public enum Marca { Elgin, Siemens, Alcatel };
        public enum TipoLlamada { Local, Larga_Distancia, Internacional };
        public enum Software { Office, Messenger, Icq, Ares };
        public enum Periferico { Camara, Auriculares, Microfono, Mouse };
        public enum Juego { Counter_Strike, Diablo_II, Mu_Online, LineAge_II, 
            warcraft_III, Age_II };
        public enum Procesador { Pentium_III, Pentium_4, AMD_Athon };
        public enum DiscoDuro { Gb_10, Gb_20 };
        public enum PlacaDeVideo { GeForce2_MX_100, GeForce2_PRO, GeForce2_Ti };
        public enum Ram { Mb_128, Mb_64, Mb_32 };
    }
}
