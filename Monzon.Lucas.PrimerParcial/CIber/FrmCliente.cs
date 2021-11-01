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
    public partial class FrmCliente : Form
    {
        private List<string> headersClientes;
        private DataTable dataTable;
        private CiberCafe ciberCafe;

        public FrmCliente(CiberCafe ciberCafe)
        {
            InitializeComponent();
            this.ciberCafe = ciberCafe;
            this.dataTable = new DataTable();
            this.dgvClientes.DataSource = this.dataTable;
            this.headersClientes = new List<string>() { "Dni", "Nombre", "Apellido", "Edad", 
                "Atendido" };
            this.cmbEstadoCliente.Items.Add(Constantes.ATENDIDO);
            this.cmbEstadoCliente.Items.Add(Constantes.ESPERANDO);
            foreach (string header in this.headersClientes)
            {
                this.dataTable.Columns.Add(header);
            }
            this.cmbEstadoCliente.SelectedIndex = 0;
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstadoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable.Rows.Clear();
            if (this.cmbEstadoCliente.SelectedIndex > -1)
            {
                string estado = this.cmbEstadoCliente.SelectedItem.ToString();
                switch (estado)
                {
                    case Constantes.ATENDIDO:
                        foreach (Cliente cliente in this.ciberCafe.ClientesAtendidos)
                        {
                            this.dataTable.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre, 
                                cliente.Edad, cliente.Atendido);
                        }
                        break;
                    case Constantes.ESPERANDO:
                        foreach (Cliente cliente in this.ciberCafe.ClientesEnEspera)
                        {
                            this.dataTable.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre,
                                cliente.Edad, cliente.Atendido);
                        }
                        break;
                }
            }
        }
    }
}
