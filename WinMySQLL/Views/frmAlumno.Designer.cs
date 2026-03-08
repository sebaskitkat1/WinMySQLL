namespace WinMySQL.Views
{
    partial class frmAlumno
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
            lblNoControl = new Label();
            txtNoControl = new TextBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApPat = new Label();
            txtApPat = new TextBox();
            lblApMat = new Label();
            txtApMat = new TextBox();
            lblSemestre = new Label();
            txtSemestre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNoControl
            // 
            lblNoControl.AutoSize = true;
            lblNoControl.Location = new Point(30, 15);
            lblNoControl.Name = "lblNoControl";
            lblNoControl.Size = new Size(70, 15);
            lblNoControl.TabIndex = 0;
            lblNoControl.Text = "No. Control";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(30, 33);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(120, 23);
            txtNoControl.TabIndex = 1;
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
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Location = new Point(30, 180);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(57, 15);
            lblSemestre.TabIndex = 8;
            lblSemestre.Text = "Semestre";
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(30, 198);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(80, 23);
            txtSemestre.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(225, 195);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 26);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(305, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 245);
            Controls.Add(lblNoControl);
            Controls.Add(txtNoControl);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(lblApPat);
            Controls.Add(txtApPat);
            Controls.Add(lblApMat);
            Controls.Add(txtApMat);
            Controls.Add(lblSemestre);
            Controls.Add(txtSemestre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoControl;
        private TextBox txtNoControl;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApPat;
        private TextBox txtApPat;
        private Label lblApMat;
        private TextBox txtApMat;
        private Label lblSemestre;
        private TextBox txtSemestre;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
