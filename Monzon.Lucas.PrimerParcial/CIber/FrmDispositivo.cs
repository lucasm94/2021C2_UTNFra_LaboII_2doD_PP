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
    public partial class FrmDispositivos : Form
    {
        private List<string> headersComputadoras;
        private List<string> headersTelefonos;
        private CiberCafe ciberCafe;
        private DataTable dataTable;

        public FrmDispositivos(CiberCafe ciberCafe)
        {
            InitializeComponent();
            this.ciberCafe = ciberCafe;
            this.headersComputadoras = new List<string>() { "ID", "En Uso", "Procesador", "Ram", 
                "Placa de Video", "Disco Duro" };
            this.headersTelefonos = new List<string>() { "ID", "En Uso", "Tipo", "Marca" };
            this.dataTable = new DataTable();
            this.dgvDispositivos.DataSource = this.dataTable;
            cargarCmb();
            this.cmbDispositivos.SelectedIndex = 0;
        }

        private void cargarCmb()
        {
            this.cmbDispositivos.Items.Add(Constantes.COMPUTADORA);
            this.cmbDispositivos.Items.Add(Constantes.TELEFONO);
            this.cmbUsoDispositivo.Items.Add(Constantes.TODO);
            this.cmbUsoDispositivo.Items.Add(Constantes.LIBRES);
            this.cmbUsoDispositivo.Items.Add(Constantes.EN_USO);
        }

        private void cmbDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable.Columns.Clear();
            switch (this.cmbDispositivos.SelectedItem.ToString())
            {
                case Constantes.COMPUTADORA:
                    foreach (string header in this.headersComputadoras)
                    {
                        this.dataTable.Columns.Add(header);
                    }
                    break;
                case Constantes.TELEFONO:
                    foreach (string header in this.headersTelefonos)
                    {
                        this.dataTable.Columns.Add(header);
                    }
                    break;
            }
            this.cmbUsoDispositivo.SelectedIndex = -1;
            this.cmbUsoDispositivo.SelectedIndex = 0;
        }

        private void cmbUsoDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbUsoDispositivo.SelectedIndex > -1)
            {
                this.dataTable.Rows.Clear();
                string estado = this.cmbUsoDispositivo.SelectedItem.ToString();
                switch (this.cmbDispositivos.SelectedItem.ToString())
                {
                    case Constantes.COMPUTADORA:
                        foreach (Computadora computadora in this.ciberCafe.Computadoras(estado))
                        {
                            this.dataTable.Rows.Add(computadora.Id, computadora.EnUso,
                                computadora.Hardware.Procesador, computadora.Hardware.Ram,
                                computadora.Hardware.PlacaDeVideo, computadora.Hardware.DiscoDuro);
                        }
                        break;
                    case Constantes.TELEFONO:
                        foreach (Telefono telefono in this.ciberCafe.Telefonos(estado))
                        {
                            this.dataTable.Rows.Add(telefono.Id, telefono.EnUso,
                                telefono.Tipo, telefono.Marca);
                        }
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
