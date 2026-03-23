using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
using OfficeOpenXml;
using WinMySQL.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinMySQL.Views
{
    public partial class frmAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Alumnos");
                if (ds != null)
                    dgvAlumnos.DataSource = ds.Tables[0];
                else
                    MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAlumnos_Activated(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            frm.ShowDialog();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null) return;
            frmAlumno frm = new frmAlumno(
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[1].Value),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[4].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value)
            );
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null) return;
                int idAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿Está seguro de eliminar este alumno?", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool resultado = datos.ejecutarComando($"DELETE FROM Alumnos WHERE idAlumnos={idAlumno}");
                    if (resultado)
                        MessageBox.Show("Alumno eliminado correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al eliminar el alumno.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el alumno: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            System.String path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Sebastian Gonzalez");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    DataTable dataTable = new DataTable();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            dataRow[col - 1] = worksheet.Cells[row, col].Value;
                        }
                        dataTable.Rows.Add(dataRow);
                       bool ok=datos.ejecutarComando(
                            $"INSERT INTO Alumnos (noControl, nombres, apPat, apMat, semestre) " +
                            $"VALUES ({dataRow[0]}, '{dataRow[1]}', '{dataRow[2]}', '{dataRow[3]}', {dataRow[4]})");
                        if (!ok)
                        {
                            MessageBox.Show($"Error al importar el alumno con No. Control: {dataRow[0]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
    }
}
