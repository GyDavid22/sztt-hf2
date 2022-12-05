namespace UI.Commands
{
    public class CommandManager
    {
        public static CommandManager Instance { get; } = new CommandManager();
        private Dictionary<string, CommandBase> _commands;
        private CommandManager()
        {
            _commands = new Dictionary<string, CommandBase>() {
                { "add", new AddCommand() },
                { "addtype", new AddTypeCommand() },
                { "del", new DeleteCommand() },
                { "list", new ListAllCommand() }
            };
        }

        public CommandBase? Get(string name)
        {
            if (_commands.ContainsKey(name))
                return _commands[name.ToLower()];
            return null;
        }
    }
}
