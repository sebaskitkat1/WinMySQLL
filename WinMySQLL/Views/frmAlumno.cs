using System;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmAlumno : Form
    {
        Datos dt = new Datos();
        int id = 0;
        bool update = false;

        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int id, int noControl, string nombres, string apPat, string apMat, int semestre)
        {
            this.id = id;
            InitializeComponent();
            txtNoControl.Text = noControl.ToString();
            txtNombres.Text = nombres;
            txtApPat.Text = apPat;
            txtApMat.Text = apMat;
            txtSemestre.Text = semestre.ToString();
            update = true;
            this.Text = "Editar Alumno";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoControl.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApPat.Text) ||
                string.IsNullOrWhiteSpace(txtApMat.Text) ||
                string.IsNullOrWhiteSpace(txtSemestre.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!update)
            {
                bool resultado = dt.ejecutarComando(
                    $"INSERT INTO Alumnos (noControl, nombres, apPat, apMat, semestre) " +
                    $"VALUES ({txtNoControl.Text}, '{txtNombres.Text}', '{txtApPat.Text}', '{txtApMat.Text}', {txtSemestre.Text})");
                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"UPDATE Alumnos SET noControl={txtNoControl.Text}, nombres='{txtNombres.Text}', " +
                    $"apPat='{txtApPat.Text}', apMat='{txtApMat.Text}', semestre={txtSemestre.Text} " +
                    $"WHERE idAlumnos={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al actualizar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
