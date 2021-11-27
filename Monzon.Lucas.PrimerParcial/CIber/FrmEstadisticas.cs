using Biblioteca;
using Biblioteca.Servicios;
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
    public partial class FrmEstadisticas : FrmBase
    {
        private CiberCafe ciber;
        private DataTable dataTable;

        public FrmEstadisticas(CiberCafe cIberCafe)
        {
            InitializeComponent();
            this.ciber = cIberCafe;
            this.dataTable = new DataTable();
            List<string> headers = new List<string>() { "ID", "Minutos de uso" };
            foreach (string header in headers)
            {
                this.dataTable.Columns.Add(header);
            }
            this.dgvDispositivos.DataSource = this.dataTable;
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            this.cmbServicio.Items.Add(Constantes.CABINA);
            this.cmbServicio.Items.Add(Constantes.MAQUINA);
            this.cmbServicio.SelectedIndex = -1;
            this.cmbRecaudacion.Items.Add(Constantes.LOCAL);
            this.cmbRecaudacion.Items.Add(Constantes.LARGA_DISTANCIA);
            this.cmbRecaudacion.Items.Add(Constantes.INTERNACIONAL);
            this.cmbRecaudacion.SelectedIndex = -1;
            this.cmbDispositivo.Items.Add(Constantes.COMPUTADORA);
            this.cmbDispositivo.Items.Add(Constantes.TELEFONO);
            this.cmbDispositivo.SelectedIndex = -1;
            this.cmbMasPedidos.Items.Add(Constantes.SOFTWARE);
            this.cmbMasPedidos.Items.Add(Constantes.JUEGOS);
            this.cmbMasPedidos.Items.Add(Constantes.PERIFERICOS);
            this.cmbMasPedidos.SelectedIndex = -1;
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblGananciasServicios.Text = $"${this.ciber.GananciasTotalesPorServicio(this.cmbServicio.Text)}";
        }

        private void cmbRecaudacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblRecaudacionTipo.Text = $"${this.ciber.RecaudacionTotalPorTipoLlamada(this.cmbRecaudacion.Text)}";
            this.lblHorasTotales.Text = this.ciber.HorasTotalesPorTipoLlamada(this.cmbRecaudacion.Text).ToString();
        }

        private void cmbDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable.Rows.Clear();
            if (this.cmbDispositivo.Text.Equals(Constantes.COMPUTADORA))
            {
                List<Computadora> computadoras = this.ciber.ComputadorasOrdenadasMinDeUsoDesc();
                foreach (Computadora item in computadoras)
                {
                    this.dataTable.Rows.Add(item.Id, item.MinutosDeUsoTotales.ToString());
                }
            } else
            {
                List<Telefono> telefonos = this.ciber.TelefonosOrdenadosMinDeUsoDesc();
                foreach (Telefono item in telefonos)
                {
                    this.dataTable.Rows.Add(item.Id, item.MinutosDeUsoTotales.ToString());
                }
            }
        }

        private void cmbMasPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pedido = "";
            switch (this.cmbMasPedidos.Text)
            {
                case Constantes.SOFTWARE:
                    pedido = this.ciber.SoftwareMasPedidos();
                    break;
                case Constantes.JUEGOS:
                    pedido = this.ciber.JuegoMasPedidos();
                    break;
                case Constantes.PERIFERICOS:
                    pedido = this.ciber.PerifericoMasPedidos();
                    break;
            }
            if (pedido.Length == 0)
            {
                pedido = "Sin pedidos";
            }
            this.lblMasPedidoRes.Text = pedido;
        }
    }
}
