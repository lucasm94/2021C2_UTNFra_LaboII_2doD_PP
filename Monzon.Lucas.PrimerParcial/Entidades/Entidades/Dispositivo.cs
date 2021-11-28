using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Dispositivo
    {
        protected string id;
        protected bool enUso;
        protected int minutosDeUsoTotales;

        protected Dispositivo(string id)
        {
            this.id = id;
            this.enUso = false;
            this.minutosDeUsoTotales = 0;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public bool EnUso
        {
            get
            {
                return this.enUso;
            }
            set
            {
                this.enUso = value;
            }
        }

        public int MinutosDeUsoTotales
        {
            get
            {
                return this.minutosDeUsoTotales;
            }
            set
            {
                this.minutosDeUsoTotales = value;
            }
        }

        public static bool MismosAtributosDeServicio(Dispositivo servicioUno, Dispositivo servicioDos)
        {
            bool iguales = false;
            if (servicioUno is not null && servicioDos is not null)
            {
                iguales = servicioUno.Id == servicioDos.Id && servicioUno.EnUso == servicioDos.EnUso && 
                    servicioUno.MinutosDeUsoTotales == servicioDos.MinutosDeUsoTotales;
            }
            return iguales;
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos basicos de un dispositivo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"id= {this.id} - ");
            sb.AppendFormat($"enUso= {this.enUso} - ");
            sb.AppendFormat($"minutosDeUsoTotales= {this.minutosDeUsoTotales}\n");
            return sb.ToString();
        }
    }
}
