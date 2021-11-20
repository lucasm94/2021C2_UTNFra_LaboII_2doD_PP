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

        public static bool operator !=(Hardware hardwareUno, Hardware hardwareDos)
        {
            return !(hardwareUno == hardwareDos);
        }

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

        public override int GetHashCode()
        {
            return (procesador, ram, placaDeVideo, discoDuro).GetHashCode();
        }

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
