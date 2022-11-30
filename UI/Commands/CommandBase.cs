using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Commands
{
    public abstract class CommandBase
    {
        public string Name { private set; get; }
        public CommandBase(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Interface method to execute a command.
        /// </summary>
        /// <param name="param">Array of strings which contains the command entered the CLI, including the first word, the command itself.</param>
        /// <returns>True, if the execution was successful, false otherwise.</returns>
        public abstract bool Execute(string[] param, IAnimalRepository rep);
    }
}
