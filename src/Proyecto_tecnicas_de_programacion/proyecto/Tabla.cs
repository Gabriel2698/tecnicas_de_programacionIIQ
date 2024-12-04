using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controller;
using CsvHelper;
namespace Proyecto
{
    public partial class Tabla : Form
    {


        private readonly PersonController controller;
        private readonly string Nombre = nameof(Nombre);
        private readonly string Apellido = "Apellido";
        private readonly string Contrasena = "Contraseña";
        private readonly string Clase = "Clase";
        private readonly string Entrenador = "Entrenador";
        private readonly string Membrecia = "Membrecía";
        private readonly string NameColumn = "ID";






        public Tabla()
        {
            InitializeComponent();

            this.controller = new PersonController();
            var people = controller.GetPeople();
            
            this.listView1.Columns.Add(Text = NameColumn, Width = 100);
            this.listView1.Columns.Add(Text = Nombre, Width = 100);
            this.listView1.Columns.Add(Text = Apellido, Width = 100);
            this.listView1.Columns.Add(Text = Contrasena, Width = 100);
            this.listView1.Columns.Add(Text = Clase, Width = 100);
            this.listView1.Columns.Add(Text = Entrenador, Width = 100);
            this.listView1.Columns.Add(Text = Membrecia, Width = 100);

            this.listView1.Items.AddRange(people.Select(p => new ListViewItem([p.ID, p.Nombre, p.Apellido, p.Contrasena, p.Clase, p.Membrecia, p.Entrenadores])).ToArray());









        }

        private void Tabla_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {

            var dataStr = $"{this.NameColumn},{this.Nombre},{this.Apellido},{this.Contrasena},{this.Clase},{this.Entrenador},{this.Membrecia},{Environment.NewLine}";
            this.controller.UpdateItems(dataStr);













        }
    }
}
