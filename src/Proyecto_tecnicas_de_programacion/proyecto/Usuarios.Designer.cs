namespace Proyecto
{
    partial class Usuarios
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
            btnMostrarC = new Button();
            btnMostrarM = new Button();
            btnRenovar = new Button();
            btnMenu = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnMostrarC
            // 
            btnMostrarC.Location = new Point(35, 27);
            btnMostrarC.Name = "btnMostrarC";
            btnMostrarC.Size = new Size(218, 53);
            btnMostrarC.TabIndex = 0;
            btnMostrarC.Text = "Mostrar Clases";
            btnMostrarC.UseVisualStyleBackColor = true;
            // 
            // btnMostrarM
            // 
            btnMostrarM.Location = new Point(299, 30);
            btnMostrarM.Name = "btnMostrarM";
            btnMostrarM.Size = new Size(197, 50);
            btnMostrarM.TabIndex = 1;
            btnMostrarM.Text = "Mostrar Membresia";
            btnMostrarM.UseVisualStyleBackColor = true;
            btnMostrarM.Click += button2_Click;
            // 
            // btnRenovar
            // 
            btnRenovar.Location = new Point(543, 30);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(182, 53);
            btnRenovar.TabIndex = 2;
            btnRenovar.Text = "Renovar Membrecia";
            btnRenovar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(516, 250);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(192, 62);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(661, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click_1;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnMenu);
            Controls.Add(btnRenovar);
            Controls.Add(btnMostrarM);
            Controls.Add(btnMostrarC);
            Name = "Usuarios";
            Text = "Usuarios";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarC;
        private Button btnMostrarM;
        private Button btnRenovar;
        private Button btnMenu;
        private Button btnSalir;
    }
}