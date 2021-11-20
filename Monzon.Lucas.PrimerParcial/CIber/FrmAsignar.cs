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
        private Cliente cliente;

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
        }

        public void MostrarCliente(Cliente cliente)
        {
            this.rtbCliente.Text = cliente.ToString();
        }
    }
}
