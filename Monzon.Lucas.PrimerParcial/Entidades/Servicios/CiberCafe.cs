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
        private List<Cliente> clientesUsandoServicio;
        private List<Cliente> clientesEnEspera;
        private List<Llamada> llamadas;
        private List<Maquina> maquinas;
        private Dictionary<Enum.Software, int> softwaresPedidos;
        private Dictionary<Enum.Periferico, int> perifericosPedidos;
        private Dictionary<Enum.Juego, int> juegosPedidos;
        private Dictionary<Enum.Juego, Copia> copiaJuegos;
        private float gananciasPorCopias;

        public CiberCafe()
        {
            this.computadoras = Mocks.Computadoras();
            this.telefonos = Mocks.Telefonos();
            this.clientesAtendidos = new List<Cliente>();
            this.clientesUsandoServicio = new List<Cliente>();
            this.clientesEnEspera = Mocks.ClientesEnEspera();
            this.llamadas = new List<Llamada>();
            this.maquinas = new List<Maquina>();
            this.softwaresPedidos = InicializarSoftwaresPedidos();
            this.perifericosPedidos = InicializarPerifericosPedidos();
            this.juegosPedidos = InicializarJuegosPedidos();
            this.copiaJuegos = new Dictionary<Enum.Juego, Copia>();
            this.gananciasPorCopias = 0;
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
            List<Computadora> computadorasList = new List<Computadora>();
            switch (busqueda)
            {
                case Constantes.EN_USO:
                    foreach (Computadora computadora in this.computadoras)
                    {
                        if (computadora.EnUso)
                        {
                            computadorasList.Add(computadora);
                        }
                    }
                    break;
                case Constantes.LIBRES:
                    foreach (Computadora computadora in this.computadoras)
                    {
                        if (!computadora.EnUso)
                        {
                            computadorasList.Add(computadora);
                        }
                    }
                    break;
                default:
                    computadorasList = this.computadoras;
                    break;
            }
            return computadorasList;
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

        public List<Cliente> ClientesUsandoServicio
        {
            get
            {
                return this.clientesUsandoServicio;
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

        public Computadora GetComputadoraPorId(string id)
        {
            int i = 0;
            while (i < this.computadoras.Count && 
                this.computadoras.ElementAt(i).Id != id)
            {
                i++;
            }
            return this.computadoras.ElementAt(i);
        }

        public Dictionary<Enum.Juego, Copia> CopiasJuegos
        {
            get
            {
                return this.CopiasJuegos;
            }
        }

        public void Asignar(int dniCliente, string idTelefono, string nroTelefono)
        {
            Enum.TipoLlamada tipo = ObtenerTipoLlamada(nroTelefono);
            Llamada llamada = new Llamada(idTelefono, nroTelefono, tipo, dniCliente, DateTime.Now);
            ClienteEnEsperaACLienteAtendido(dniCliente);
            ActualizarEstadoDispositivo(idTelefono, true, 0);
            Llamadas.Add(llamada);
        }

        public void Asignar(int dniCliente, string idComputadora, Enum.TiempoReserva tiempoReserva)
        {
            Maquina maquina = new Maquina(idComputadora, tiempoReserva, dniCliente, DateTime.Now);
            ClienteEnEsperaACLienteAtendido(dniCliente);
            ActualizarEstadoDispositivo(idComputadora, true, 0);
            Maquinas.Add(maquina);
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
            ClientesUsandoServicio.Add(cliente);
        }

        private void ClienteUsandoServicioACLienteAtendido(int dniCliente)
        {
            int i = 0;
            while (i < ClientesUsandoServicio.Count && ClientesUsandoServicio[i].Dni != dniCliente)
            {
                i++;
            }
            Cliente cliente = ClientesUsandoServicio[i];
            ClientesUsandoServicio.RemoveAt(i);
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

        private void ActualizarEstadoDispositivo(string idDispositivo, bool enUso, int minutos)
        {
            int i = 0;
            if (idDispositivo.ElementAt(0) == 'T')
            {
                while (i < this.telefonos.Count && this.telefonos[i].Id != idDispositivo)
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
                while (i < this.computadoras.Count && this.computadoras[i].Id != idDispositivo)
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

        public ServicioFinalizadoInfo FinalizarUso(int dniCliente, string tipoServicio)
        {
            Servicio servicio = ObtenerServicioSinFinalizar(dniCliente, tipoServicio);
            servicio.Fin = DateTime.Now;
            float monto = servicio.CostoDeUso();
            int minutosUso = (int)(servicio.Fin - servicio.Inicio).TotalSeconds;
            string idDispositivo = servicio is Llamada ? ((Llamada)servicio).IdTelefono : ((Maquina)servicio).IdComputadora;
            ActualizarEstadoDispositivo(idDispositivo, false, minutosUso);
            ClienteUsandoServicioACLienteAtendido(dniCliente);
            float iva = (float)Math.Round((monto * 0.21), 2);
            return new ServicioFinalizadoInfo(minutosUso, monto, iva, (float)Math.Round(monto+iva, 2));
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

        public int HorasTotalesPorTipoLlamada(string tipo)
        {
            int horasTotales = 0;
            switch (tipo)
            {
                case Constantes.LOCAL:
                    horasTotales = HorasPorTipoDeLLamada(Enum.TipoLlamada.Local);
                    break;
                case Constantes.LARGA_DISTANCIA:
                    horasTotales = HorasPorTipoDeLLamada(Enum.TipoLlamada.Larga_Distancia);
                    break;
                case Constantes.INTERNACIONAL:
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

        public float RecaudacionTotalPorTipoLlamada(string tipo)
        {
            float recaudacionTotal = 0f;
            switch (tipo)
            {
                case Constantes.LOCAL:
                    recaudacionTotal = RecaudacionPorTipoDeLLamada(Enum.TipoLlamada.Local);
                    break;
                case Constantes.LARGA_DISTANCIA:
                    recaudacionTotal = RecaudacionPorTipoDeLLamada(Enum.TipoLlamada.Larga_Distancia);
                    break;
                case Constantes.INTERNACIONAL:
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
            int maxPedido = this.softwaresPedidos.Values.Max();
            if (maxPedido > 0)
            {
                return this.softwaresPedidos
                    .FirstOrDefault(keyValue => keyValue.Value.Equals(maxPedido))
                    .Key.ToString();
            }
            return "";
        }

        public string PerifericoMasPedidos()
        {
            int maxPedido = this.perifericosPedidos.Values.Max();
            if (maxPedido > 0)
            {
                return this.perifericosPedidos
                    .FirstOrDefault(keyValue => keyValue.Value.Equals(maxPedido))
                    .Key.ToString();
            }
            return "";
        }

        public string JuegoMasPedidos()
        {
            int maxPedido = this.juegosPedidos.Values.Max();
            if (maxPedido > 0)
            {
                return this.juegosPedidos
                    .FirstOrDefault(keyValue => keyValue.Value.Equals(maxPedido))
                    .Key.ToString();
            }
            return "";
        }

        public void CopiarJuegoACd(Enum.Juego juego, int cantidad)
        {
            float ganancia = (float)(cantidad * 1.25);
            if (copiaJuegos.ContainsKey(juego))
            {
                copiaJuegos[juego].Cantidad += cantidad;
                copiaJuegos[juego].Ganancia += ganancia;
            }
            else
            {
                copiaJuegos.Add(juego, new Copia(cantidad, ganancia));
            }
            this.gananciasPorCopias += ganancia;
        }

        public float ObtenerGananciasPorCopiasRealizadas()
        {
            return this.gananciasPorCopias;
        }

        public Copia ObtenerInfoDeCopiaDeUnJuego(Enum.Juego juego)
        {
            if (this.copiaJuegos.Count > 0 && this.copiaJuegos[juego] != null)
            {
                return this.copiaJuegos[juego];
            }
            return new Copia();
        }

        public string ServicioQueNecesita(Cliente cliente)
        {
            return cliente is ClienteComputadora ? Constantes.COMPUTADORA : Constantes.CABINA;
        }

        public Servicio ObtenerServicioSinFinalizar(int dniCliente, string tipoServicio)
        {
            Servicio servicio = null;
            if (tipoServicio.Equals(Constantes.COMPUTADORA))
            {
                foreach (Servicio item in this.maquinas)
                {
                    if (item.DniCliente == dniCliente && item.Recaudacion == 0)
                    {
                        servicio = item;
                        break;
                    }
                }
            } else
            {
                foreach (Servicio item in this.llamadas)
                {
                    if (item.DniCliente == dniCliente && item.Recaudacion == 0)
                    {
                        servicio = item;
                        break;
                    }
                }
            }
            return servicio;
        }

        public void ActualizarMasPedidos(Dictionary<string, List<string>> necesita)
        {
            foreach (string key in necesita.Keys)
            {
                switch (key)
                {
                    case Constantes.SOFTWARE:
                        foreach (string software in necesita[key])
                        {
                            Enum.Software softwareKey = 
                                (Enum.Software)System.Enum.Parse(typeof(Enum.Software), software);
                            if (this.softwaresPedidos.ContainsKey(softwareKey))
                            {
                                this.softwaresPedidos[softwareKey] += 1;
                            }
                        }
                        break;
                    case Constantes.JUEGOS:
                        foreach (string juego in necesita[key])
                        {
                            Enum.Juego juegoKey = 
                                (Enum.Juego)System.Enum.Parse(typeof(Enum.Juego), juego);
                            if (this.juegosPedidos.ContainsKey(juegoKey))
                            {
                                this.juegosPedidos[juegoKey] += 1;
                            }
                        }
                        break;
                    case Constantes.PERIFERICOS:
                        foreach (string periferico in necesita[key])
                        {
                            Enum.Periferico perifericoKey = 
                                (Enum.Periferico)System.Enum.Parse(typeof(Enum.Periferico), periferico);
                            if (this.perifericosPedidos.ContainsKey(perifericoKey))
                            {
                                this.perifericosPedidos[perifericoKey] += 1;
                            }
                        }
                        break;
                }
            }
        }
    }
}
