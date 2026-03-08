using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmDocentes : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();

        public frmDocentes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Docentes");
                if (ds != null)
                    dgvDocentes.DataSource = ds.Tables[0];
                else
                    MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDocentes_Activated(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDocente frm = new frmDocente();
            frm.ShowDialog();
        }

        private void dgvDocentes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocentes.CurrentRow == null) return;
            frmDocente frm = new frmDocente(
                Convert.ToInt32(dgvDocentes.CurrentRow.Cells[0].Value),
                Convert.ToInt32(dgvDocentes.CurrentRow.Cells[1].Value),
                dgvDocentes.CurrentRow.Cells[2].Value.ToString(),
                dgvDocentes.CurrentRow.Cells[3].Value.ToString(),
                dgvDocentes.CurrentRow.Cells[4].Value.ToString()
            );
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDocentes.CurrentRow == null) return;
                int idDocente = Convert.ToInt32(dgvDocentes.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿Está seguro de eliminar este docente?", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool resultado = datos.ejecutarComando($"DELETE FROM Docentes WHERE idDocentes={idDocente}");
                    if (resultado)
                        MessageBox.Show("Docente eliminado correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al eliminar el docente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el docente: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
