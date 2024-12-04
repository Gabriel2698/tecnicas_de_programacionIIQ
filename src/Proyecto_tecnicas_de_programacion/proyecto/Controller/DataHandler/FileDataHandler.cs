using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

using Proyecto.Controller.DataHandler;

namespace Proyecto.Controller.DataHandler
{
  using Proyecto.Model;
  
    /// <summary>
    /// Implementation of <see cref="IDataHandler"/> when using files.
    /// </summary>
    /// <seealso cref="proyecto.Controller.DataHandler.IDataHandler" />
    public class FileDataHandler : IDataHandler
    {
        private readonly string Assets = nameof(Assets);

        /// <summary>
        /// Gets the people.
        /// </summary>
        /// <param name="people">The people.</param>
        /// <returns>
        /// A list with the people in the system.
        /// </returns>
        public List<Person> GetPeople(string people)
        {
            var lines = people.Split(Environment.NewLine);
            var result = new List<Person>();

            for (var i = 1; i < lines.Length; i++)
            {
                var userLine = lines[i].Split(',');
                if (userLine.Length == 3)
                {
                    result.Add(new Person(userLine[0], userLine[1], userLine[2], userLine[3], userLine[4], userLine[5], userLine[6]));
                }
            }

            return result;
        }

        /// <summary>
        /// Reads the data from a file.
        /// </summary>
        public string ReadData()

        {
            var path = Path.Combine(Directory.GetCurrentDirectory() ,"Controller","Assets","Users.csv");
            var fileString = File.ReadAllText(path);
            return fileString;

        }

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void WriteData(string data)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Controller","Assets", "Users.csv");
            File.WriteAllText(path, data);
        }
    }

}
