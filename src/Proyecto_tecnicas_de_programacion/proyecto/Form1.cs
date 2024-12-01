using System.Diagnostics.Metrics;
using Proyecto;
using Proyecto.Controller;
using Proyecto.Model;

namespace proyecto
{
    public partial class Form1 : Form
    {




        public List<Person> People { get; set; }
        private PersonController Controller { get; set; }
        public Form1()
        {
            InitializeComponent();




            this.People = new List<Person>();
            this.Controller = new PersonController();
            this.People = this.Controller.GetPeople();




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
            var user = this.txtNombre.Text;
            var pass = this.txtContraseña.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor digite la Infomación solicitada");
                this.txtNombre.Text = string.Empty;
                this.txtContraseña.Text = string.Empty;
                return;

            }
            foreach (var item in this.People)
            {
                if (user == $"{item.nombre}" && pass == item.contrasena)
                {
                    MessageBox.Show("Login Success");



      


                     var Admin = new Admin(); // Crea una instancia del segundo formulario
                    this.Hide(); // Oculta el primer formulario
                     Admin.Show(); //
            
                               return;

                }
               
                
                  
                else
                {
                    MessageBox.Show("Login Failed");

                    return;
                }

               
            }
                this.txtNombre.Text = string.Empty;
                this.txtContraseña.Text = string.Empty;
                    
                    
                    }





    }

}