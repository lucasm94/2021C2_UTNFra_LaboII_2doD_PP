using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono : Dispositivo
    {
        private Enum.Tipo tipo;
        private Enum.Marca marca;

        public Telefono(string id, Enum.Tipo tipo, Enum.Marca marca) 
            : base(id)
        {
            this.tipo = tipo;
            this.marca = marca;
        }

        public Enum.Tipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public Enum.Marca Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public static bool operator ==(Telefono telefonoUno, Telefono telefonoDos)
        {
            bool iguales = false;
            if (telefonoUno is not null && telefonoDos is not null)
            {
                iguales = MismosAtributosDeServicio(telefonoUno, telefonoDos) && 
                    telefonoUno.Tipo == telefonoDos.Tipo && telefonoUno.Marca == telefonoDos.Marca;
            }
            return iguales;
        }

        public static bool operator !=(Telefono telefonoUno, Telefono telefonoDos)
        {
            return !(telefonoUno == telefonoDos);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj is Telefono)
            {
                Telefono telefono = obj as Telefono;
                equals = this == telefono;
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return (id, enUso, minutosDeUsoTotales, marca).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Telefono: ");
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"tipo={this.tipo}");
            sb.AppendFormat($"marca={this.marca}");
            return sb.ToString();
        }
    }
}
