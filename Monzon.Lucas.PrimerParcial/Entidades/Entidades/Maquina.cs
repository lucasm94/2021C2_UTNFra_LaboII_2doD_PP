using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public sealed class Maquina : Servicio
    {
        private string idComputadora;
        private Enum.TiempoReserva tiempoReserva;

        public Maquina(string idComputadora, Enum.TiempoReserva tiempoReserva, int dniCliente, 
            DateTime inicio) : base(dniCliente, inicio)
        {
            this.idComputadora = idComputadora;
            this.tiempoReserva = tiempoReserva;
        }

        public string IdComputadora
        {
            get
            {
                return this.idComputadora;
            }
        }

        public Enum.TiempoReserva TiempoReserva
        {
            get
            {
                return this.tiempoReserva;
            }
        }

        public static bool operator ==(Maquina maquinaUno, Maquina maquinaDos)
        {
            bool iguales = false;
            if (maquinaUno is not null && maquinaDos is not null)
            {
                iguales = maquinaUno.Id == maquinaDos.Id && maquinaUno.IdComputadora == maquinaDos.IdComputadora &&
                    maquinaUno.DniCliente == maquinaDos.DniCliente;
            }
            return iguales;
        }

        public static bool operator !=(Maquina maquinaUno, Maquina maquinaDos)
        {
            return !(maquinaUno == maquinaDos);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Maquina)
            {
                Maquina maquina = (Maquina)obj;
                equals = maquina == this;
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return (id, idComputadora, tiempoReserva).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Maquina: ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"idComputadora={this.idComputadora}");
            sb.AppendFormat($"tiempoReserva={this.tiempoReserva}");
            return sb.ToString();
        }

        public override float CostoDeUso()
        {
            // Todo calcular costoDeUso del alquiler de una maquina
            if (tiempoReserva.Equals("Libre"))
            {
                this.pago = 0.50F;
            } else
            {
                this.pago = 0;
            }
            return this.pago;
        }
    }
}
