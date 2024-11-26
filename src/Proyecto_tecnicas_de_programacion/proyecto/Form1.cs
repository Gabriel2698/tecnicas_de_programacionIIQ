using System.Diagnostics.Metrics;
using Proyecto;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();








        }










        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtNombre.Clear();


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            Usuarios form2 = new Usuarios(); // Crea una instancia del segundo formulario
            this.Hide(); // Oculta el primer formulario
            form2.Show(); //



        }
    }
}
