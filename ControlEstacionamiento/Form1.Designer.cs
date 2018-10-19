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
            this.lb_timer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCroquis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVehículo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // 
            // columnahoraIngreso
            // 
            this.columnahoraIngreso.Frozen = true;
            this.columnahoraIngreso.HeaderText = "Ingreso";
            this.columnahoraIngreso.Name = "columnahoraIngreso";
            // 
            // columnahorasalida
            // 
            this.columnahorasalida.Frozen = true;
            this.columnahorasalida.HeaderText = "HoraSalida";
            this.columnahorasalida.Name = "columnahorasalida";
            // 
            // columnaDetalles
            // 
            this.columnaDetalles.Frozen = true;
            this.columnaDetalles.HeaderText = "Detalles";
            this.columnaDetalles.Name = "columnaDetalles";
            // 
            // columnaCajon
            // 
            this.columnaCajon.Frozen = true;
            this.columnaCajon.HeaderText = "Cajon";
            this.columnaCajon.Name = "columnaCajon";
            // 
            // timerEstacionamiento
            // 
            this.timerEstacionamiento.Interval = 1000;
            this.timerEstacionamiento.Tick += new System.EventHandler(this.timerEstacionamiento_Tick);
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Location = new System.Drawing.Point(495, 17);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(35, 13);
            this.lb_timer.TabIndex = 2;
            this.lb_timer.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 349);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.dgvDatosVehículo);
            this.Controls.Add(this.ptbCroquis);
            this.Name = "Form1";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCroquis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVehículo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCroquis;
        private System.Windows.Forms.DataGridView dgvDatosVehículo;
        private System.Windows.Forms.Timer timerEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaplacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnahoraIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnahorasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCajon;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

