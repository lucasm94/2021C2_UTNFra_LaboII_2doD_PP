using Biblioteca;
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
    public partial class FrmAsignarCabina : FrmBase
    {
        private CiberCafe ciber;
        private ComboBox estadoCliente;

        public FrmAsignarCabina(CiberCafe ciber, ComboBox estadoCliente)
        {
            InitializeComponent();
            this.ciber = ciber;
            this.estadoCliente = estadoCliente;
        }

        public void CargarClienteYTelefono(int dniCliente, string idTelefono)
        {
            this.lblDniClienteInfo.Text = dniCliente.ToString();
            this.lblCabinaInfo.Text = idTelefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtCodPais.Text) && String.IsNullOrEmpty(txtCodArea.Text) &&
                String.IsNullOrEmpty(txtNumero1.Text) && String.IsNullOrEmpty(txtNumero2.Text)))
            {
                this.ciber.Asignar(Int32.Parse(this.lblDniClienteInfo.Text), this.lblCabinaInfo.Text, 
                    $"{this.txtCodPais.Text}-{this.txtCodArea.Text}-{this.txtNumero1.Text}-{this.txtNumero2.Text}");
                MessageBox.Show("Se asigno maquina con exito");
                this.estadoCliente.SelectedIndex = -1;
                this.estadoCliente.SelectedIndex = 1;
                this.Close();
            } else
            {
                MessageBox.Show("Para asignar primero ingrese numero de telefono y reintente");
            }
        }

        /// <summary>
        /// Metodo que Valida que solo se ingresen Numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
