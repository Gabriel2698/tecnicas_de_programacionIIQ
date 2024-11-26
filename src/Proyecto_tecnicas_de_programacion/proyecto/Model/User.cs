using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Model
{/// <summary>
///declaro las variables de los atributos de la clase user.
/// </summary>
    public class User
    {

        public User(string id, string nombre, string apellido, string clase,string contrasena ,string clases ,string entrenadores){

             this.clase = clase;
             this.nombre = nombre;
             this.apellido = apellido;
            this.id = id;
            this.contrasena = contrasena;
            this.clases = clases;
            this.entrenadores = entrenadores;

        }

     
        public string nombre { get; set; }

        


      public string apellido{ get; set; }

    

      public string clase{ get; set; }

      


    public string id { get; set; }



        public string entrenadores { get; set; }


        public string contrasena { get; set; }



        public string clases { get; set; }

    }

}

