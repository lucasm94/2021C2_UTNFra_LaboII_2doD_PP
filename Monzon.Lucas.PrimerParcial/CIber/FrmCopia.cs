using Biblioteca;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIber
{
    public partial class FrmCopia : FrmBase
    {
        private CiberCafe ciber;

        public FrmCopia(CiberCafe ciber)
        {
            InitializeComponent();
            this.ciber = ciber;
            List<Biblioteca.Enum.Juego> juegos = 
                System.Enum.GetValues(typeof(Biblioteca.Enum.Juego)).Cast<Biblioteca.Enum.Juego>().ToList();
            foreach (Biblioteca.Enum.Juego juego in juegos)
            {
                this.cmbJuego.Items.Add(juego.ToString());
                this.cmbCopiaJuego.Items.Add(juego.ToString());
            }
            for (int i = 1; i < 11; i++)
            {
                this.cmbNumeroCopias.Items.Add(i);
            }
            CargarGanancias();
        }

        private void CargarGanancias()
        {
            this.lblGananciasRes.Text = "$" + this.ciber.ObtenerGananciasPorCopiasRealizadas().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.cmbCopiaJuego.SelectedIndex > -1 && 
                this.cmbNumeroCopias.SelectedIndex > -1)
            {
                int cantidad = Int32.Parse(this.cmbNumeroCopias.Text);
                Biblioteca.Enum.Juego juego =
                    (Biblioteca.Enum.Juego)System.Enum.Parse(typeof(Biblioteca.Enum.Juego),
                    this.cmbCopiaJuego.Text);
                this.ciber.CopiarJuegoACd(juego, cantidad);
                this.lblCantidadCopiasRes.Text = "";
                this.lblGananciaJuegoRes.Text = "";
                this.cmbJuego.SelectedIndex = -1;
                CargarGanancias();
            }
            else
            {
                MessageBox.Show("Para poder realizar una copia debe seleccionar el juego" +
                    " e ingresar la cantidad de copias");
            }
        }

        private void cmbJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbJuego.SelectedIndex > -1)
            {
                Biblioteca.Enum.Juego juego = 
                    (Biblioteca.Enum.Juego)System.Enum.Parse(typeof(Biblioteca.Enum.Juego), 
                    this.cmbJuego.Text);
                Copia copia = this.ciber.ObtenerInfoDeCopiaDeUnJuego(juego);
                this.lblCantidadCopiasRes.Text = copia.Cantidad.ToString();
                this.lblGananciaJuegoRes.Text = "$" + copia.Ganancia.ToString();
            }
        }
    }
}
