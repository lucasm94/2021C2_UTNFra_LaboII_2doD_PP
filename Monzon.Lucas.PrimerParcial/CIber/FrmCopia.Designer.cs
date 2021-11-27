
namespace CIber
{
    partial class FrmCopia
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
            this.lblGananciasRes = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSelectJuego = new System.Windows.Forms.Label();
            this.cmbJuego = new System.Windows.Forms.ComboBox();
            this.lblCantidadCopias = new System.Windows.Forms.Label();
            this.lblCantidadCopiasRes = new System.Windows.Forms.Label();
            this.lblGananciaJuego = new System.Windows.Forms.Label();
            this.lblGananciaJuegoRes = new System.Windows.Forms.Label();
            this.lblCopiarJuego = new System.Windows.Forms.Label();
            this.cmbCopiaJuego = new System.Windows.Forms.ComboBox();
            this.lblSelectCopiaJuego = new System.Windows.Forms.Label();
            this.lblCopiaJuegoCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNumeroCopias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblGananciasRes
            // 
            this.lblGananciasRes.AutoSize = true;
            this.lblGananciasRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGananciasRes.Location = new System.Drawing.Point(151, 19);
            this.lblGananciasRes.Name = "lblGananciasRes";
            this.lblGananciasRes.Size = new System.Drawing.Size(0, 32);
            this.lblGananciasRes.TabIndex = 38;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanancia.Location = new System.Drawing.Point(20, 19);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(116, 32);
            this.lblGanancia.TabIndex = 36;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(20, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(240, 32);
            this.lblInfo.TabIndex = 39;
            this.lblInfo.Text = "Informacion de copia";
            // 
            // lblSelectJuego
            // 
            this.lblSelectJuego.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectJuego.AutoSize = true;
            this.lblSelectJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectJuego.Location = new System.Drawing.Point(20, 172);
            this.lblSelectJuego.Name = "lblSelectJuego";
            this.lblSelectJuego.Size = new System.Drawing.Size(59, 25);
            this.lblSelectJuego.TabIndex = 40;
            this.lblSelectJuego.Text = "Juego";
            // 
            // cmbJuego
            // 
            this.cmbJuego.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuego.FormattingEnabled = true;
            this.cmbJuego.Location = new System.Drawing.Point(85, 169);
            this.cmbJuego.Name = "cmbJuego";
            this.cmbJuego.Size = new System.Drawing.Size(175, 33);
            this.cmbJuego.TabIndex = 41;
            this.cmbJuego.SelectedIndexChanged += new System.EventHandler(this.cmbJuego_SelectedIndexChanged);
            // 
            // lblCantidadCopias
            // 
            this.lblCantidadCopias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidadCopias.AutoSize = true;
            this.lblCantidadCopias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCopias.Location = new System.Drawing.Point(20, 240);
            this.lblCantidadCopias.Name = "lblCantidadCopias";
            this.lblCantidadCopias.Size = new System.Drawing.Size(168, 25);
            this.lblCantidadCopias.TabIndex = 42;
            this.lblCantidadCopias.Text = "Cantidad de copias:";
            // 
            // lblCantidadCopiasRes
            // 
            this.lblCantidadCopiasRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidadCopiasRes.AutoSize = true;
            this.lblCantidadCopiasRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCopiasRes.Location = new System.Drawing.Point(190, 240);
            this.lblCantidadCopiasRes.Name = "lblCantidadCopiasRes";
            this.lblCantidadCopiasRes.Size = new System.Drawing.Size(0, 25);
            this.lblCantidadCopiasRes.TabIndex = 43;
            // 
            // lblGananciaJuego
            // 
            this.lblGananciaJuego.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGananciaJuego.AutoSize = true;
            this.lblGananciaJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGananciaJuego.Location = new System.Drawing.Point(20, 304);
            this.lblGananciaJuego.Name = "lblGananciaJuego";
            this.lblGananciaJuego.Size = new System.Drawing.Size(87, 25);
            this.lblGananciaJuego.TabIndex = 44;
            this.lblGananciaJuego.Text = "Ganancia:";
            // 
            // lblGananciaJuegoRes
            // 
            this.lblGananciaJuegoRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGananciaJuegoRes.AutoSize = true;
            this.lblGananciaJuegoRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGananciaJuegoRes.Location = new System.Drawing.Point(189, 304);
            this.lblGananciaJuegoRes.Name = "lblGananciaJuegoRes";
            this.lblGananciaJuegoRes.Size = new System.Drawing.Size(0, 25);
            this.lblGananciaJuegoRes.TabIndex = 45;
            // 
            // lblCopiarJuego
            // 
            this.lblCopiarJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopiarJuego.AutoSize = true;
            this.lblCopiarJuego.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCopiarJuego.Location = new System.Drawing.Point(392, 19);
            this.lblCopiarJuego.Name = "lblCopiarJuego";
            this.lblCopiarJuego.Size = new System.Drawing.Size(151, 32);
            this.lblCopiarJuego.TabIndex = 46;
            this.lblCopiarJuego.Text = "Copiar juego";
            // 
            // cmbCopiaJuego
            // 
            this.cmbCopiaJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCopiaJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopiaJuego.FormattingEnabled = true;
            this.cmbCopiaJuego.Location = new System.Drawing.Point(549, 86);
            this.cmbCopiaJuego.Name = "cmbCopiaJuego";
            this.cmbCopiaJuego.Size = new System.Drawing.Size(175, 33);
            this.cmbCopiaJuego.TabIndex = 48;
            // 
            // lblSelectCopiaJuego
            // 
            this.lblSelectCopiaJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectCopiaJuego.AutoSize = true;
            this.lblSelectCopiaJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectCopiaJuego.Location = new System.Drawing.Point(484, 89);
            this.lblSelectCopiaJuego.Name = "lblSelectCopiaJuego";
            this.lblSelectCopiaJuego.Size = new System.Drawing.Size(59, 25);
            this.lblSelectCopiaJuego.TabIndex = 47;
            this.lblSelectCopiaJuego.Text = "Juego";
            // 
            // lblCopiaJuegoCantidad
            // 
            this.lblCopiaJuegoCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopiaJuegoCantidad.AutoSize = true;
            this.lblCopiaJuegoCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCopiaJuegoCantidad.Location = new System.Drawing.Point(484, 157);
            this.lblCopiaJuegoCantidad.Name = "lblCopiaJuegoCantidad";
            this.lblCopiaJuegoCantidad.Size = new System.Drawing.Size(168, 25);
            this.lblCopiaJuegoCantidad.TabIndex = 49;
            this.lblCopiaJuegoCantidad.Text = "Cantidad de copias:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(612, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNumeroCopias
            // 
            this.cmbNumeroCopias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumeroCopias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroCopias.FormattingEnabled = true;
            this.cmbNumeroCopias.Location = new System.Drawing.Point(658, 154);
            this.cmbNumeroCopias.Name = "cmbNumeroCopias";
            this.cmbNumeroCopias.Size = new System.Drawing.Size(65, 33);
            this.cmbNumeroCopias.TabIndex = 52;
            // 
            // FrmCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNumeroCopias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCopiaJuegoCantidad);
            this.Controls.Add(this.cmbCopiaJuego);
            this.Controls.Add(this.lblSelectCopiaJuego);
            this.Controls.Add(this.lblCopiarJuego);
            this.Controls.Add(this.lblGananciaJuegoRes);
            this.Controls.Add(this.lblGananciaJuego);
            this.Controls.Add(this.lblCantidadCopiasRes);
            this.Controls.Add(this.lblCantidadCopias);
            this.Controls.Add(this.cmbJuego);
            this.Controls.Add(this.lblSelectJuego);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblGananciasRes);
            this.Controls.Add(this.lblGanancia);
            this.MinimumSize = new System.Drawing.Size(750, 406);
            this.Name = "FrmCopia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia de juegos";
            this.Controls.SetChildIndex(this.lblGanancia, 0);
            this.Controls.SetChildIndex(this.lblGananciasRes, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.lblSelectJuego, 0);
            this.Controls.SetChildIndex(this.cmbJuego, 0);
            this.Controls.SetChildIndex(this.lblCantidadCopias, 0);
            this.Controls.SetChildIndex(this.lblCantidadCopiasRes, 0);
            this.Controls.SetChildIndex(this.lblGananciaJuego, 0);
            this.Controls.SetChildIndex(this.lblGananciaJuegoRes, 0);
            this.Controls.SetChildIndex(this.lblCopiarJuego, 0);
            this.Controls.SetChildIndex(this.lblSelectCopiaJuego, 0);
            this.Controls.SetChildIndex(this.cmbCopiaJuego, 0);
            this.Controls.SetChildIndex(this.lblCopiaJuegoCantidad, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.cmbNumeroCopias, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGananciasRes;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSelectJuego;
        private System.Windows.Forms.ComboBox cmbJuego;
        private System.Windows.Forms.Label lblCantidadCopias;
        private System.Windows.Forms.Label lblCantidadCopiasRes;
        private System.Windows.Forms.Label lblGananciaJuego;
        private System.Windows.Forms.Label lblGananciaJuegoRes;
        private System.Windows.Forms.Label lblCopiarJuego;
        private System.Windows.Forms.ComboBox cmbCopiaJuego;
        private System.Windows.Forms.Label lblSelectCopiaJuego;
        private System.Windows.Forms.Label lblCopiaJuegoCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbNumeroCopias;
    }
}