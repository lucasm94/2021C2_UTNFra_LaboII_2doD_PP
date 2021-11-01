
namespace CIber
{
    partial class FrmMenu
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
            this.spcMenu = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopiasMenu = new System.Windows.Forms.Button();
            this.btnEstadisticasMenu = new System.Windows.Forms.Button();
            this.btnClientesMenu = new System.Windows.Forms.Button();
            this.btnDispositivosMenu = new System.Windows.Forms.Button();
            this.lblMenuUsuario = new System.Windows.Forms.Label();
            this.lblMenuFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMenu)).BeginInit();
            this.spcMenu.Panel1.SuspendLayout();
            this.spcMenu.Panel2.SuspendLayout();
            this.spcMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMenu
            // 
            this.spcMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.spcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMenu.IsSplitterFixed = true;
            this.spcMenu.Location = new System.Drawing.Point(0, 0);
            this.spcMenu.Name = "spcMenu";
            this.spcMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMenu.Panel1
            // 
            this.spcMenu.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // spcMenu.Panel2
            // 
            this.spcMenu.Panel2.Controls.Add(this.lblMenuUsuario);
            this.spcMenu.Panel2.Controls.Add(this.lblMenuFecha);
            this.spcMenu.Size = new System.Drawing.Size(800, 450);
            this.spcMenu.SplitterDistance = 409;
            this.spcMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopiasMenu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadisticasMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClientesMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDispositivosMenu, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCopiasMenu
            // 
            this.btnCopiasMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopiasMenu.Location = new System.Drawing.Point(403, 207);
            this.btnCopiasMenu.Name = "btnCopiasMenu";
            this.btnCopiasMenu.Size = new System.Drawing.Size(394, 199);
            this.btnCopiasMenu.TabIndex = 3;
            this.btnCopiasMenu.Text = "Copias";
            this.btnCopiasMenu.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticasMenu
            // 
            this.btnEstadisticasMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadisticasMenu.Location = new System.Drawing.Point(3, 207);
            this.btnEstadisticasMenu.Name = "btnEstadisticasMenu";
            this.btnEstadisticasMenu.Size = new System.Drawing.Size(394, 199);
            this.btnEstadisticasMenu.TabIndex = 2;
            this.btnEstadisticasMenu.Text = "Estadisticas";
            this.btnEstadisticasMenu.UseVisualStyleBackColor = true;
            // 
            // btnClientesMenu
            // 
            this.btnClientesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientesMenu.Location = new System.Drawing.Point(403, 3);
            this.btnClientesMenu.Name = "btnClientesMenu";
            this.btnClientesMenu.Size = new System.Drawing.Size(394, 198);
            this.btnClientesMenu.TabIndex = 1;
            this.btnClientesMenu.Text = "Clientes";
            this.btnClientesMenu.UseVisualStyleBackColor = true;
            this.btnClientesMenu.Click += new System.EventHandler(this.btnClientesMenu_Click);
            // 
            // btnDispositivosMenu
            // 
            this.btnDispositivosMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDispositivosMenu.Location = new System.Drawing.Point(3, 3);
            this.btnDispositivosMenu.Name = "btnDispositivosMenu";
            this.btnDispositivosMenu.Size = new System.Drawing.Size(394, 198);
            this.btnDispositivosMenu.TabIndex = 0;
            this.btnDispositivosMenu.Text = "Dispositivos";
            this.btnDispositivosMenu.UseVisualStyleBackColor = true;
            this.btnDispositivosMenu.Click += new System.EventHandler(this.btnDispositivosMenu_Click);
            // 
            // lblMenuUsuario
            // 
            this.lblMenuUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuUsuario.AutoSize = true;
            this.lblMenuUsuario.Location = new System.Drawing.Point(552, 6);
            this.lblMenuUsuario.Name = "lblMenuUsuario";
            this.lblMenuUsuario.Size = new System.Drawing.Size(126, 25);
            this.lblMenuUsuario.TabIndex = 5;
            this.lblMenuUsuario.Text = "Lucas Monzon";
            // 
            // lblMenuFecha
            // 
            this.lblMenuFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuFecha.AutoSize = true;
            this.lblMenuFecha.Location = new System.Drawing.Point(684, 6);
            this.lblMenuFecha.Name = "lblMenuFecha";
            this.lblMenuFecha.Size = new System.Drawing.Size(106, 25);
            this.lblMenuFecha.TabIndex = 4;
            this.lblMenuFecha.Text = "26/10/2021";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spcMenu);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciber Cafe Menu";
            this.spcMenu.Panel1.ResumeLayout(false);
            this.spcMenu.Panel2.ResumeLayout(false);
            this.spcMenu.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMenu)).EndInit();
            this.spcMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMenu;
        private System.Windows.Forms.Label lblMenuUsuario;
        private System.Windows.Forms.Label lblMenuFecha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCopiasMenu;
        private System.Windows.Forms.Button btnEstadisticasMenu;
        private System.Windows.Forms.Button btnClientesMenu;
        private System.Windows.Forms.Button btnDispositivosMenu;
    }
}