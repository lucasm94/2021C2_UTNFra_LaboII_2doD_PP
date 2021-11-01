
namespace CIber
{
    partial class FrmDispositivos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.dgvDispositivos = new System.Windows.Forms.DataGridView();
            this.cmbUsoDispositivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(550, 433);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(126, 25);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Lucas Monzon";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(682, 433);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "26/10/2021";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivos.FormattingEnabled = true;
            this.cmbDispositivos.Location = new System.Drawing.Point(131, 12);
            this.cmbDispositivos.Name = "cmbDispositivos";
            this.cmbDispositivos.Size = new System.Drawing.Size(182, 33);
            this.cmbDispositivos.TabIndex = 7;
            this.cmbDispositivos.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivos_SelectedIndexChanged);
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.AllowUserToAddRows = false;
            this.dgvDispositivos.AllowUserToDeleteRows = false;
            this.dgvDispositivos.AllowUserToOrderColumns = true;
            this.dgvDispositivos.AllowUserToResizeRows = false;
            this.dgvDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDispositivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Location = new System.Drawing.Point(13, 51);
            this.dgvDispositivos.MultiSelect = false;
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.RowHeadersVisible = false;
            this.dgvDispositivos.RowHeadersWidth = 62;
            this.dgvDispositivos.RowTemplate.Height = 33;
            this.dgvDispositivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispositivos.Size = new System.Drawing.Size(775, 367);
            this.dgvDispositivos.TabIndex = 9;
            // 
            // cmbUsoDispositivo
            // 
            this.cmbUsoDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsoDispositivo.FormattingEnabled = true;
            this.cmbUsoDispositivo.Location = new System.Drawing.Point(453, 12);
            this.cmbUsoDispositivo.Name = "cmbUsoDispositivo";
            this.cmbUsoDispositivo.Size = new System.Drawing.Size(182, 33);
            this.cmbUsoDispositivo.TabIndex = 10;
            this.cmbUsoDispositivo.SelectedIndexChanged += new System.EventHandler(this.cmbUsoDispositivo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dispositivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado";
            // 
            // FrmDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsoDispositivo);
            this.Controls.Add(this.dgvDispositivos);
            this.Controls.Add(this.cmbDispositivos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFecha);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FrmDispositivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciber Cafe - Dispositivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.ComboBox cmbUsoDispositivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

