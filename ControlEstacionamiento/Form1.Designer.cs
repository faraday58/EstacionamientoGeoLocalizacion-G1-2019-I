namespace ControlEstacionamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbCroquis = new System.Windows.Forms.PictureBox();
            this.dgvDatosVehículo = new System.Windows.Forms.DataGridView();
            this.columnaplacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnahoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnahorasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerEstacionamiento = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCroquis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVehículo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCroquis
            // 
            this.ptbCroquis.Location = new System.Drawing.Point(33, 54);
            this.ptbCroquis.Name = "ptbCroquis";
            this.ptbCroquis.Size = new System.Drawing.Size(322, 255);
            this.ptbCroquis.TabIndex = 0;
            this.ptbCroquis.TabStop = false;
            // 
            // dgvDatosVehículo
            // 
            this.dgvDatosVehículo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVehículo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaplacas,
            this.columnahoraIngreso,
            this.columnahorasalida,
            this.columnaDetalles,
            this.columnaCajon});
            this.dgvDatosVehículo.Location = new System.Drawing.Point(378, 54);
            this.dgvDatosVehículo.Name = "dgvDatosVehículo";
            this.dgvDatosVehículo.Size = new System.Drawing.Size(531, 255);
            this.dgvDatosVehículo.TabIndex = 1;
            this.dgvDatosVehículo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVehículo_CellDoubleClick);
            // 
            // columnaplacas
            // 
            this.columnaplacas.Frozen = true;
            this.columnaplacas.HeaderText = "Placas";
            this.columnaplacas.Name = "columnaplacas";
            this.columnaplacas.ReadOnly = true;
            // 
            // columnahoraIngreso
            // 
            this.columnahoraIngreso.Frozen = true;
            this.columnahoraIngreso.HeaderText = "Ingreso";
            this.columnahoraIngreso.Name = "columnahoraIngreso";
            this.columnahoraIngreso.ReadOnly = true;
            // 
            // columnahorasalida
            // 
            this.columnahorasalida.Frozen = true;
            this.columnahorasalida.HeaderText = "HoraSalida";
            this.columnahorasalida.Name = "columnahorasalida";
            this.columnahorasalida.ReadOnly = true;
            // 
            // columnaDetalles
            // 
            this.columnaDetalles.Frozen = true;
            this.columnaDetalles.HeaderText = "Detalles";
            this.columnaDetalles.Name = "columnaDetalles";
            this.columnaDetalles.ReadOnly = true;
            // 
            // columnaCajon
            // 
            this.columnaCajon.Frozen = true;
            this.columnaCajon.HeaderText = "Cajon";
            this.columnaCajon.Name = "columnaCajon";
            this.columnaCajon.ReadOnly = true;
            // 
            // timerEstacionamiento
            // 
            this.timerEstacionamiento.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 349);
            this.Controls.Add(this.dgvDatosVehículo);
            this.Controls.Add(this.ptbCroquis);
            this.Name = "Form1";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCroquis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVehículo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCroquis;
        private System.Windows.Forms.DataGridView dgvDatosVehículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaplacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnahoraIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnahorasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCajon;
        private System.Windows.Forms.Timer timerEstacionamiento;
    }
}

