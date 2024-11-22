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

        public User(string id, string nombre, string apellido, string clase){

             this.clase = clase;
             this.nombre = nombre;
             this.apellido = apellido;
            this.id = id;
            }

     
        public string nombre { get; set; }

        


      public string apellido{ get; set; }

    

      public string clase{ get; set; }

      


    public string id { get; set; }











  }

}

