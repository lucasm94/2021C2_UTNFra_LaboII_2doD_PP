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
    public partial class FrmMenu : FrmBase
    {
        private FrmDispositivos frmDispositivos;
        private FrmCliente frmClientes;
        private FrmEstadisticas frmEstadisticas;
        private CiberCafe ciberCafe;

        public FrmMenu(CiberCafe ciber)
        {
            InitializeComponent();
            this.ciberCafe = ciber;
            this.frmDispositivos = new FrmDispositivos(this.ciberCafe);
            this.frmClientes = new FrmCliente(this.ciberCafe);
            this.frmEstadisticas = new FrmEstadisticas(this.ciberCafe);
            this.ModificarNombreBotonACerrar();
        }

        private void btnDispositivosMenu_Click(object sender, EventArgs e)
        {
            this.frmDispositivos.ShowDialog();
        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            this.frmClientes.ShowDialog();
        }

        private void btnEstadisticasMenu_Click(object sender, EventArgs e)
        {
            this.frmEstadisticas.ShowDialog();
        }
    }
}
