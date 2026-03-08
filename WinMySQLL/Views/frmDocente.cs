using System;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmDocente : Form
    {
        Datos dt = new Datos();
        int id = 0;
        bool update = false;

        public frmDocente()
        {
            InitializeComponent();
        }

        public frmDocente(int id, int cedula, string nombres, string apPat, string apMat)
        {
            this.id = id;
            InitializeComponent();
            txtCedula.Text = cedula.ToString();
            txtNombres.Text = nombres;
            txtApPat.Text = apPat;
            txtApMat.Text = apMat;
            update = true;
            this.Text = "Editar Docente";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApPat.Text) ||
                string.IsNullOrWhiteSpace(txtApMat.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!update)
            {
                bool resultado = dt.ejecutarComando(
                    $"INSERT INTO Docentes (cedula, nombres, apPat, apMat) " +
                    $"VALUES ({txtCedula.Text}, '{txtNombres.Text}', '{txtApPat.Text}', '{txtApMat.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Docente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar el docente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"UPDATE Docentes SET cedula={txtCedula.Text}, nombres='{txtNombres.Text}', " +
                    $"apPat='{txtApPat.Text}', apMat='{txtApMat.Text}' " +
                    $"WHERE idDocentes={id}");
                if (resultado)
                {
                    MessageBox.Show("Docente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar el docente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
