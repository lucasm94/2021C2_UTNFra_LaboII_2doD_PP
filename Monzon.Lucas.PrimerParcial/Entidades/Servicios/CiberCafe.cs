using Biblioteca.Entidades;
using Biblioteca.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CiberCafe
    {
        private List<Computadora> computadoras;
        private List<Telefono> telefonos;
        private List<Cliente> clientesAtendidos;
        private List<Cliente> clientesEnEspera;
        private List<Llamada> llamadas;
        private List<Maquina> maquinas;
        private Dictionary<Enum.Software, int> softwaresPedidos;
        private Dictionary<Enum.Periferico, int> perifericosPedidos;
        private Dictionary<Enum.Juego, int> juegosPedidos;
        private Dictionary<Enum.Juego, Copia> copiaJuegos;

        public CiberCafe()
        {
            this.computadoras = Mocks.Computadoras();
            this.telefonos = Mocks.Telefonos();
            this.clientesAtendidos = new List<Cliente>();
            this.clientesEnEspera = Mocks.ClientesEnEspera();
            this.llamadas = new List<Llamada>();
            this.maquinas = new List<Maquina>();
            this.softwaresPedidos = InicializarSoftwaresPedidos();
            this.perifericosPedidos = InicializarPerifericosPedidos();
            this.juegosPedidos = InicializarJuegosPedidos();
            this.copiaJuegos = new Dictionary<Enum.Juego, Copia>();
        }

        private Dictionary<Enum.Juego, int> InicializarJuegosPedidos()
        {
            Dictionary<Enum.Juego, int> juegosPedidos = new Dictionary<Enum.Juego, int>();
            juegosPedidos.Add(Enum.Juego.Age_II, 0);
            juegosPedidos.Add(Enum.Juego.Counter_Strike, 0);
            juegosPedidos.Add(Enum.Juego.Diablo_II, 0);
            juegosPedidos.Add(Enum.Juego.Mu_Online, 0);
            juegosPedidos.Add(Enum.Juego.LineAge_II, 0);
            juegosPedidos.Add(Enum.Juego.warcraft_III, 0);
            return juegosPedidos;
        }

        private Dictionary<Enum.Periferico, int> InicializarPerifericosPedidos()
        {
            Dictionary<Enum.Periferico, int> perifericosPedidos = new Dictionary<Enum.Periferico, int>();
            perifericosPedidos.Add(Enum.Periferico.Auriculares, 0);
            perifericosPedidos.Add(Enum.Periferico.Camara, 0);
            perifericosPedidos.Add(Enum.Periferico.Microfono, 0);
            perifericosPedidos.Add(Enum.Periferico.Mouse, 0);
            return perifericosPedidos;
        }

        private Dictionary<Enum.Software, int> InicializarSoftwaresPedidos()
        {
            Dictionary<Enum.Software, int> softwaresPedidos = new Dictionary<Enum.Software, int>();
            softwaresPedidos.Add(Enum.Software.Ares, 0);
            softwaresPedidos.Add(Enum.Software.Icq, 0);
            softwaresPedidos.Add(Enum.Software.Messenger, 0);
            softwaresPedidos.Add(Enum.Software.Office, 0);
            return softwaresPedidos;
        }

        public List<Computadora> Computadoras(string busqueda)
        {
            List<Computadora> computadoras = new List<Computadora>();
            switch (busqueda)
            {
                case Constantes.EN_USO:
                    foreach (Computadora computadora in this.computadoras)
                    {
                        if (computadora.EnUso)
                        {
                            computadoras.Add(computadora);
                        }
                    }
                    break;
                case Constantes.LIBRES:
                    foreach (Computadora computadora in this.computadoras)
                    {
                        if (!computadora.EnUso)
                        {
                            computadoras.Add(computadora);
                        }
                    }
                    break;
                default:
                    computadoras = this.computadoras;
                    break;
            }
            return computadoras;
        } 

        public List<Telefono> Telefonos(string busqueda)
        {
            List<Telefono> telefonos = new List<Telefono>();
            switch (busqueda)
            {
                case Constantes.EN_USO:
                    foreach (Telefono telefono in this.telefonos)
                    {
                        if (telefono.EnUso)
                        {
                            telefonos.Add(telefono);
                        }
                    }
                    break;
                case Constantes.LIBRES:
                    foreach (Telefono telefono in this.telefonos)
                    {
                        if (!telefono.EnUso)
                        {
                            telefonos.Add(telefono);
                        }
                    }
                    break;
                default:
                    telefonos = this.telefonos;
                    break;
            }
            return telefonos;
        }

        public List<Cliente> ClientesAtendidos
        {
            get
            {
                return this.clientesAtendidos;
            }
        }

        public List<Cliente> ClientesEnEspera
        {
            get
            {
                return this.clientesEnEspera;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.llamadas;
            }
        }

        public List<Maquina> Maquinas
        {
            get
            {
                return this.maquinas;
            }
        }

        public Dictionary<Enum.Juego, Copia> CopiasJuegos
        {
            get
            {
                return this.CopiasJuegos;
            }
        }

        public void AsignarCabina(int dniCliente, string idTelefono, string nroTelefono)
        {
            Enum.TipoLlamada tipo = ObtenerTipoLlamada(nroTelefono);
            Llamada llamada = new Llamada(idTelefono, nroTelefono, tipo, dniCliente, new DateTime());
            ClienteEnEsperaACLienteAtendido(dniCliente);
            ActualizarEstadoDispositivo(idTelefono, true, 0);
            Llamadas.Add(llamada);
        }

        private int ObtenerIndiceClienteEnEspera(int dniCliente)
        {
            int i = 0;
            while (i < ClientesEnEspera.Count && ClientesEnEspera[i].Dni != dniCliente)
            {
                i++;
            }
            return i;
        }

        private void ClienteEnEsperaACLienteAtendido(int dniCliente)
        {
            int index = ObtenerIndiceClienteEnEspera(dniCliente);
            Cliente cliente = ClientesEnEspera[index];
            cliente.Atendido = true;
            ClientesEnEspera.RemoveAt(index);
            ClientesAtendidos.Add(cliente);
        }

        private Enum.TipoLlamada ObtenerTipoLlamada(string numero)
        {
            Enum.TipoLlamada tipo;
            string[] codigos = numero.Split('-');
            if (codigos[0] != "54")
            {
                tipo = Enum.TipoLlamada.Internacional;
            }
            else if (codigos[1] != "11" || codigos[1] != "011")
            {
                tipo = Enum.TipoLlamada.Larga_Distancia;
            } else
            {
                tipo = Enum.TipoLlamada.Local;
            }
            return tipo;
        }

        public void AsignarMaquina(int dniCliente, string idComputadora, string tiempoReserva)
        {
            Maquina maquina = new Maquina(idComputadora, tiempoReserva, dniCliente, new DateTime());
            ClienteEnEsperaACLienteAtendido(dniCliente);
            ActualizarEstadoDispositivo(idComputadora, true, 0);
            Maquinas.Add(maquina);
        }

        private void ActualizarEstadoDispositivo(string idDispositivo, bool enUso, int minutos)
        {
            int i = 0;
            if (idDispositivo.ElementAt(0) == 'T')
            {
                while (i < this.telefonos.Count && this.telefonos[i].Id != idDispositivo) { }
                {
                    i++;
                }
                this.telefonos[i].EnUso = enUso;
                if (minutos > 0)
                {
                    this.telefonos[i].MinutosDeUsoTotales += minutos;
                }
            } else
            {
                while (i < this.computadoras.Count && this.telefonos[i].Id != idDispositivo) { }
                {
                    i++;
                }
                this.computadoras[i].EnUso = enUso;
                if (minutos > 0)
                {
                    this.computadoras[i].MinutosDeUsoTotales += minutos;
                }
            }
        }

        public float FinalizarUso(string idServicio, string idDispositivo)
        {
            Servicio servicio = ObtenerServicioPorIdDispositivo(idServicio, idDispositivo);
            servicio.Fin = new DateTime();
            float pago = servicio.CostoDeUso();
            int minutosUso = (int)(servicio.Fin - servicio.Inicio).TotalMinutes;
            ActualizarEstadoDispositivo(idDispositivo, false, minutosUso);
            return pago;
        }

        private Servicio ObtenerServicioPorIdDispositivo(string idServicio, string idDispositivo)
        {
            if (idDispositivo.ElementAt(0) == Constantes.PRIMER_CARACTER_ID_TELEFONO)
            {
                int i = 0;
                while(i < Llamadas.Count && idServicio != Llamadas[i].Id)
                {
                    i++;
                }
                return Llamadas[i];
            }
            else
            {
                int i = 0;
                while (i < Maquinas.Count && idServicio != Maquinas[i].Id)
                {
                    i++;
                }
                return Maquinas[i];
            }
        }

        public List<Computadora> ComputadorasOrdenadasMinDeUsoDesc()
        {
            return this.computadoras.OrderByDescending(c => c.MinutosDeUsoTotales).ToList();
        }

        public List<Telefono> TelefonosOrdenadosMinDeUsoDesc()
        {
            return this.telefonos.OrderByDescending(c => c.MinutosDeUsoTotales).ToList();
        }

        public float GananciasTotalesPorServicio(string servicio)
        {
            float ganancias = 0f;
            if (servicio.Equals(Constantes.CABINA))
            {
                foreach (Llamada llamada in this.llamadas)
                {
                    ganancias += llamada.Recaudacion;
                }
            } else
            {
                foreach (Maquina maquina in this.maquinas)
                {
                    ganancias += maquina.Recaudacion;
                }
            }
            return ganancias;
        }

        public int HorasTotalesPorTipoLlamada(Enum.TipoLlamada tipo)
        {
            int horasTotales = 0;
            switch (tipo)
            {
                case Enum.TipoLlamada.Local:
                    horasTotales = HorasPorTipoDeLLamada(Enum.TipoLlamada.Local);
                    break;
                case Enum.TipoLlamada.Larga_Distancia:
                    horasTotales = HorasPorTipoDeLLamada(Enum.TipoLlamada.Larga_Distancia);
                    break;
                case Enum.TipoLlamada.Internacional:
                    horasTotales = HorasPorTipoDeLLamada(Enum.TipoLlamada.Internacional);
                    break;
            }
            return horasTotales;
        }

        private int HorasPorTipoDeLLamada(Enum.TipoLlamada tipo)
        {
            int horasTotales = 0;
            foreach (Llamada llamada in this.llamadas)
            {
                if (llamada.TipoLlamada.Equals(tipo))
                {
                    int horas = (int)(llamada.Fin - llamada.Inicio).TotalHours;
                    horasTotales += horas;
                }
            }
            return horasTotales;
        }

        public float RecaudacionTotalPorTipoLlamada(Enum.TipoLlamada tipo)
        {
            float recaudacionTotal = 0f;
            switch (tipo)
            {
                case Enum.TipoLlamada.Local:
                    recaudacionTotal = RecaudacionPorTipoDeLLamada(Enum.TipoLlamada.Local);
                    break;
                case Enum.TipoLlamada.Larga_Distancia:
                    recaudacionTotal = RecaudacionPorTipoDeLLamada(Enum.TipoLlamada.Larga_Distancia);
                    break;
                case Enum.TipoLlamada.Internacional:
                    recaudacionTotal = RecaudacionPorTipoDeLLamada(Enum.TipoLlamada.Internacional);
                    break;
            }
            return recaudacionTotal;
        }

        private float RecaudacionPorTipoDeLLamada(Enum.TipoLlamada tipo)
        {
            float reacudacionTotal = 0;
            foreach (Llamada llamada in this.llamadas)
            {
                if (llamada.TipoLlamada.Equals(tipo))
                {
                    reacudacionTotal += llamada.Recaudacion;
                }
            }
            return reacudacionTotal;
        }

        public string SoftwareMasPedidos()
        {
            return this.softwaresPedidos.Max().Key.ToString();
        }

        public string PerifericoMasPedidos()
        {
            return this.perifericosPedidos.Max().Key.ToString();
        }

        public string JuegoMasPedidos()
        {
            return this.juegosPedidos.Max().Key.ToString();
        }

        public void CopiarJuegoACd(Enum.Juego juego, int cantidad)
        {
            int ganancia = (int)(cantidad * 1.25);
            if (copiaJuegos.ContainsKey(juego))
            {
                copiaJuegos[juego].Cantidad += cantidad;
                copiaJuegos[juego].Ganancia += ganancia;
            }
            else
            {
                copiaJuegos.Add(juego, new Copia(cantidad, ganancia));
            }
        }

        public float ObtenerGananciasPorCopiasRealizadas()
        {
            float ganancias = 0f;
            foreach (KeyValuePair<Enum.Juego, Copia> item in this.copiaJuegos)
            {
                ganancias += item.Value.Ganancia;
            }
            return ganancias;
        }

        public Copia ObtenerInfoDeCopiaDeUnJuego(Enum.Juego juego)
        {
            if (this.copiaJuegos[juego] != null)
            {
                return this.copiaJuegos[juego];
            }
            return new Copia(0, 0);
        }

    }
}
