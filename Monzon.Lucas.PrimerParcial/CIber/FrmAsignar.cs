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
    public partial class FrmAsignar : FrmBase
    {
        private List<string> headersComputadoras;
        private DataTable dataTable;
        private ClienteComputadora cliente;

        public FrmAsignar()
        {
            InitializeComponent();
            this.headersComputadoras = new List<string>() { "ID", "En Uso", "Procesador", "Ram",
                "Placa de Video", "Disco Duro" };
            this.dataTable = new DataTable();
            this.dgvComputadoras.DataSource = this.dataTable;
            foreach (string header in this.headersComputadoras)
            {
                this.dataTable.Columns.Add(header);
            }
            foreach (Computadora computadora in 
                this.ciberCafe.Computadoras(Constantes.LIBRES))
            {
                this.dataTable.Rows.Add(computadora.Id, computadora.EnUso,
                    computadora.Hardware.Procesador, computadora.Hardware.Ram,
                    computadora.Hardware.PlacaDeVideo, computadora.Hardware.DiscoDuro);
            }
            if (this.dataTable.Rows.Count > 0)
            {
                this.btnAsigna.Enabled = true;
            }
        }

        public void CargarYMostrarCliente(ClienteComputadora cliente)
        {
            this.cliente = cliente;
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            this.rtbCliente.Text = this.cliente.ToString();
        }

        private void dgvComputadoras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvComputadoras.Rows.Count > 0)
            {
                this.tltAsignar.SetToolTip(dgvComputadoras, 
                    this.ciberCafe.GetComputadoraPorId(this.dgvComputadoras.Rows[e.RowIndex].Cells[0].Value.ToString())
                    .ToString());
            }
        }

        private void btnAsigna_Click(object sender, EventArgs e)
        {
            Computadora computadoraSelecionada = 
                this.ciberCafe.GetComputadoraPorId(this.dgvComputadoras.SelectedRows[0].Cells[0].Value.ToString());
            if (!CumpleNecesidad(computadoraSelecionada))
            {
                MessageBox.Show("No cumple con las necesidades requeridas por el cliente");
            }
        }

        private bool CumpleNecesidad(Computadora computadora)
        {
            bool cumpleNecesidad = true;
            foreach (string key in this.cliente.Necesita.Keys)
            {
                switch (key)
                {
                    case Constantes.SOFTWARE:
                        foreach (string software in this.cliente.Necesita[key])
                        {
                            Biblioteca.Enum.Software softwareEnum =
                                (Biblioteca.Enum.Software)System.Enum.Parse(typeof(Biblioteca.Enum.Software), software);
                            if (!computadora.Softwares.Contains(softwareEnum))
                            {
                                cumpleNecesidad = false;
                                break;
                            }
                        }
                        break;
                    case Constantes.PERIFERICOS:
                        foreach (string periferico in this.cliente.Necesita[key])
                        {
                            Biblioteca.Enum.Periferico perifericoEnum =
                                (Biblioteca.Enum.Periferico)System.Enum.Parse(typeof(Biblioteca.Enum.Periferico), periferico);
                            if (!computadora.Perifericos.Contains(perifericoEnum))
                            {
                                cumpleNecesidad = false;
                                break;
                            }
                        }
                        break;
                    case Constantes.JUEGOS:
                        foreach (string juego in this.cliente.Necesita[key])
                        {
                            Biblioteca.Enum.Juego juegoEnum =
                                (Biblioteca.Enum.Juego)System.Enum.Parse(typeof(Biblioteca.Enum.Juego), juego);
                            if (!computadora.Juegos.Contains(juegoEnum))
                            {
                                cumpleNecesidad = false;
                                break;
                            }
                        }
                        break;
                    case Constantes.HARDWARE:
                        foreach (string hardware in this.cliente.Necesita[key])
                        {
                            if (!(computadora.Hardware.DiscoDuro.ToString().Equals(hardware) ||
                               computadora.Hardware.Ram.ToString().Equals(hardware) ||
                               computadora.Hardware.PlacaDeVideo.ToString().Equals(hardware) ||
                               computadora.Hardware.Procesador.ToString().Equals(hardware)))
                            {
                                cumpleNecesidad = false;
                                break;
                            }
                        }
                        break;
                }
            }
            return cumpleNecesidad;
        }
    }
}
