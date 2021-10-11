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

        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

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

        public override int GetHashCode()
        {
            return (dni, apellido, edad).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente: ");
            sb.AppendFormat($"dni={this.dni}");
            sb.AppendFormat($"nombre={this.nombre}");
            sb.AppendFormat($"apellido={this.apellido}");
            sb.AppendFormat($"edad={this.edad}");
            sb.AppendFormat($"atendido={this.atendido}");
            return sb.ToString();
        }

    }
}
