using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TaskDB
{
    public partial class FrmAgregarTarea : Form
    {
        public FrmAgregarTarea()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            // RNF2.1: el título es obligatorio; sin él no se envía nada a la base de datos.
            if (titulo.Length == 0)
            {
                MessageBox.Show("El título de la tarea es obligatorio.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return;
            }

            // RNF2.2: los valores viajan como parámetros (@Titulo, ...) y nunca se
            // concatenan al texto SQL, así lo que escriba el usuario no se ejecuta como código.
            const string sql =
                "INSERT INTO Tareas (Titulo, Descripcion, Estado, FechaCreacion) " +
                "VALUES (@Titulo, @Descripcion, @Estado, @FechaCreacion)";

            try
            {
                using (SqlConnection conexion = DatabaseConnection.GetConnection())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add("@Titulo", SqlDbType.NVarChar, 100).Value = titulo;
                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 500).Value =
                        descripcion.Length == 0 ? (object)DBNull.Value : descripcion;
                    comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = "Pendiente";
                    comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("La tarea se guardó correctamente.", "TaskDB",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo guardar la tarea.\n\n" + ex.Message, "Error de base de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
