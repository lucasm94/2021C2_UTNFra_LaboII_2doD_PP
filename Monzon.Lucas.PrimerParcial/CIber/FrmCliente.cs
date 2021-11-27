using Biblioteca;
using Biblioteca.Entidades;
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
    public partial class FrmCliente : FrmBase
    {
        private List<string> headersClientes;
        private DataTable dataTable;
        private FrmAsignarMaquina frmAsignar;
        private FrmAsignarCabina frmAsignarCabina;
        private CiberCafe ciberCafe;

        public FrmCliente(CiberCafe ciber)
        {
            InitializeComponent();
            this.ciberCafe = ciber;
            this.dataTable = new DataTable();
            this.frmAsignar = new FrmAsignarMaquina(this.ciberCafe, this.cmbEstadoCliente);
            this.frmAsignarCabina = new FrmAsignarCabina(this.ciberCafe, this.cmbEstadoCliente);
            this.dgvClientes.DataSource = this.dataTable;
            this.headersClientes = new List<string>() { "Dni", "Nombre", "Apellido", "Edad", 
                "Atendido", "Servicio" };
            this.cmbEstadoCliente.Items.Add(Constantes.ATENDIDO);
            this.cmbEstadoCliente.Items.Add(Constantes.ESPERANDO);
            this.cmbEstadoCliente.Items.Add(Constantes.USANDO_SERVICIO);
            foreach (string header in this.headersClientes)
            {
                this.dataTable.Columns.Add(header);
            }
            this.cmbEstadoCliente.SelectedIndex = 0;
            this.dgvClientes.CancelEdit();
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
                        if (this.ciberCafe.ClientesAtendidos.Count > 0)
                        {
                            foreach (Cliente cliente in this.ciberCafe.ClientesAtendidos)
                            {
                                this.dataTable.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre,
                                    cliente.Edad, cliente.Atendido, this.ciberCafe.ServicioQueNecesita(cliente));
                            }
                        }
                        this.btnAsignar.Enabled = false;
                        this.btnLiberar.Enabled = false;
                        break;
                    case Constantes.ESPERANDO:
                        if (this.ciberCafe.ClientesEnEspera.Count > 0)
                        {
                            foreach (Cliente cliente in this.ciberCafe.ClientesEnEspera)
                            {
                                this.dataTable.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre,
                                    cliente.Edad, cliente.Atendido, this.ciberCafe.ServicioQueNecesita(cliente));
                            }
                            this.btnAsignar.Enabled = true;
                            this.btnLiberar.Enabled = false;
                        } else
                        {
                            this.btnAsignar.Enabled = false;
                            this.btnLiberar.Enabled = false;
                        }
                        break;
                    case Constantes.USANDO_SERVICIO:
                        if (this.ciberCafe.ClientesUsandoServicio.Count > 0)
                        {
                            foreach (Cliente cliente in this.ciberCafe.ClientesUsandoServicio)
                            {
                                this.dataTable.Rows.Add(cliente.Dni, cliente.Apellido, cliente.Nombre,
                                    cliente.Edad, cliente.Atendido, this.ciberCafe.ServicioQueNecesita(cliente));
                            }
                            this.btnAsignar.Enabled = false;
                            this.btnLiberar.Enabled = true;
                        }
                        else
                        {
                            this.btnAsignar.Enabled = false;
                            this.btnLiberar.Enabled = false;
                        }
                        break;
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.ciberCafe.ClientesEnEspera[0];
            if (cliente is ClienteComputadora && ValidarSiHayDisponibilidad(Constantes.COMPUTADORA))
            {
                this.frmAsignar.CargarYMostrarCliente((ClienteComputadora) cliente);
                this.frmAsignar.ShowDialog();
            }
            else if (ValidarSiHayDisponibilidad(Constantes.CABINA))
            {
                this.frmAsignarCabina.CargarClienteYTelefono(cliente.Dni, this.ciberCafe.Telefonos(Constantes.LIBRES)[0].Id);
                this.frmAsignarCabina.ShowDialog();
            } else
            {
                MessageBox.Show("No hay disponibilidad para el servicio requerido en este momento, primero debe Liberar");
            }
        }

        private bool ValidarSiHayDisponibilidad(string servicio)
        {
            if (servicio.Equals(Constantes.COMPUTADORA))
            {
                return this.ciberCafe.Computadoras(Constantes.LIBRES).Count > 0;
            } else
            {
                return this.ciberCafe.Telefonos(Constantes.LIBRES).Count > 0;
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            ServicioFinalizadoInfo info = this.ciberCafe.FinalizarUso(
                Int32.Parse(this.dgvClientes.SelectedRows[0].Cells[0].Value.ToString()),
                this.dgvClientes.SelectedRows[0].Cells[5].Value.ToString());
            this.cmbEstadoCliente.SelectedIndex = -1;
            this.cmbEstadoCliente.SelectedIndex = 2;
            MessageBox.Show($"El tiempo de uso es: {info.MinutosDeUso} min\n" +
                $"El monto bruto a pagar es: ${info.BrutoAPagar}\n" +
                $"El monto neto a pagar es: ${info.NetoAPagar}\n" +
                $"El monto final a pagar es: ${info.MontoFinal}");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientes.Rows.Count > 0 && 
                this.dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString()
                .Equals(Constantes.COMPUTADORA) && this.cmbEstadoCliente.Text.Equals(Constantes.ESPERANDO))
            {
                this.tltNecesita.SetToolTip(dgvClientes, 
                    ((ClienteComputadora)this.ciberCafe.ClientesEnEspera[e.RowIndex]).QueNecesita());
            }
        }
    }
}
