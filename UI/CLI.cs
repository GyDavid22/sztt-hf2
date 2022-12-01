using UI.Commands;
using BusinessLogicLayer;
using DataAccessLayer;

namespace UI
{
    public class CLI
    {
        private static View view = new View(new ListAnimalRepository(), new DictUserRepository()); 
        public static void Cli()
        {
            bool run = true;
            while (run)
            {
                Console.Write(">> ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string[] command = Console.ReadLine().Split(" ");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (command == null)
                    continue;
                CommandBase? cmdObject = CommandManager.Instance.Get(command[0].ToLower());
                if (cmdObject != null)
                    try
                    {
                        cmdObject.Execute(command, view);
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
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