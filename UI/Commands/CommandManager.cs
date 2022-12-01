namespace UI.Commands
{
    public class CommandManager
    {
        public static CommandManager Instance { get; } = new CommandManager();
        private CommandBase[] commands;
        private CommandManager()
        {
            commands = new CommandBase[] {
                new AddCommand(),
                new AddTypeCommand(),
                new DeleteCommand(),
                new ListAllCommand()
            };
        }

        public CommandBase? Get(string name)
        {
            foreach (var i in commands)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
