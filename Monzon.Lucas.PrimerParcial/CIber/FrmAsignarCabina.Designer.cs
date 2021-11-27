
namespace CIber
{
    partial class FrmAsignarCabina
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
            this.lblAsignarCabina = new System.Windows.Forms.Label();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblDniClienteInfo = new System.Windows.Forms.Label();
            this.lblCabinaInfo = new System.Windows.Forms.Label();
            this.lblCabina = new System.Windows.Forms.Label();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblGuion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodPais = new System.Windows.Forms.Label();
            this.lblCodArea = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAsignarCabina
            // 
            this.lblAsignarCabina.AutoSize = true;
            this.lblAsignarCabina.Location = new System.Drawing.Point(12, 59);
            this.lblAsignarCabina.Name = "lblAsignarCabina";
            this.lblAsignarCabina.Size = new System.Drawing.Size(243, 25);
            this.lblAsignarCabina.TabIndex = 18;
            this.lblAsignarCabina.Text = "Ingresar numero de telefono:";
            // 
            // txtCodPais
            // 
            this.txtCodPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodPais.Location = new System.Drawing.Point(263, 56);
            this.txtCodPais.MaxLength = 4;
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(62, 31);
            this.txtCodPais.TabIndex = 19;
            this.txtCodPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.Location = new System.Drawing.Point(498, 120);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(112, 34);
            this.btnAsignar.TabIndex = 20;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(13, 13);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(98, 25);
            this.lblDniCliente.TabIndex = 21;
            this.lblDniCliente.Text = "Dni cliente:";
            // 
            // lblDniClienteInfo
            // 
            this.lblDniClienteInfo.AutoSize = true;
            this.lblDniClienteInfo.Location = new System.Drawing.Point(118, 13);
            this.lblDniClienteInfo.Name = "lblDniClienteInfo";
            this.lblDniClienteInfo.Size = new System.Drawing.Size(0, 25);
            this.lblDniClienteInfo.TabIndex = 22;
            // 
            // lblCabinaInfo
            // 
            this.lblCabinaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabinaInfo.AutoSize = true;
            this.lblCabinaInfo.Location = new System.Drawing.Point(479, 13);
            this.lblCabinaInfo.Name = "lblCabinaInfo";
            this.lblCabinaInfo.Size = new System.Drawing.Size(0, 25);
            this.lblCabinaInfo.TabIndex = 24;
            // 
            // lblCabina
            // 
            this.lblCabina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabina.AutoSize = true;
            this.lblCabina.Location = new System.Drawing.Point(369, 13);
            this.lblCabina.Name = "lblCabina";
            this.lblCabina.Size = new System.Drawing.Size(104, 25);
            this.lblCabina.TabIndex = 23;
            this.lblCabina.Text = "Id Telefono:";
            // 
            // txtCodArea
            // 
            this.txtCodArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodArea.Location = new System.Drawing.Point(357, 56);
            this.txtCodArea.MaxLength = 4;
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(62, 31);
            this.txtCodArea.TabIndex = 25;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(453, 56);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 31);
            this.txtNumero.TabIndex = 26;
            // 
            // lblGuion
            // 
            this.lblGuion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuion.AutoSize = true;
            this.lblGuion.Location = new System.Drawing.Point(332, 59);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(19, 25);
            this.lblGuion.TabIndex = 28;
            this.lblGuion.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "-";
            // 
            // lblCodPais
            // 
            this.lblCodPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodPais.AutoSize = true;
            this.lblCodPais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCodPais.Location = new System.Drawing.Point(254, 90);
            this.lblCodPais.Name = "lblCodPais";
            this.lblCodPais.Size = new System.Drawing.Size(90, 25);
            this.lblCodPais.TabIndex = 30;
            this.lblCodPais.Text = "(Cod País)";
            // 
            // lblCodArea
            // 
            this.lblCodArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodArea.AutoSize = true;
            this.lblCodArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCodArea.Location = new System.Drawing.Point(359, 90);
            this.lblCodArea.Name = "lblCodArea";
            this.lblCodArea.Size = new System.Drawing.Size(72, 25);
            this.lblCodArea.TabIndex = 31;
            this.lblCodArea.Text = "(Prefijo)";
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNumero.Location = new System.Drawing.Point(493, 90);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(89, 25);
            this.lblNumero.TabIndex = 32;
            this.lblNumero.Text = "(Teléfono)";
            // 
            // FrmAsignarCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 200);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodArea);
            this.Controls.Add(this.lblCodPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGuion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCodArea);
            this.Controls.Add(this.lblCabinaInfo);
            this.Controls.Add(this.lblCabina);
            this.Controls.Add(this.lblDniClienteInfo);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.lblAsignarCabina);
            this.MaximumSize = new System.Drawing.Size(700, 260);
            this.MinimumSize = new System.Drawing.Size(644, 200);
            this.Name = "FrmAsignarCabina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar cabina";
            this.Controls.SetChildIndex(this.lblAsignarCabina, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.btnAsignar, 0);
            this.Controls.SetChildIndex(this.lblDniCliente, 0);
            this.Controls.SetChildIndex(this.lblDniClienteInfo, 0);
            this.Controls.SetChildIndex(this.lblCabina, 0);
            this.Controls.SetChildIndex(this.lblCabinaInfo, 0);
            this.Controls.SetChildIndex(this.txtCodArea, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.lblGuion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblCodPais, 0);
            this.Controls.SetChildIndex(this.lblCodArea, 0);
            this.Controls.SetChildIndex(this.lblNumero, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignarCabina;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblDniClienteInfo;
        private System.Windows.Forms.Label lblCabinaInfo;
        private System.Windows.Forms.Label lblCabina;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodPais;
        private System.Windows.Forms.Label lblCodArea;
        private System.Windows.Forms.Label lblNumero;
    }
}