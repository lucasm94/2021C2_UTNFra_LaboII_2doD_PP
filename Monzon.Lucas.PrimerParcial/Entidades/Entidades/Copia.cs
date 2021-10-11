using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Copia
    {
        private int cantidad;
        private int ganancia;

        public Copia(int cantidad, int ganancia)
        {
            this.cantidad = cantidad;
            this.ganancia = ganancia;
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public int Ganancia
        {
            get
            {
                return this.ganancia;
            }
            set
            {
                this.ganancia = value;
            }
        }
    }
}
