using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
namespace Proyecto.Model
{/// <summary>
///declaro las variables de los atributos de la clase user.
/// </summary>
    public class Person
    {

        public Person(string ID, string Nombre, string Apellido, string Clase,string Contrasena  ,string Entrenadores,string Membrecia){

             this.Clase = Clase;
             this.Nombre = Nombre;
             this.Apellido = Apellido;
            this.ID =ID;
            this.Contrasena = Contrasena;
            this.Entrenadores =  Entrenadores;
            this.Membrecia = Membrecia;  

        }
        public string Membrecia { get; set; }
     
        public string Nombre { get; set; }

        


      public string Apellido{ get; set; }

    

      public string Clase{ get; set; }

      


    public string ID { get; set; }



        public string Entrenadores { get; set; }


        public string Contrasena { get; set; }



     

    }

}

