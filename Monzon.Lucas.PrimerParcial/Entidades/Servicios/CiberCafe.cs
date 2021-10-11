using Biblioteca.Entidades;
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

        public List<Computadora> Computadoras
        {
            get
            {
                return this.computadoras;
            }
        }

        public List<Telefono> Telefonos
        {
            get
            {
                return this.telefonos;
            }
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
            ActualizarEstadoDispositivo(idTelefono, true, 0, 0);
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
            ActualizarEstadoDispositivo(idComputadora, true, 0, 0);
            Maquinas.Add(maquina);
        }

        private void ActualizarEstadoDispositivo(string idDispositivo, bool enUso, float pago, int minutos)
        {
            int i = 0;
            if (idDispositivo.ElementAt(0) == 'T')
            {
                while (i < Telefonos.Count && Telefonos[i].Id != idDispositivo) { }
                {
                    i++;
                }
                Telefonos[i].EnUso = enUso;
                if (pago > 0)
                {
                    Telefonos[i].Ganancias += pago;
                }
                if (minutos > 0)
                {
                    Telefonos[i].MinutosDeUsoTotales += minutos;
                }
            } else
            {
                while (i < Computadoras.Count && Telefonos[i].Id != idDispositivo) { }
                {
                    i++;
                }
                Computadoras[i].EnUso = enUso;
                if (pago > 0)
                {
                    Computadoras[i].Ganancias += pago;
                }
                if (minutos > 0)
                {
                    Computadoras[i].MinutosDeUsoTotales += minutos;
                }
            }
        }

        public float FinalizarUso(string idServicio, string idDispositivo)
        {
            Servicio servicio = ObtenerServicioPorIdDispositivo(idServicio, idDispositivo);
            servicio.Fin = new DateTime();
            float pago = servicio.CostoDeUso();
            int minutosUso = (int)(servicio.Fin - servicio.Inicio).TotalMinutes;
            ActualizarEstadoDispositivo(idDispositivo, false, pago, minutosUso);
            return pago;
        }

        private Servicio ObtenerServicioPorIdDispositivo(string idServicio, string idDispositivo)
        {
            if (idDispositivo.ElementAt(0) == 'T')
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

        public void CopiarJuegoACd(Enum.Juego juego, int cantidad)
        {
            int ganancia = (int)(cantidad * 1.25);
            if (copiaJuegos.ContainsKey(juego))
            {
                copiaJuegos[juego].Cantidad += cantidad;
                copiaJuegos[juego].Ganancia += ganancia;
            } else
            {
                copiaJuegos.Add(juego, new Copia(cantidad, ganancia));
            }
        }
        
        // Todo implementar ganancias totales por copias
        public int ObtenerGananciasPorCopias()
        {
            return 0;
        }

        public int ObtenerGananciasDeCopiasPorJuego(Enum.Juego juego)
        {
            return 0;
        }

    }
}
