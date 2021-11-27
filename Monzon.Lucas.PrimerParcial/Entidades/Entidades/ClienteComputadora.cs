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

        public static bool operator !=(ClienteComputadora clienteUno, ClienteComputadora clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

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

        public override int GetHashCode()
        {
            return (dni, apellido, edad, necesita.Keys.Count).GetHashCode();
        }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(QueNecesita());
            return sb.ToString();
        }
    }
}
