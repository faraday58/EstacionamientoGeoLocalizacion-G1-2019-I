namespace ControlEstacionamiento
{
    partial class MonitorTemperatura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtTiempoTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tiempoTemperatura = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chtTiempoTemperatura)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtTiempoTemperatura
            // 
            chartArea5.AxisX.Title = "Tiempo";
            chartArea5.AxisY.Title = "Temperatura";
            chartArea5.Name = "ChartArea1";
            this.chtTiempoTemperatura.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtTiempoTemperatura.Legends.Add(legend5);
            this.chtTiempoTemperatura.Location = new System.Drawing.Point(76, 43);
            this.chtTiempoTemperatura.Name = "chtTiempoTemperatura";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "serieTiempoTemp";
            this.chtTiempoTemperatura.Series.Add(series5);
            this.chtTiempoTemperatura.Size = new System.Drawing.Size(492, 210);
            this.chtTiempoTemperatura.TabIndex = 0;
            this.chtTiempoTemperatura.Text = "chart1";
            // 
            // tiempoTemperatura
            // 
            this.tiempoTemperatura.Interval = 1000;
            this.tiempoTemperatura.Tick += new System.EventHandler(this.tiempoTemperatura_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.monitorToolStripMenuItem.Text = "Monitor";
            // 
            // graficarToolStripMenuItem
            // 
            this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
            this.graficarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graficarToolStripMenuItem.Text = "Graficar";
            this.graficarToolStripMenuItem.Click += new System.EventHandler(this.graficarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // MonitorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 279);
            this.Controls.Add(this.chtTiempoTemperatura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MonitorTemperatura";
            this.Text = "MonitorTemperatura";
            ((System.ComponentModel.ISupportInitialize)(this.chtTiempoTemperatura)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtTiempoTemperatura;
        private System.Windows.Forms.Timer tiempoTemperatura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
    }
}