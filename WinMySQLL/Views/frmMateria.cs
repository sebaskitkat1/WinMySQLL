using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmMateria : Form
    {
        Datos dt=new Datos();
        public frmMateria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool resultado = dt.ejecutarComando($"INSERT INTO Materias (Materia, cveOficial, Creditos)" +
                $" VALUES ('{txtMateria.Text}','{txtClave.Text}','{txtCreditos.Text})");
            if (resultado)
            {
                MessageBox.Show("Materia agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al agregar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
