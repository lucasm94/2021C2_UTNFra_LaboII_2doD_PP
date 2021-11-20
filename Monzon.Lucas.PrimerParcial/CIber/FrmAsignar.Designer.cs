
namespace CIber
{
    partial class FrmAsignar
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
            this.spcAsignar = new System.Windows.Forms.SplitContainer();
            this.rtbCliente = new System.Windows.Forms.RichTextBox();
            this.dgvComputadoras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spcAsignar)).BeginInit();
            this.spcAsignar.Panel1.SuspendLayout();
            this.spcAsignar.Panel2.SuspendLayout();
            this.spcAsignar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // spcAsignar
            // 
            this.spcAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcAsignar.Cursor = System.Windows.Forms.Cursors.Default;
            this.spcAsignar.IsSplitterFixed = true;
            this.spcAsignar.Location = new System.Drawing.Point(12, 3);
            this.spcAsignar.Name = "spcAsignar";
            // 
            // spcAsignar.Panel1
            // 
            this.spcAsignar.Panel1.Controls.Add(this.rtbCliente);
            // 
            // spcAsignar.Panel2
            // 
            this.spcAsignar.Panel2.Controls.Add(this.dgvComputadoras);
            this.spcAsignar.Size = new System.Drawing.Size(815, 409);
            this.spcAsignar.SplitterDistance = 270;
            this.spcAsignar.TabIndex = 2;
            // 
            // rtbCliente
            // 
            this.rtbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCliente.Location = new System.Drawing.Point(0, 0);
            this.rtbCliente.Name = "rtbCliente";
            this.rtbCliente.Size = new System.Drawing.Size(270, 409);
            this.rtbCliente.TabIndex = 0;
            this.rtbCliente.Text = "";
            // 
            // dgvComputadoras
            // 
            this.dgvComputadoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComputadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputadoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComputadoras.Location = new System.Drawing.Point(0, 0);
            this.dgvComputadoras.MultiSelect = false;
            this.dgvComputadoras.Name = "dgvComputadoras";
            this.dgvComputadoras.RowHeadersVisible = false;
            this.dgvComputadoras.RowHeadersWidth = 62;
            this.dgvComputadoras.RowTemplate.Height = 33;
            this.dgvComputadoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputadoras.Size = new System.Drawing.Size(541, 409);
            this.dgvComputadoras.TabIndex = 0;
            // 
            // FrmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.spcAsignar);
            this.Name = "FrmAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciber Cafe - Asignar";
            this.Controls.SetChildIndex(this.spcAsignar, 0);
            this.spcAsignar.Panel1.ResumeLayout(false);
            this.spcAsignar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcAsignar)).EndInit();
            this.spcAsignar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputadoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcAsignar;
        private System.Windows.Forms.DataGridView dgvComputadoras;
        private System.Windows.Forms.RichTextBox rtbCliente;
    }
}