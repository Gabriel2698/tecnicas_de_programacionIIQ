namespace Proyecto
{
    partial class Admin
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
            btnMostrar = new Button();
            btnVentas = new Button();
            btnMostrarE = new Button();
            btnMostrarC = new Button();
            btnMostrarM = new Button();
            btnCerrar = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(-1, 12);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(185, 41);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Usuarios";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(603, 159);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(185, 41);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Mostrar Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMostrarE
            // 
            btnMostrarE.Location = new Point(190, 12);
            btnMostrarE.Name = "btnMostrarE";
            btnMostrarE.Size = new Size(185, 41);
            btnMostrarE.TabIndex = 2;
            btnMostrarE.Text = "Mostrar Entrenadores";
            btnMostrarE.UseVisualStyleBackColor = true;
            btnMostrarE.Click += button1_Click_1;
            // 
            // btnMostrarC
            // 
            btnMostrarC.Location = new Point(412, 12);
            btnMostrarC.Name = "btnMostrarC";
            btnMostrarC.Size = new Size(185, 41);
            btnMostrarC.TabIndex = 3;
            btnMostrarC.Text = "Mostrar Clases";
            btnMostrarC.UseVisualStyleBackColor = true;
            // 
            // btnMostrarM
            // 
            btnMostrarM.Location = new Point(603, 12);
            btnMostrarM.Name = "btnMostrarM";
            btnMostrarM.Size = new Size(185, 41);
            btnMostrarM.TabIndex = 4;
            btnMostrarM.Text = "Mostrar Membresias";
            btnMostrarM.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(668, 258);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(88, 29);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(569, 258);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(82, 29);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click_2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnCerrar);
            Controls.Add(btnMostrarM);
            Controls.Add(btnMostrarC);
            Controls.Add(btnMostrarE);
            Controls.Add(btnVentas);
            Controls.Add(btnMostrar);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
        private Button btnVentas;
        private Button btnMostrarE;
        private Button btnMostrarC;
        private Button btnMostrarM;
        private Button btnCerrar;
        private Button btnMenu;
    }
}