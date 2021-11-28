using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class ClienteComputadora : Cliente
    {
        private Dictionary<string, List<string>> necesita;

        /// <summary>
        /// Constructor con parametros de un cliente para computadoras
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public ClienteComputadora(int dni, string nombre, string apellido, int edad) 
            : base(dni, nombre, apellido, edad)
        {
            this.necesita = new Dictionary<string, List<string>>();
        }

        public Dictionary<string, List<string>> Necesita
        {
            get
            {
                return this.necesita;
            }
            set
            {
                this.necesita = value;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos clienteComputadora son iguales.
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator ==(ClienteComputadora clienteUno, ClienteComputadora clienteDos)
        {
            bool iguales = false;
            if (clienteUno is not null && clienteDos is not null)
            {
                iguales = clienteUno.Dni == clienteDos.dni && clienteUno.Nombre == clienteDos.nombre &&
                    clienteUno.Apellido == clienteDos.apellido && clienteUno.Atendido == clienteDos.Atendido;
                if (iguales)
                {
                    for (int i = 0; i < clienteDos.Necesita.Keys.Count && iguales; i++)
                    {
                        if (!clienteUno.Necesita.Contains(clienteDos.Necesita.ElementAt(i)))
                        {
                            iguales = false;
                        }
                    }
                }
            }
            return iguales;
        }

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos clientesComptuadora son distintas
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator !=(ClienteComputadora clienteUno, ClienteComputadora clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para un clienteComputadora
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is ClienteComputadora)
            {
                ClienteComputadora cliente = (ClienteComputadora)obj;
                equals = cliente == this;
            }
            return equals;
        }

        /// <summary>
        /// Sobrecarga del método GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (dni, apellido, edad, necesita.Keys.Count).GetHashCode();
        }

        /// <summary>
        /// imprime que necesita un cliente compuradora
        /// </summary>
        /// <returns></returns>
        public string QueNecesita()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Necesita: ");
            foreach (string tipo in necesita.Keys)
            {
                List<string> values = necesita[tipo];
                foreach (string value in values)
                {
                    sb.AppendLine(value);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de clientecomputadora
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(QueNecesita());
            return sb.ToString();
        }
    }
}
