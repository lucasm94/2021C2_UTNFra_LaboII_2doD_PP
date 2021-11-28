using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Hardware
    {
        private Enum.Procesador procesador;
        private Enum.Ram ram;
        private Enum.PlacaDeVideo placaDeVideo;
        private Enum.DiscoDuro discoDuro;

        /// <summary>
        /// Constructor con parametros de Hardware
        /// </summary>
        /// <param name="procesador"></param>
        /// <param name="ram"></param>
        /// <param name="placaDeVideo"></param>
        /// <param name="discoDuro"></param>
        public Hardware(Enum.Procesador procesador, Enum.Ram ram, Enum.PlacaDeVideo placaDeVideo,
            Enum.DiscoDuro discoDuro)
        {
            this.procesador = procesador;
            this.ram = ram;
            this.placaDeVideo = placaDeVideo;
            this.discoDuro = discoDuro;
        }

        public Enum.Procesador Procesador
        {
            get
            {
                return this.procesador;
            }
            set
            {
                this.procesador = value;
            }
        }

        public Enum.Ram Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }

        public Enum.PlacaDeVideo PlacaDeVideo
        {
            get
            {
                return this.placaDeVideo;
            }
            set
            {
                this.placaDeVideo = value;
            }
        }

        public Enum.DiscoDuro DiscoDuro
        {
            get
            {
                return this.discoDuro;
            }
            set
            {
                this.discoDuro = value;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos hardwares son iguales.
        /// </summary>
        /// <param name="hardwareUno"></param>
        /// <param name="hardwareDos"></param>
        /// <returns></returns>
        public static bool operator ==(Hardware hardwareUno, Hardware hardwareDos)
        {
            bool iguales = false;
            if (hardwareUno is not null && hardwareDos is not null)
            {
                iguales = hardwareUno.Procesador == hardwareDos.Procesador && 
                    hardwareUno.Ram == hardwareDos.Ram && hardwareUno.PlacaDeVideo == hardwareDos.PlacaDeVideo 
                    && hardwareUno.DiscoDuro == hardwareDos.DiscoDuro;
            }
            return iguales;
        }

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos hardwares son distintas
        /// </summary>
        /// <param name="hardwareUno"></param>
        /// <param name="hardwareDos"></param>
        /// <returns></returns>
        public static bool operator !=(Hardware hardwareUno, Hardware hardwareDos)
        {
            return !(hardwareUno == hardwareDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para un hardware
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Hardware)
            {
                Hardware hardware = obj as Hardware;
                equals = this == hardware;
            }
            return equals;
        }

        /// <summary>
        /// Sobrecarga del método GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (procesador, ram, placaDeVideo, discoDuro).GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de Hardware
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hardware: ");
            sb.AppendFormat($"Procesador= {this.procesador} - ");
            sb.AppendFormat($"Ram= {this.ram} - ");
            sb.AppendFormat($"PlacaDeVideo= {this.placaDeVideo} - ");
            sb.AppendFormat($"DiscoDuro= {this.discoDuro}");
            return sb.ToString();
        }
    }
}
