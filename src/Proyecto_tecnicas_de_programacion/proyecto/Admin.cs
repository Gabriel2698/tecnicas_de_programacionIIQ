using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using Proyecto.Model;
using Proyecto.Controller;

namespace Proyecto
{




    public partial class Admin : Form
    {

public List<Person> People { get;set; }
        private PersonController Controller { get; set; }



        public Admin()
        {
            InitializeComponent();

            this.People = new List<Person>();
            this.Controller = new PersonController();
            this.People =  this.Controller.GetPeople();




        }

        private void button1_Click(object sender, EventArgs e)
        {


        


        }





        private void btnVentas_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            proyecto.Form1 login = new proyecto.Form1(); // Crea una instancia del  formulario login
            this.Close(); // Cierra el formulario admin 
            login.Show();




        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

