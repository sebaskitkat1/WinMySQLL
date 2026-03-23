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
    public partial class frmReport : Form
    {
        Datos datos=new Datos();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar("SELECT * FROM alumnos");
            bindingSource1.DataSource = ds.Tables[0];
        }
    }
}
