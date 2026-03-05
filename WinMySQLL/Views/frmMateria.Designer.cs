namespace WinMySQL.Views
{
    partial class frmMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMateria = new TextBox();
            txtClave = new TextBox();
            label2 = new Label();
            btnAceptar = new Button();
            label3 = new Label();
            txtCreditos = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(36, 27);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(354, 23);
            txtMateria.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(36, 90);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(92, 23);
            txtClave.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 72);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "CVE Oficial";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(315, 89);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 69);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Creditos";
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(171, 89);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(92, 23);
            txtCreditos.TabIndex = 6;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 153);
            Controls.Add(txtCreditos);
            Controls.Add(label3);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(txtMateria);
            Controls.Add(label1);
            Name = "frmMateria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMateria;
        private TextBox txtClave;
        private Label label2;
        private Button btnAceptar;
        private Label label3;
        private TextBox txtCreditos;
    }
}