using BusinessLogicLayer;

namespace UI.Commands
{
    public abstract class CommandBase
    {
        public bool Modifyer { private set; get; }
        public CommandBase(bool modifyer)
        {
            Modifyer = modifyer;
        }

        /// <summary>
        /// Interface method to execute a command.
        /// </summary>
        /// <param name="param">Array of strings which contains the command entered the CLI, including the first word, the command itself.</param>
        public abstract void Execute(string[] param, AnimalBLL bll);
    }
}
