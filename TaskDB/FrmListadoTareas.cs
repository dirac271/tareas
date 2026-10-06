using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TaskDB
{
    public partial class FrmListadoTareas : Form
    {
        public FrmListadoTareas()
        {
            InitializeComponent();
        }

        private void FrmListadoTareas_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0; // "Todas"
            CargarTareas();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTareas();
        }

        // Abre el formulario de registro y, si se guardó una tarea, recarga la grilla.
        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            using (FrmAgregarTarea formulario = new FrmAgregarTarea())
            {
                if (formulario.ShowDialog(this) == DialogResult.OK)
                {
                    CargarTareas();
                }
            }
        }

        /// <summary>
        /// Consulta la tabla Tareas y muestra el resultado en la grilla (RF3.2),
        /// aplicando el estado elegido en el ComboBox (RF4.1).
        /// </summary>
        private void CargarTareas()
        {
            // "Todas" no filtra; "Pendiente" y "Completada" se comparan contra la columna Estado.
            string estado = Convert.ToString(cboEstado.SelectedItem);
            bool filtrar = estado == "Pendiente" || estado == "Completada";

            string sql = "SELECT Id, Titulo, Descripcion, Estado, FechaCreacion FROM Tareas";
            if (filtrar)
            {
                sql += " WHERE Estado = @Estado";
            }
            sql += " ORDER BY Id";

            try
            {
                DataTable tabla = new DataTable();

                using (SqlConnection conexion = DatabaseConnection.GetConnection())
                using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
                {
                    if (filtrar)
                    {
                        adaptador.SelectCommand.Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = estado;
                    }

                    // Fill abre y cierra la conexión por su cuenta.
                    adaptador.Fill(tabla);
                }

                dgvTareas.DataSource = tabla;
                ConfigurarColumnas();
                lblTotal.Text = tabla.Rows.Count == 1 ? "1 tarea" : tabla.Rows.Count + " tareas";
            }
            catch (SqlException ex)
            {
                // RNF3.2: un fallo de lectura no cierra la aplicación; se informa al usuario.
                MessageBox.Show("No se pudieron leer las tareas de la base de datos.\n\n" + ex.Message,
                    "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al cargar las tareas.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cambia a "Completada" la tarea seleccionada en la grilla (RF4.2).
        /// </summary>
        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tarea de la lista.", "TaskDB",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView fila = (DataRowView)dgvTareas.CurrentRow.DataBoundItem;
            int id = (int)fila["Id"];

            if ((string)fila["Estado"] == "Completada")
            {
                MessageBox.Show("La tarea seleccionada ya está completada.", "TaskDB",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            const string sql = "UPDATE Tareas SET Estado = @Estado WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = DatabaseConnection.GetConnection())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = "Completada";
                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }

                CargarTareas();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo actualizar la tarea.\n\n" + ex.Message, "Error de base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Encabezados legibles y proporción de cada columna (RNF3.1).
        /// </summary>
        private void ConfigurarColumnas()
        {
            dgvTareas.Columns["Id"].HeaderText = "ID";
            dgvTareas.Columns["Titulo"].HeaderText = "Título";
            dgvTareas.Columns["Descripcion"].HeaderText = "Descripción";
            dgvTareas.Columns["Estado"].HeaderText = "Estado";
            dgvTareas.Columns["FechaCreacion"].HeaderText = "Fecha Creación";

            // Con AutoSizeColumnsMode = Fill, FillWeight reparte el ancho disponible.
            dgvTareas.Columns["Id"].FillWeight = 8;
            dgvTareas.Columns["Titulo"].FillWeight = 34;
            dgvTareas.Columns["Descripcion"].FillWeight = 30;
            dgvTareas.Columns["Estado"].FillWeight = 14;
            dgvTareas.Columns["FechaCreacion"].FillWeight = 14;

            dgvTareas.Columns["FechaCreacion"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dgvTareas.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvTareas.Font, FontStyle.Bold);
        }

        // Pinta el estado en verde (Completada) o en naranja (Pendiente).
        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || dgvTareas.Columns[e.ColumnIndex].Name != "Estado")
            {
                return;
            }

            e.CellStyle.ForeColor = e.Value.ToString() == "Completada" ? Color.ForestGreen : Color.DarkOrange;
        }
    }
}
