using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmMaterias : Form
    {
        Datos datos = new Datos();
        DataSet ds = new DataSet();

        public frmMaterias()
        {
            InitializeComponent();
        }


        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            /*  try
              {
                  ds = datos.ejecutar("SELECT * FROM Materias");
                  if (ds != null)
                  {
                      dgvMaterias.DataSource = ds.Tables[0];
                  }
                  else
                  {
                      MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              } */
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            frmMateria frmMateria = new frmMateria();
            frmMateria.ShowDialog();
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           frmMateria frmMateria = new frmMateria(
               Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
               dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                dgvMaterias.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToInt32(dgvMaterias.CurrentRow.Cells[3].Value)
                );
            frmMateria.ShowDialog();
        }
    }
}
