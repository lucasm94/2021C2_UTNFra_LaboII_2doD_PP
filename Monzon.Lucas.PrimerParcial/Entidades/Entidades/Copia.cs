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
        private float ganancia;

        public Copia() : this(0, 0)
        {

        }

        public Copia(int cantidad, float ganancia)
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

        public float Ganancia
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
