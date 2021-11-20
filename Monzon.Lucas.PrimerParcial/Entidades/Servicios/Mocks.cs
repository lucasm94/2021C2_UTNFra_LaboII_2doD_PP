using Biblioteca.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Mocks
    {
        public static List<Cliente> ClientesEnEspera()
        {
            List<Cliente> clientes = new List<Cliente>();
            ClienteComputadora clientePc = new ClienteComputadora(12341111, "Septimo", "Espera", 20);
            ClienteComputadora clientePcDos = new ClienteComputadora(12343124, "Octavo", "Espera", 11);
            ClienteComputadora clientePcTres = new ClienteComputadora(12341234, "Quinto", "Espera", 13);
            ClienteComputadora clientePcCuatro = new ClienteComputadora(12344321, "Sexto", "Espera", 16);

            Dictionary<string, List<string>> diccClientePc =new Dictionary<string, List<string>>();
            diccClientePc.Add(Constantes.PERIFERICOS, new List<string>() { Enum.Periferico.Mouse.ToString() });

            clientePc.Necesita = diccClientePc;

            clientes.Add(clientePc);
            clientes.Add(new Cliente(12345678, "Primero", "Espera", 14));
            clientes.Add(new Cliente(12345677, "Segundo", "Espera", 15));
            clientes.Add(new Cliente(12345675, "Tercero", "Espera", 19));
            clientes.Add(new Cliente(12348765, "Cuarto", "Espera", 12));
            
            clientes.Add(clientePcDos);
            clientes.Add(clientePcTres);
            clientes.Add(clientePcCuatro);
            return clientes;
        }

        public static List<Telefono> Telefonos()
        {
            List<Telefono> telefonos = new List<Telefono>();
            telefonos.Add(new Telefono("T01", Enum.Tipo.A_Disco, Enum.Marca.Alcatel));
            telefonos.Add(new Telefono("T02", Enum.Tipo.A_Disco, Enum.Marca.Alcatel));
            telefonos.Add(new Telefono("T03", Enum.Tipo.A_Disco, Enum.Marca.Elgin));
            telefonos.Add(new Telefono("T04", Enum.Tipo.Con_Teclado, Enum.Marca.Siemens));
            telefonos.Add(new Telefono("T05", Enum.Tipo.Con_Teclado, Enum.Marca.Siemens));
            return telefonos;
        }

        public static List<Computadora> Computadoras()
        {
            List<Enum.Software> softwaresUno = new List<Enum.Software>();
            softwaresUno.Add(Enum.Software.Ares);
            softwaresUno.Add(Enum.Software.Icq);
            List<Enum.Periferico> perifericosUno = new List<Enum.Periferico>();
            perifericosUno.Add(Enum.Periferico.Auriculares);
            perifericosUno.Add(Enum.Periferico.Mouse);
            perifericosUno.Add(Enum.Periferico.Microfono);
            List<Enum.Juego> juegosUno = new List<Enum.Juego>();
            juegosUno.Add(Enum.Juego.Age_II);
            juegosUno.Add(Enum.Juego.warcraft_III);
            Hardware hardwareUno = new Hardware(Enum.Procesador.AMD_Athon, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_MX_100, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresDos = new List<Enum.Software>();
            softwaresDos.Add(Enum.Software.Icq);
            softwaresDos.Add(Enum.Software.Ares);
            softwaresDos.Add(Enum.Software.Office);
            List<Enum.Periferico> perifericosDos = new List<Enum.Periferico>();
            perifericosDos.Add(Enum.Periferico.Auriculares);
            perifericosDos.Add(Enum.Periferico.Mouse);
            perifericosDos.Add(Enum.Periferico.Microfono);
            List<Enum.Juego> juegosDos = new List<Enum.Juego>();
            juegosDos.Add(Enum.Juego.Age_II);
            juegosDos.Add(Enum.Juego.Counter_Strike);
            Hardware hardwareDos = new Hardware(Enum.Procesador.Pentium_4, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_MX_100, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresTres = new List<Enum.Software>();
            softwaresTres.Add(Enum.Software.Ares);
            softwaresTres.Add(Enum.Software.Office);
            List<Enum.Periferico> perifericosTres = new List<Enum.Periferico>();
            perifericosTres.Add(Enum.Periferico.Auriculares);
            perifericosTres.Add(Enum.Periferico.Mouse);
            List<Enum.Juego> juegosTres = new List<Enum.Juego>();
            juegosTres.Add(Enum.Juego.Age_II);
            juegosTres.Add(Enum.Juego.Counter_Strike);
            Hardware hardwareTres = new Hardware(Enum.Procesador.AMD_Athon, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_Ti, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresCuatro = new List<Enum.Software>();
            softwaresCuatro.Add(Enum.Software.Icq);
            softwaresCuatro.Add(Enum.Software.Office);
            List<Enum.Periferico> perifericosCuatro = new List<Enum.Periferico>();
            perifericosCuatro.Add(Enum.Periferico.Auriculares);
            perifericosCuatro.Add(Enum.Periferico.Mouse);
            List<Enum.Juego> juegosCuatro = new List<Enum.Juego>();
            juegosCuatro.Add(Enum.Juego.Age_II);
            juegosCuatro.Add(Enum.Juego.Counter_Strike);
            juegosCuatro.Add(Enum.Juego.Diablo_II);
            Hardware hardwareCuatro = new Hardware(Enum.Procesador.Pentium_4, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_MX_100, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresCinco = new List<Enum.Software>();
            softwaresCinco.Add(Enum.Software.Office);
            softwaresCinco.Add(Enum.Software.Messenger);
            List<Enum.Periferico> perifericosCinco = new List<Enum.Periferico>();
            perifericosCinco.Add(Enum.Periferico.Auriculares);
            perifericosCinco.Add(Enum.Periferico.Mouse);
            List<Enum.Juego> juegosCinco = new List<Enum.Juego>();
            juegosCinco.Add(Enum.Juego.Age_II);
            juegosCinco.Add(Enum.Juego.Counter_Strike);
            juegosCinco.Add(Enum.Juego.Diablo_II);
            Hardware hardwareCinco = new Hardware(Enum.Procesador.AMD_Athon, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_MX_100, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresSeis = new List<Enum.Software>();
            softwaresSeis.Add(Enum.Software.Icq);
            softwaresSeis.Add(Enum.Software.Office);
            softwaresSeis.Add(Enum.Software.Messenger);
            List<Enum.Periferico> perifericosSeis = new List<Enum.Periferico>();
            perifericosSeis.Add(Enum.Periferico.Auriculares);
            perifericosSeis.Add(Enum.Periferico.Mouse);
            perifericosSeis.Add(Enum.Periferico.Camara);
            List<Enum.Juego> juegosSeis = new List<Enum.Juego>();
            juegosSeis.Add(Enum.Juego.LineAge_II);
            juegosSeis.Add(Enum.Juego.Counter_Strike);
            juegosSeis.Add(Enum.Juego.Diablo_II);
            Hardware hardwareSeis = new Hardware(Enum.Procesador.Pentium_III, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_PRO, Enum.DiscoDuro.Gb_10);

            List<Enum.Software> softwaresSiete = new List<Enum.Software>();
            softwaresSiete.Add(Enum.Software.Ares);
            softwaresSiete.Add(Enum.Software.Office);
            softwaresSiete.Add(Enum.Software.Messenger);
            List<Enum.Periferico> perifericosSiete = new List<Enum.Periferico>();
            perifericosSiete.Add(Enum.Periferico.Auriculares);
            perifericosSiete.Add(Enum.Periferico.Mouse);
            perifericosSiete.Add(Enum.Periferico.Camara);
            List<Enum.Juego> juegosSiete = new List<Enum.Juego>();
            juegosSiete.Add(Enum.Juego.LineAge_II);
            juegosSiete.Add(Enum.Juego.Counter_Strike);
            juegosSiete.Add(Enum.Juego.Age_II);
            Hardware hardwareSiete = new Hardware(Enum.Procesador.Pentium_III, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_Ti, Enum.DiscoDuro.Gb_20);

            List<Enum.Software> softwaresOcho = new List<Enum.Software>();
            softwaresOcho.Add(Enum.Software.Messenger);
            List<Enum.Periferico> perifericosOcho = new List<Enum.Periferico>();
            perifericosOcho.Add(Enum.Periferico.Auriculares);
            perifericosOcho.Add(Enum.Periferico.Mouse);
            perifericosOcho.Add(Enum.Periferico.Camara);
            List<Enum.Juego> juegosOcho = new List<Enum.Juego>();
            juegosOcho.Add(Enum.Juego.LineAge_II);
            juegosOcho.Add(Enum.Juego.Counter_Strike);
            juegosOcho.Add(Enum.Juego.Age_II);
            juegosOcho.Add(Enum.Juego.Mu_Online);
            juegosOcho.Add(Enum.Juego.warcraft_III);
            Hardware hardwareOcho = new Hardware(Enum.Procesador.Pentium_4, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_Ti, Enum.DiscoDuro.Gb_20);

            List<Enum.Software> softwaresNueve = new List<Enum.Software>();
            softwaresNueve.Add(Enum.Software.Icq);
            List<Enum.Periferico> perifericosNueve = new List<Enum.Periferico>();
            perifericosNueve.Add(Enum.Periferico.Auriculares);
            perifericosNueve.Add(Enum.Periferico.Mouse);
            perifericosNueve.Add(Enum.Periferico.Camara);
            perifericosNueve.Add(Enum.Periferico.Microfono);
            List<Enum.Juego> juegosNueve = new List<Enum.Juego>();
            juegosNueve.Add(Enum.Juego.LineAge_II);
            juegosNueve.Add(Enum.Juego.Counter_Strike);
            juegosNueve.Add(Enum.Juego.Age_II);
            juegosNueve.Add(Enum.Juego.Mu_Online);
            juegosNueve.Add(Enum.Juego.warcraft_III);
            juegosNueve.Add(Enum.Juego.Age_II);
            Hardware hardwareNueve = new Hardware(Enum.Procesador.Pentium_4, Enum.Ram.Mb_64, 
                Enum.PlacaDeVideo.GeForce2_PRO, Enum.DiscoDuro.Gb_20);

            List<Enum.Software> softwaresDiez = new List<Enum.Software>();
            softwaresDiez.Add(Enum.Software.Ares);
            softwaresDiez.Add(Enum.Software.Icq);
            softwaresDiez.Add(Enum.Software.Ares);
            softwaresDiez.Add(Enum.Software.Office);
            List<Enum.Periferico> perifericosDiez = new List<Enum.Periferico>();
            perifericosDiez.Add(Enum.Periferico.Auriculares);
            perifericosDiez.Add(Enum.Periferico.Mouse);
            perifericosDiez.Add(Enum.Periferico.Camara);
            perifericosDiez.Add(Enum.Periferico.Microfono);
            List<Enum.Juego> juegosDiez = new List<Enum.Juego>();
            juegosDiez.Add(Enum.Juego.LineAge_II);
            juegosDiez.Add(Enum.Juego.Counter_Strike);
            juegosDiez.Add(Enum.Juego.Age_II);
            juegosDiez.Add(Enum.Juego.Mu_Online);
            juegosDiez.Add(Enum.Juego.warcraft_III);
            juegosDiez.Add(Enum.Juego.Age_II);
            Hardware hardwareDiez = new Hardware(Enum.Procesador.AMD_Athon, Enum.Ram.Mb_128, 
                Enum.PlacaDeVideo.GeForce2_PRO, Enum.DiscoDuro.Gb_20);

            List<Computadora> computadoras = new List<Computadora>();
            computadoras.Add(new Computadora("C01", softwaresUno, perifericosUno, juegosUno, hardwareUno));
            computadoras.Add(new Computadora("C02", softwaresDos, perifericosDos, juegosDos, hardwareDos));
            computadoras.Add(new Computadora("C03", softwaresTres, perifericosTres, juegosTres, hardwareTres));
            computadoras.Add(new Computadora("C04", softwaresCuatro, perifericosCuatro, juegosCuatro, hardwareCuatro));
            computadoras.Add(new Computadora("C05", softwaresCinco, perifericosCinco, juegosCinco, hardwareCinco));
            computadoras.Add(new Computadora("C06", softwaresSeis, perifericosSeis, juegosSeis, hardwareSeis));
            computadoras.Add(new Computadora("C07", softwaresSiete, perifericosSiete, juegosSiete, hardwareSiete));
            computadoras.Add(new Computadora("C08", softwaresOcho, perifericosOcho, juegosOcho, hardwareOcho));
            computadoras.Add(new Computadora("C09", softwaresNueve, perifericosNueve, juegosNueve, hardwareNueve));
            computadoras.Add(new Computadora("C10", softwaresDiez, perifericosDiez, juegosDiez, hardwareDiez));
            return computadoras;
        }

    }
}
