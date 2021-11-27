
namespace CIber
{
    partial class FrmEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloGanancia = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblGananciasServicios = new System.Windows.Forms.Label();
            this.lblRecaudacionTipo = new System.Windows.Forms.Label();
            this.lblTipoDeLlamada = new System.Windows.Forms.Label();
            this.cmbRecaudacion = new System.Windows.Forms.ComboBox();
            this.lblRecaudacionTipoTitulo = new System.Windows.Forms.Label();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.dgvDispositivos = new System.Windows.Forms.DataGridView();
            this.cmbDispositivo = new System.Windows.Forms.ComboBox();
            this.lblMasPedidos = new System.Windows.Forms.Label();
            this.cmbMasPedidos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHorasTotales = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMasPedidoRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloGanancia
            // 
            this.lblTituloGanancia.AutoSize = true;
            this.lblTituloGanancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloGanancia.Location = new System.Drawing.Point(13, 13);
            this.lblTituloGanancia.Name = "lblTituloGanancia";
            this.lblTituloGanancia.Size = new System.Drawing.Size(199, 32);
            this.lblTituloGanancia.TabIndex = 18;
            this.lblTituloGanancia.Text = "Ganancias totales";
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(91, 56);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(164, 33);
            this.cmbServicio.TabIndex = 19;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(12, 59);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(73, 25);
            this.lblServicio.TabIndex = 20;
            this.lblServicio.Text = "Servicio";
            // 
            // lblGananciasServicios
            // 
            this.lblGananciasServicios.AutoSize = true;
            this.lblGananciasServicios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGananciasServicios.Location = new System.Drawing.Point(143, 108);
            this.lblGananciasServicios.Name = "lblGananciasServicios";
            this.lblGananciasServicios.Size = new System.Drawing.Size(0, 32);
            this.lblGananciasServicios.TabIndex = 21;
            // 
            // lblRecaudacionTipo
            // 
            this.lblRecaudacionTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecaudacionTipo.AutoSize = true;
            this.lblRecaudacionTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacionTipo.Location = new System.Drawing.Point(143, 257);
            this.lblRecaudacionTipo.Name = "lblRecaudacionTipo";
            this.lblRecaudacionTipo.Size = new System.Drawing.Size(0, 32);
            this.lblRecaudacionTipo.TabIndex = 25;
            // 
            // lblTipoDeLlamada
            // 
            this.lblTipoDeLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoDeLlamada.AutoSize = true;
            this.lblTipoDeLlamada.Location = new System.Drawing.Point(184, 209);
            this.lblTipoDeLlamada.Name = "lblTipoDeLlamada";
            this.lblTipoDeLlamada.Size = new System.Drawing.Size(139, 25);
            this.lblTipoDeLlamada.TabIndex = 24;
            this.lblTipoDeLlamada.Text = "Tipo de llamada";
            // 
            // cmbRecaudacion
            // 
            this.cmbRecaudacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRecaudacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecaudacion.FormattingEnabled = true;
            this.cmbRecaudacion.Location = new System.Drawing.Point(330, 206);
            this.cmbRecaudacion.Name = "cmbRecaudacion";
            this.cmbRecaudacion.Size = new System.Drawing.Size(151, 33);
            this.cmbRecaudacion.TabIndex = 23;
            this.cmbRecaudacion.SelectedIndexChanged += new System.EventHandler(this.cmbRecaudacion_SelectedIndexChanged);
            // 
            // lblRecaudacionTipoTitulo
            // 
            this.lblRecaudacionTipoTitulo.AutoSize = true;
            this.lblRecaudacionTipoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacionTipoTitulo.Location = new System.Drawing.Point(13, 159);
            this.lblRecaudacionTipoTitulo.Name = "lblRecaudacionTipoTitulo";
            this.lblRecaudacionTipoTitulo.Size = new System.Drawing.Size(310, 32);
            this.lblRecaudacionTipoTitulo.TabIndex = 22;
            this.lblRecaudacionTipoTitulo.Text = "Recaudacion y horas totales";
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo.Location = new System.Drawing.Point(633, 13);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(313, 32);
            this.lblDispositivo.TabIndex = 26;
            this.lblDispositivo.Text = "Dispositivos por minuto uso";
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.AllowUserToAddRows = false;
            this.dgvDispositivos.AllowUserToDeleteRows = false;
            this.dgvDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDispositivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Location = new System.Drawing.Point(642, 55);
            this.dgvDispositivos.MultiSelect = false;
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.ReadOnly = true;
            this.dgvDispositivos.RowHeadersVisible = false;
            this.dgvDispositivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDispositivos.RowTemplate.Height = 33;
            this.dgvDispositivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispositivos.Size = new System.Drawing.Size(434, 279);
            this.dgvDispositivos.TabIndex = 27;
            // 
            // cmbDispositivo
            // 
            this.cmbDispositivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivo.FormattingEnabled = true;
            this.cmbDispositivo.Location = new System.Drawing.Point(945, 12);
            this.cmbDispositivo.Name = "cmbDispositivo";
            this.cmbDispositivo.Size = new System.Drawing.Size(131, 33);
            this.cmbDispositivo.TabIndex = 28;
            this.cmbDispositivo.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivo_SelectedIndexChanged);
            // 
            // lblMasPedidos
            // 
            this.lblMasPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMasPedidos.AutoSize = true;
            this.lblMasPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasPedidos.Location = new System.Drawing.Point(310, 13);
            this.lblMasPedidos.Name = "lblMasPedidos";
            this.lblMasPedidos.Size = new System.Drawing.Size(140, 32);
            this.lblMasPedidos.TabIndex = 29;
            this.lblMasPedidos.Text = "Mas pedido";
            // 
            // cmbMasPedidos
            // 
            this.cmbMasPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMasPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasPedidos.FormattingEnabled = true;
            this.cmbMasPedidos.Location = new System.Drawing.Point(456, 12);
            this.cmbMasPedidos.Name = "cmbMasPedidos";
            this.cmbMasPedidos.Size = new System.Drawing.Size(151, 33);
            this.cmbMasPedidos.TabIndex = 30;
            this.cmbMasPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbMasPedidos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Recaudacion";
            // 
            // lblHorasTotales
            // 
            this.lblHorasTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHorasTotales.AutoSize = true;
            this.lblHorasTotales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorasTotales.Location = new System.Drawing.Point(395, 257);
            this.lblHorasTotales.Name = "lblHorasTotales";
            this.lblHorasTotales.Size = new System.Drawing.Size(0, 32);
            this.lblHorasTotales.TabIndex = 33;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(330, 263);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(59, 25);
            this.lblHoras.TabIndex = 34;
            this.lblHoras.Text = "Horas";
            // 
            // lblMasPedidoRes
            // 
            this.lblMasPedidoRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMasPedidoRes.AutoSize = true;
            this.lblMasPedidoRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasPedidoRes.Location = new System.Drawing.Point(415, 71);
            this.lblMasPedidoRes.Name = "lblMasPedidoRes";
            this.lblMasPedidoRes.Size = new System.Drawing.Size(0, 32);
            this.lblMasPedidoRes.TabIndex = 35;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 384);
            this.Controls.Add(this.lblMasPedidoRes);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblHorasTotales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMasPedidos);
            this.Controls.Add(this.lblMasPedidos);
            this.Controls.Add(this.cmbDispositivo);
            this.Controls.Add(this.dgvDispositivos);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.lblRecaudacionTipo);
            this.Controls.Add(this.lblTipoDeLlamada);
            this.Controls.Add(this.cmbRecaudacion);
            this.Controls.Add(this.lblRecaudacionTipoTitulo);
            this.Controls.Add(this.lblGananciasServicios);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.lblTituloGanancia);
            this.MaximumSize = new System.Drawing.Size(1290, 640);
            this.MinimumSize = new System.Drawing.Size(1090, 440);
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.Controls.SetChildIndex(this.lblTituloGanancia, 0);
            this.Controls.SetChildIndex(this.cmbServicio, 0);
            this.Controls.SetChildIndex(this.lblServicio, 0);
            this.Controls.SetChildIndex(this.lblGananciasServicios, 0);
            this.Controls.SetChildIndex(this.lblRecaudacionTipoTitulo, 0);
            this.Controls.SetChildIndex(this.cmbRecaudacion, 0);
            this.Controls.SetChildIndex(this.lblTipoDeLlamada, 0);
            this.Controls.SetChildIndex(this.lblRecaudacionTipo, 0);
            this.Controls.SetChildIndex(this.lblDispositivo, 0);
            this.Controls.SetChildIndex(this.dgvDispositivos, 0);
            this.Controls.SetChildIndex(this.cmbDispositivo, 0);
            this.Controls.SetChildIndex(this.lblMasPedidos, 0);
            this.Controls.SetChildIndex(this.cmbMasPedidos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblHorasTotales, 0);
            this.Controls.SetChildIndex(this.lblHoras, 0);
            this.Controls.SetChildIndex(this.lblMasPedidoRes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloGanancia;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblGananciasServicios;
        private System.Windows.Forms.Label lblRecaudacionTipo;
        private System.Windows.Forms.Label lblTipoDeLlamada;
        private System.Windows.Forms.ComboBox cmbRecaudacion;
        private System.Windows.Forms.Label lblRecaudacionTipoTitulo;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.ComboBox cmbDispositivo;
        private System.Windows.Forms.Label lblMasPedidos;
        private System.Windows.Forms.ComboBox cmbMasPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMasPedidoRes;
    }
}