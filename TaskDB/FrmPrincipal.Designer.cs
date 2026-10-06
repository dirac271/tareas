namespace TaskDB
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaTarea = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblBaseDatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            //
            // menuPrincipal
            //
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuTareas});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(444, 24);
            this.menuPrincipal.TabIndex = 0;
            //
            // mnuArchivo
            //
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "&Archivo";
            //
            // mnuSalir
            //
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // mnuTareas
            //
            this.mnuTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuListado,
            this.mnuNuevaTarea});
            this.mnuTareas.Name = "mnuTareas";
            this.mnuTareas.Size = new System.Drawing.Size(51, 20);
            this.mnuTareas.Text = "&Tareas";
            //
            // mnuListado
            //
            this.mnuListado.Name = "mnuListado";
            this.mnuListado.Size = new System.Drawing.Size(163, 22);
            this.mnuListado.Text = "&Listado de tareas";
            this.mnuListado.Click += new System.EventHandler(this.btnListado_Click);
            //
            // mnuNuevaTarea
            //
            this.mnuNuevaTarea.Name = "mnuNuevaTarea";
            this.mnuNuevaTarea.Size = new System.Drawing.Size(163, 22);
            this.mnuNuevaTarea.Text = "&Nueva tarea";
            this.mnuNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(21, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TaskDB";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 84);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(160, 15);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Sistema de gestión de tareas";
            //
            // btnListado
            //
            this.btnListado.Location = new System.Drawing.Point(28, 122);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(388, 40);
            this.btnListado.TabIndex = 3;
            this.btnListado.Text = "Listado de tareas";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            //
            // btnNuevaTarea
            //
            this.btnNuevaTarea.Location = new System.Drawing.Point(28, 170);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(388, 40);
            this.btnNuevaTarea.TabIndex = 4;
            this.btnNuevaTarea.Text = "Nueva tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = true;
            this.btnNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(28, 218);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(388, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // barraEstado
            //
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBaseDatos});
            this.barraEstado.Location = new System.Drawing.Point(0, 278);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(444, 22);
            this.barraEstado.SizingGrip = false;
            this.barraEstado.TabIndex = 6;
            //
            // lblBaseDatos
            //
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(262, 17);
            this.lblBaseDatos.Text = "Base de datos: TaskDB.mdf (SQL Server LocalDB)";
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevaTarea);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskDB - Gestión de Tareas";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuTareas;
        private System.Windows.Forms.ToolStripMenuItem mnuListado;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaTarea;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblBaseDatos;
    }
}
