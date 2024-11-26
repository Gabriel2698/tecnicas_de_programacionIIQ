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
namespace Proyecto
{




    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        string    filePath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "proyecto","DB" ,"users.csv");


            if (File.Exists(filePath))
            {
                List<User> users = LoadUsersFromCsv(filePath);
               Proyecto.Tabla formT = Proyecto.Tabla(users, filePath); // Pasamos la lista de usuarios y la ruta del archivo
                formT.Show();
            }
            else
            {
                MessageBox.Show("El archivo no se encontró.");
            }
        }

        private List<User> LoadUsersFromCsv(string filePath)
        {
            List<User> users = new List<User>();
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Saltar la primera línea si contiene encabezados
                if (!parser.EndOfData)
                {
                    parser.ReadLine();
                }

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    User user = new User
                    {
                        Id = int.Parse(fields[0]),
                        Nombre = fields[1],
                        Apellido = fields[2],
                        Clases = fields[3],
                        Entrenador = bool.Parse(fields[4]),
                        Contrasena = fields[5]
                    };
                    users.Add(user);
                }
            }
            return users;
        }




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

