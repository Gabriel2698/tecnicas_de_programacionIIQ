using System.Diagnostics.Metrics;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          InitializeComponent();
            
          
            this.controller = new PersonController();
            var people = controller.GetPeople();

            this.listView1.Columns.Add(Text = NameColumn, Width = 100);
            this.listView1.Columns.Add(Text = Apellido, Width = 100);
            this.listView1.Columns.Add(Text = Country, Width = 100);
            this.listView1.Items.AddRange(people.Select(p => new ListViewItem([p.Nombre, p.Apellido, p.Clase,p.Id])).ToArray());  
            
            
            
          
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
    }
}
