using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Controller;
namespace Proyecto.Controller.Configuration
{
    /// <summary>
    /// Class in charge of managing the configuration of the application.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// brinda el nombre de donde esta el archivo DB
        /// </summary>
        /// <value>
        /// The people file.
        /// </value>
        public static string PeopleFile => "Assets.Users.csv";
    }
}
