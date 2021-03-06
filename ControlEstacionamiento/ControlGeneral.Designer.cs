﻿namespace ControlEstacionamiento
{
    partial class ControlGeneral
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmbVelocidad = new System.Windows.Forms.ToolStripComboBox();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmbpuertos = new System.Windows.Forms.ToolStripComboBox();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encenderLuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.conexiónToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.velocidadToolStripMenuItem,
            this.puertosToolStripMenuItem,
            this.verificarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.conectarToolStripMenuItem,
            this.cerrarPuertoToolStripMenuItem});
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            // 
            // velocidadToolStripMenuItem
            // 
            this.velocidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbVelocidad});
            this.velocidadToolStripMenuItem.Name = "velocidadToolStripMenuItem";
            this.velocidadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.velocidadToolStripMenuItem.Text = "Velocidad";
            // 
            // tscmbVelocidad
            // 
            this.tscmbVelocidad.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.tscmbVelocidad.Name = "tscmbVelocidad";
            this.tscmbVelocidad.Size = new System.Drawing.Size(121, 23);
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbpuertos});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.puertosToolStripMenuItem.Text = "Puertos";
            // 
            // tscmbpuertos
            // 
            this.tscmbpuertos.Name = "tscmbpuertos";
            this.tscmbpuertos.Size = new System.Drawing.Size(121, 23);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.verificarToolStripMenuItem.Text = "Verificar";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.verificarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // cerrarPuertoToolStripMenuItem
            // 
            this.cerrarPuertoToolStripMenuItem.Name = "cerrarPuertoToolStripMenuItem";
            this.cerrarPuertoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cerrarPuertoToolStripMenuItem.Text = "Cerrar Puerto";
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encenderLuzToolStripMenuItem,
            this.monitorTemperaturaToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // encenderLuzToolStripMenuItem
            // 
            this.encenderLuzToolStripMenuItem.Name = "encenderLuzToolStripMenuItem";
            this.encenderLuzToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.encenderLuzToolStripMenuItem.Text = "Encender Luz";
            this.encenderLuzToolStripMenuItem.Click += new System.EventHandler(this.encenderLuzToolStripMenuItem_Click);
            // 
            // monitorTemperaturaToolStripMenuItem
            // 
            this.monitorTemperaturaToolStripMenuItem.Name = "monitorTemperaturaToolStripMenuItem";
            this.monitorTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.monitorTemperaturaToolStripMenuItem.Text = "Monitor Temperatura";
            this.monitorTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.monitorTemperaturaToolStripMenuItem_Click);
            // 
            // ControlGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 278);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlGeneral";
            this.Text = "ControlGeneral";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscmbVelocidad;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscmbpuertos;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarPuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encenderLuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorTemperaturaToolStripMenuItem;
    }
}