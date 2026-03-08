using WinMySQL.Views;

namespace WinMySQLL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias materia = new frmMaterias();
            materia.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumno = new frmAlumnos();
            alumno.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocentes docente = new frmDocentes();
            docente.ShowDialog();
        }
    }
}
