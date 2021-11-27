
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopiasMenu = new System.Windows.Forms.Button();
            this.btnEstadisticasMenu = new System.Windows.Forms.Button();
            this.btnClientesMenu = new System.Windows.Forms.Button();
            this.btnDispositivosMenu = new System.Windows.Forms.Button();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMenu.ColumnCount = 2;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.375F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.625F));
            this.tlpMenu.Controls.Add(this.btnCopiasMenu, 1, 1);
            this.tlpMenu.Controls.Add(this.btnEstadisticasMenu, 0, 1);
            this.tlpMenu.Controls.Add(this.btnClientesMenu, 1, 0);
            this.tlpMenu.Controls.Add(this.btnDispositivosMenu, 0, 0);
            this.tlpMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpMenu.Location = new System.Drawing.Point(2, 3);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 2;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Size = new System.Drawing.Size(800, 400);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnCopiasMenu
            // 
            this.btnCopiasMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopiasMenu.Location = new System.Drawing.Point(406, 203);
            this.btnCopiasMenu.Name = "btnCopiasMenu";
            this.btnCopiasMenu.Size = new System.Drawing.Size(391, 194);
            this.btnCopiasMenu.TabIndex = 3;
            this.btnCopiasMenu.Text = "Copias";
            this.btnCopiasMenu.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticasMenu
            // 
            this.btnEstadisticasMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadisticasMenu.Location = new System.Drawing.Point(3, 203);
            this.btnEstadisticasMenu.Name = "btnEstadisticasMenu";
            this.btnEstadisticasMenu.Size = new System.Drawing.Size(397, 194);
            this.btnEstadisticasMenu.TabIndex = 2;
            this.btnEstadisticasMenu.Text = "Estadisticas";
            this.btnEstadisticasMenu.UseVisualStyleBackColor = true;
            this.btnEstadisticasMenu.Click += new System.EventHandler(this.btnEstadisticasMenu_Click);
            // 
            // btnClientesMenu
            // 
            this.btnClientesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientesMenu.Location = new System.Drawing.Point(406, 3);
            this.btnClientesMenu.Name = "btnClientesMenu";
            this.btnClientesMenu.Size = new System.Drawing.Size(391, 194);
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
            this.btnDispositivosMenu.Size = new System.Drawing.Size(397, 194);
            this.btnDispositivosMenu.TabIndex = 0;
            this.btnDispositivosMenu.Text = "Dispositivos";
            this.btnDispositivosMenu.UseVisualStyleBackColor = true;
            this.btnDispositivosMenu.Click += new System.EventHandler(this.btnDispositivosMenu_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMenu);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciber Cafe Menu";
            this.Controls.SetChildIndex(this.tlpMenu, 0);
            this.tlpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnCopiasMenu;
        private System.Windows.Forms.Button btnEstadisticasMenu;
        private System.Windows.Forms.Button btnClientesMenu;
        private System.Windows.Forms.Button btnDispositivosMenu;
    }
}