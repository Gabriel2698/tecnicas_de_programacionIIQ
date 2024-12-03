namespace Proyecto
{
    partial class Tabla
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            btnMostar = new Button();
            btnEditar = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(27, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(455, 400);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnMostar
            // 
            btnMostar.Location = new Point(27, 444);
            btnMostar.Name = "btnMostar";
            btnMostar.Size = new Size(116, 36);
            btnMostar.TabIndex = 2;
            btnMostar.Text = "MOSTRAR";
            btnMostar.UseVisualStyleBackColor = true;
            btnMostar.Click += btnMostar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(187, 444);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(116, 36);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(369, 444);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(96, 36);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 500);
            Controls.Add(btnMenu);
            Controls.Add(btnEditar);
            Controls.Add(btnMostar);
            Controls.Add(listView1);
            Name = "Tabla";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>



        #endregion

        private Button button1;
        private Button btnMostar;
        private Button btnEditar;
        private Button btnMenu;
    }
}