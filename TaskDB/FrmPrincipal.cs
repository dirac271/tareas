using System;
using System.Windows.Forms;

namespace TaskDB
{
    /// <summary>
    /// Ventana principal: desde aquí se navega al listado y al registro de tareas (RNF4.1).
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Lo comparten el botón y la opción de menú Tareas > Listado de tareas.
        private void btnListado_Click(object sender, EventArgs e)
        {
            using (FrmListadoTareas formulario = new FrmListadoTareas())
            {
                formulario.ShowDialog(this);
            }
        }

        // Lo comparten el botón y la opción de menú Tareas > Nueva tarea.
        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            using (FrmAgregarTarea formulario = new FrmAgregarTarea())
            {
                formulario.ShowDialog(this);
            }
        }

        // Lo comparten el botón y la opción de menú Archivo > Salir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
