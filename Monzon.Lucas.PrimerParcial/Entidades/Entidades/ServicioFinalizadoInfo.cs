using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class ServicioFinalizadoInfo
    {
        private int minutosDeUso;
        private float brutoAPagar;
        private float netoAPagar;
        private float montoFinal;

        public ServicioFinalizadoInfo(int minutosDeUso, float brutoAPagar, 
            float netoAPagar, float montoFinal)
        {
            this.minutosDeUso = minutosDeUso;
            this.brutoAPagar = brutoAPagar;
            this.netoAPagar = netoAPagar;
            this.montoFinal = montoFinal;
        }

        public int MinutosDeUso
        {
            get
            {
                return this.minutosDeUso;
            }
        }

        public float BrutoAPagar
        {
            get
            {
                return this.brutoAPagar;
            }
        }

        public float NetoAPagar
        {
            get
            {
                return this.netoAPagar;
            }
        }

        public float MontoFinal
        {
            get
            {
                return this.montoFinal;
            }
        }
    }
}
