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

        /// <summary>
        /// Constructor con parametros de una Maquina
        /// </summary>
        /// <param name="idComputadora"></param>
        /// <param name="tiempoReserva"></param>
        /// <param name="dniCliente"></param>
        /// <param name="inicio"></param>
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

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos Maquinas son iguales.
        /// </summary>
        /// <param name="maquinaUno"></param>
        /// <param name="maquinaDos"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos maquinas son distintas
        /// </summary>
        /// <param name="maquinaUno"></param>
        /// <param name="maquinaDos"></param>
        /// <returns></returns>
        public static bool operator !=(Maquina maquinaUno, Maquina maquinaDos)
        {
            return !(maquinaUno == maquinaDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para una Maquina
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del método GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (id, idComputadora, tiempoReserva).GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de la Maquina
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Maquina: ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"idComputadora={this.idComputadora}");
            sb.AppendFormat($"tiempoReserva={this.tiempoReserva}");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del método CostoDeUso. calcula el costo de una maquina
        /// </summary>
        /// <returns></returns>
        public override float CostoDeUso()
        {
            double minutosDeUso = (this.Fin - this.Inicio).TotalSeconds;
            double fraccionMinutoUpp= Math.Ceiling((minutosDeUso / 30));
            if (minutosDeUso < 30)
            {
                this.pago = 0.50F;
            }
            else if (minutosDeUso > 30 && minutosDeUso < 60)
            {
                this.pago = 0.50F * 2;
            } else
            {
                this.pago = (float)(0.50 * fraccionMinutoUpp);
            }
            return this.pago;
        }
    }
}
