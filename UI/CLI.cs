using UI.Commands;
using BusinessLogicLayer;
using DataAccessLayer;
using ListRepository;

namespace UI
{
    public class CLI
    {
        private static AnimalBLL bll = new AnimalBLL(new ListAnimalRepository(), new DictUserRepository()); 
        public static void Cli()
        {
            bool run = true;
            while (run)
            {
                Console.Write(">> ");
                string[] command;
                string line;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                if ((line = Console.ReadLine()) == null)
                    break;
                else
                    command = line.Split(" ");
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                CommandBase? cmdObject = CommandManager.Instance.Get(command[0]);
                if (cmdObject != null)
                    try
                    {
                        cmdObject.Execute(command, bll);
                        if (cmdObject.Modifyer)
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                            CommandManager.Instance.Get("list").Execute(command, bll);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
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