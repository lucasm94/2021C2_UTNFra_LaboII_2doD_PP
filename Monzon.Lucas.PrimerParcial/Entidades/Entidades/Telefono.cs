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

        /// <summary>
        /// Constructor con parametros de Telefono
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
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

        /// <summary>
        /// Sobrecarga del metodo == en donde indicara si dos telefonos son iguales.
        /// </summary>
        /// <param name="telefonoUno"></param>
        /// <param name="telefonoDos"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del metodo != en donde indicara si dos telefonos son distintos
        /// </summary>
        /// <param name="telefonoUno"></param>
        /// <param name="telefonoDos"></param>
        /// <returns></returns>
        public static bool operator !=(Telefono telefonoUno, Telefono telefonoDos)
        {
            return !(telefonoUno == telefonoDos);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para un telefono
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del método GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (id, enUso, minutosDeUsoTotales, marca).GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del método ToString. Imprime los datos de un telefono
        /// </summary>
        /// <returns></returns>
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
