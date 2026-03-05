using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmMateria : Form
    {
        Datos dt=new Datos();
        int id = 0;
        bool update = false;
        public frmMateria()
        {
            InitializeComponent();
        }

        public frmMateria(int id, string materia, string clave, int creditos)
        {
            this.id = id;
            InitializeComponent();
            txtMateria.Text = materia;
            txtClave.Text = clave;
            txtCreditos.Text = creditos.ToString();
            update = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!update)
            {
                bool resultado = dt.ejecutarComando($"INSERT INTO Materias (Materias, cveMateria, Creditos)" +
            $" VALUES ('{txtMateria.Text}','{txtClave.Text}','{txtCreditos.Text}')");
                if (resultado)
                {
                    MessageBox.Show("Materia agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            else
            {
                bool resultado = dt.ejecutarComando($"UPDATE Materias SET Materias='{txtMateria.Text}', cveMateria='{txtClave.Text}', Creditos='{txtCreditos.Text}' WHERE idMaterias={id}");
                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }   
                else
                    MessageBox.Show("Error al actualizar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
