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
    public partial class FrmMenu : Form
    {
        protected CiberCafe ciberCafe;
        private FrmDispositivos frmDispositivos;
        private FrmCliente frmClientes;

        public FrmMenu()
        {
            InitializeComponent();
            this.ciberCafe = new CiberCafe();
            this.frmDispositivos = new FrmDispositivos(this.ciberCafe);
            this.frmClientes = new FrmCliente(this.ciberCafe);
        }

        private void btnDispositivosMenu_Click(object sender, EventArgs e)
        {
            this.frmDispositivos.ShowDialog();
        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            this.frmClientes.ShowDialog();
        }
    }
}
