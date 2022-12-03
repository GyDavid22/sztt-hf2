using BusinessLogicLayer;

namespace UI.Commands
{
    public abstract class CommandBase
    {
        public string Name { private set; get; }
        public bool Modifyer { private set; get; }
        public CommandBase(string name, bool modifyer)
        {
            Name = name;
            Modifyer = modifyer;
        }

        /// <summary>
        /// Interface method to execute a command.
        /// </summary>
        /// <param name="param">Array of strings which contains the command entered the CLI, including the first word, the command itself.</param>
        public abstract void Execute(string[] param, AnimalBLL view);
    }
}
