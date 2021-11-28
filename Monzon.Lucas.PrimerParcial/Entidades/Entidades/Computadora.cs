using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Computadora : Dispositivo
    {
        private List<Enum.Software> softwares;
        private List<Enum.Periferico> perifericos;
        private List<Enum.Juego> juegos;
        private Hardware hardware;

        /// <summary>
        /// Constructor con parametros de Computadora
        /// </summary>
        /// <param name="id"></param>
        /// <param name="softwares"></param>
        /// <param name="perifericos"></param>
        /// <param name="juegos"></param>
        /// <param name="hardware"></param>
        public Computadora(string id, List<Enum.Software> softwares, List<Enum.Periferico> perifericos,
            List<Enum.Juego> juegos, Hardware hardware) : base (id)
        {
            this.softwares = softwares;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.hardware = hardware;
        }

        public List<Enum.Software> Softwares
        {
            get
            {
                return this.softwares;
            }
            set
            {
                this.softwares = value;
            }
        }

        public List<Enum.Periferico> Perifericos
        {
            get
            {
                return this.perifericos;
            }
            set
            {
                this.perifericos = value;
            }
        }

        public List<Enum.Juego> Juegos
        {
            get
            {
                return this.juegos;
            }
            set
            {
                this.juegos = value;
            }
        }

        public Hardware Hardware
        {
            get
            {
                return this.hardware;
            }
            set
            {
                this.hardware = value;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos computadoras son iguales.
        /// </summary>
        /// <param name="pcUno"></param>
        /// <param name="pcDos"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora pcUno, Computadora pcDos)
        {
            bool iguales = false;
            if (pcUno is not null && pcDos is not null)
            {
                iguales = MismosAtributosDeServicio(pcUno, pcDos);
                if (iguales && pcUno.Hardware.Equals(pcDos.Hardware))
                {
                    for (int i = 0; i < pcDos.Softwares.Count && iguales; i++)
                    {
                        if (!pcUno.softwares.Contains(pcDos.Softwares[i]))
                        {
                            iguales = false;
                        }
                    }

                    for (int i = 0; i < pcDos.Perifericos.Count && iguales; i++)
                    {
                        if (!pcUno.perifericos.Contains(pcDos.Perifericos[i]))
                        {
                            iguales = false;
                        }
                    }

                    for (int i = 0; i < pcDos.Juegos.Count && iguales; i++)
                    {
                        if (!pcUno.juegos.Contains(pcDos.Juegos[i]))
                        {
                            iguales = false;
                        }
                    }
                }
            }
            return iguales;
        }

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos computadoras son distintas
        /// </summary>
        /// <param name="pcUno"></param>
        /// <param name="pcDos"></param>
        /// <returns></returns>
        public static bool operator !=(Computadora pcUno, Computadora pcDos)
        {
            return !(pcUno == pcDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para una Computadora
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Computadora)
            {
                Computadora computadora = (Computadora)obj;
                equals = computadora == this;
            }
            return equals;
        }

        /// <summary>
        /// Sobrecarga del método GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (id, enUso, minutosDeUsoTotales, hardware.Procesador).GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de la Computadora
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Computadora: ");
            sb.AppendFormat(base.ToString());
            sb.AppendLine("Softwares: ");
            foreach (Enum.Software software in this.softwares)
            {
                sb.AppendFormat($"{software.ToString()} - ");
            }
            sb.AppendLine("\nPerifericos: ");
            foreach (Enum.Periferico periferico in this.perifericos)
            {
                sb.AppendFormat($"{periferico.ToString()} - ");
            }
            sb.AppendLine("\nJuegos: ");
            foreach (Enum.Juego juego in this.juegos)
            {
                sb.AppendFormat($"{juego.ToString()} - ");
            }
            sb.AppendFormat(this.hardware.ToString());
            return sb.ToString();
        }
    }
}
