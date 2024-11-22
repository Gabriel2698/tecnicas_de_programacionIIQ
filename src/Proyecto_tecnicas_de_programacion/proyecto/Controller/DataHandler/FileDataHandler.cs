using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controller.DataHandler
{
    using Model;

    /// <summary>
    /// Implementation of <see cref="IDataHandler"/> when using files.
    /// </summary>
    /// <seealso cref="Controller.DataHandler.IDataHandler" />
    public class FileDataHandler : IDataHandler
    {
        private readonly string DB = nameof(DB);

        /// <summary>
        /// Gets the people.
        /// </summary>
        /// <param name="people">The people.</param>
        /// <returns>
        /// A list with the people in the system.
        /// </returns>
        public List<User> GetPeople(string people)
        {
            var lines = people.Split(Environment.NewLine);
            var result = new List<User>();

            for (var i = 1; i < lines.Length; i++)
            {
                var userLine = lines[i].Split(',');
                if (userLine.Length == 4)
                {
                    result.Add(new User(userLine[0], userLine[1], userLine[2], userLine[3]));
                }
            }

            return result;
        }

        /// <summary>
        /// Reads the data from a file.
        /// </summary>
        public string ReadData()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), this.DB, Configuration.Configuration.UserFile);
            var fileString = File.ReadAllText(path);
            return fileString;
        }

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void WriteData(string data)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), this.DB, "Users.csv");
            File.WriteAllText(path, data);
        }
    }
    }
