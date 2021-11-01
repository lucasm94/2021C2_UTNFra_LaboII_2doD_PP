using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public sealed class Llamada : Servicio
    {
        private string idTelefono;
        private string nroTelefonoDestino;
        private Enum.TipoLlamada tipoLlamada;

        public Llamada(string idTelefono, string nroTelefonoDestino, Enum.TipoLlamada tipoLlamada, 
            int dniCliente, DateTime inicio) : base(dniCliente, inicio)
        {
            this.idTelefono = idTelefono;
            this.nroTelefonoDestino = nroTelefonoDestino;
            this.tipoLlamada = tipoLlamada;
        }

        public string IdTelefono
        {
            get
            {
                return this.idTelefono;
            }
        }

        public string NroTelefonoDestino
        {
            get
            {
                return this.nroTelefonoDestino;
            }
            set
            {
                this.nroTelefonoDestino = value;
            }
        }

        public Enum.TipoLlamada TipoLlamada
        {
            get
            {
                return this.tipoLlamada;
            }
            set
            {
                this.tipoLlamada = value;
            }
        }

        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            bool iguales = false;
            if (llamadaUno is not null && llamadaDos is not null)
            {
                iguales = llamadaUno.Id == llamadaDos.Id && llamadaUno.IdTelefono == llamadaDos.IdTelefono && 
                    llamadaUno.DniCliente == llamadaDos.DniCliente && llamadaUno.TipoLlamada == llamadaDos.TipoLlamada;
            }
            return iguales;
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Llamada)
            {
                Llamada llamada = (Llamada)obj;
                equals = llamada == this;
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return (id, idTelefono, tipoLlamada).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada: ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"idTelefono={this.idTelefono}");
            sb.AppendFormat($"nroTelefonoDestino={this.nroTelefonoDestino}");
            sb.AppendFormat($"tipoLlamada={this.tipoLlamada}");
            return sb.ToString();
        }

        public override float CostoDeUso()
        {
            float segundosQueSonMinutos;
            switch (this.TipoLlamada)
            {
                case Enum.TipoLlamada.Local:
                    segundosQueSonMinutos = (float)(this.Fin - this.Inicio).TotalSeconds;
                    this.pago = (float)(segundosQueSonMinutos * 1.00);
                    break;
                case Enum.TipoLlamada.Larga_Distancia:
                    segundosQueSonMinutos = (float)(this.Fin - this.Inicio).TotalSeconds;
                    this.pago = (float)(segundosQueSonMinutos * 2.50);
                    break;
                case Enum.TipoLlamada.Internacional:
                    segundosQueSonMinutos = (float)(this.Fin - this.Inicio).TotalSeconds;
                    this.pago = (float)(segundosQueSonMinutos * 5.00);
                    break;
            }
            return this.pago;
        }
    }
}
