using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Servicio
    {
        protected string id;
        protected int dniCliente;
        protected DateTime inicio;
        protected DateTime? fin;
        protected float pago;

        public Servicio(int dniCliente, DateTime inicio)
        {
            this.id = GenerarId();
            this.dniCliente = dniCliente;
            this.inicio = inicio;
            this.pago = 0;
            this.fin = null;
        }

        public abstract float CostoDeUso();

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public int DniCliente
        {
            get
            {
                return this.dniCliente;
            }
        }

        public DateTime Inicio
        {
            get
            {
                return this.inicio;
            }
        }

        public DateTime Fin
        {
            get
            {
                return (DateTime)this.fin;
            }
            set
            {
                this.fin = value;
            }
        }

        private string GenerarId()
        {
            int random = new Random().Next();
            return "S" + random.ToString() + "S";
        }

        public override string ToString()
        {
            string finStr = (this.fin == null) ? "No finalizo" : this.fin.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"idServicio={this.id}");
            sb.AppendFormat($"dniCliente={this.dniCliente}");
            sb.AppendFormat($"inicio={this.inicio.ToString()}");
            sb.AppendFormat($"fin={finStr}");
            sb.AppendFormat($"pago={this.pago}");
            return sb.ToString();
        }

    }
}
