namespace proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            btnInicio = new Button();
            lblContraseña = new Label();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(184, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(139, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre de Usuario";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            lblNombre.Click += label1_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(162, 274);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(131, 34);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(184, 165);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.TextAlign = ContentAlignment.TopCenter;
            lblContraseña.Click += label1_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(348, 274);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(329, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(329, 165);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(195, 27);
            txtContraseña.TabIndex = 5;
            txtContraseña.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(lblContraseña);
            Controls.Add(btnInicio);
            Controls.Add(lblNombre);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button btnInicio;
        private Label lblContraseña;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtContraseña;
    }
}
