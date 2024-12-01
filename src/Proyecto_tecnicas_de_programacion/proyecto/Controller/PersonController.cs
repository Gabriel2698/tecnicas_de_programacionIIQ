using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Controller.DataHandler;

using Proyecto.Model;
namespace Proyecto.Controller
{
    public class PersonController
    {

        private IDataHandler handler;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController"/> class.
        /// </summary>
        public PersonController()
        {
            this.handler = new FileDataHandler();
        }

        /// <summary>
        /// Gets the people.
        /// </summary>
        /// <returns>a list for the people existing in the DB.</returns>
        public List<Person> GetPeople()
        {
            var filecontent = this.handler.ReadData();
            var people = this.handler.GetPeople(filecontent);
            return people;
        }

        /// <summary>
        /// Update the items.
        /// </summary>
        /// <param name="dataStr">The data in a string.</param>
        public void UpdateItems(string dataStr)
        {
            this.handler.WriteData(dataStr);
        }








    }
}
