using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool atendido;

        /// <summary>
        /// Constructor con parametros de un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Cliente(int dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.atendido = false;
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool Atendido
        {
            get
            {
                return this.atendido;
            }
            set
            {
                this.atendido = value;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos clientes son iguales.
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            bool iguales = false;
            if (clienteUno is not null && clienteDos is not null)
            {
                iguales = clienteUno.Dni == clienteDos.dni && clienteUno.Nombre == clienteDos.nombre &&
                    clienteUno.Apellido == clienteDos.apellido && clienteUno.Atendido == clienteDos.Atendido;
            }
            return iguales;
        }

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos clientes son distintos
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para una Cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Cliente)
            {
                Cliente cliente = (Cliente)obj;
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
            return (dni, apellido, edad).GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de un cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente: ");
            sb.AppendFormat($"dni={this.dni}\n");
            sb.AppendFormat($"nombre={this.nombre}\n");
            sb.AppendFormat($"apellido={this.apellido}\n");
            sb.AppendFormat($"edad={this.edad}\n");
            sb.AppendFormat($"atendido={this.atendido}\n");
            return sb.ToString();
        }

    }
}
