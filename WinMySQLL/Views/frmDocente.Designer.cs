namespace WinMySQL.Views
{
    partial class frmDocente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApPat = new Label();
            txtApPat = new TextBox();
            lblApMat = new Label();
            txtApMat = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(30, 15);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(30, 33);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(120, 23);
            txtCedula.TabIndex = 1;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(30, 70);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 2;
            lblNombres.Text = "Nombre(s)";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(30, 88);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(350, 23);
            txtNombres.TabIndex = 3;
            // 
            // lblApPat
            // 
            lblApPat.AutoSize = true;
            lblApPat.Location = new Point(30, 125);
            lblApPat.Name = "lblApPat";
            lblApPat.Size = new Size(92, 15);
            lblApPat.TabIndex = 4;
            lblApPat.Text = "Apellido Paterno";
            // 
            // txtApPat
            // 
            txtApPat.Location = new Point(30, 143);
            txtApPat.Name = "txtApPat";
            txtApPat.Size = new Size(165, 23);
            txtApPat.TabIndex = 5;
            // 
            // lblApMat
            // 
            lblApMat.AutoSize = true;
            lblApMat.Location = new Point(215, 125);
            lblApMat.Name = "lblApMat";
            lblApMat.Size = new Size(95, 15);
            lblApMat.TabIndex = 6;
            lblApMat.Text = "Apellido Materno";
            // 
            // txtApMat
            // 
            txtApMat.Location = new Point(215, 143);
            txtApMat.Name = "txtApMat";
            txtApMat.Size = new Size(165, 23);
            txtApMat.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(225, 190);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 26);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(305, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 235);
            Controls.Add(lblCedula);
            Controls.Add(txtCedula);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(lblApPat);
            Controls.Add(txtApPat);
            Controls.Add(lblApMat);
            Controls.Add(txtApMat);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDocente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Docente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApPat;
        private TextBox txtApPat;
        private Label lblApMat;
        private TextBox txtApMat;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
