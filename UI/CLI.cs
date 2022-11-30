using DataAccessLayer;
using UI.Commands;

namespace UI
{
    public class CLI
    {
        private static IAnimalRepository _rep = new ListAnimalRepository(); 
        public static void Cli()
        {
            bool run = true;
            while (run)
            {
                Console.Write(">> ");
                string[] command = Console.ReadLine().Split(" ");
                if (command == null)
                    continue;
                CommandBase? cmdObject = CommandManager.Instance.Get(command[0].ToLower());
                bool result;
                if (cmdObject != null)
                    result = cmdObject.Execute(command, _rep);
                else
                    switch (command[0].ToLower())
                    {
                        case "exit":
                            run = false;
                            break;
                        case "":
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
            }
        }
    }
}