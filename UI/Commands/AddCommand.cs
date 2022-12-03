using BusinessLogicLayer;

namespace UI.Commands
{
    public class AddCommand : CommandBase
    {
        public AddCommand() : base("add", true)
        {

        }

        public override void Execute(string[] param, AnimalBLL bll)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Latin name: ");
            string latinName = Console.ReadLine();
            Console.Write("Short description: ");
            string shortDesc = Console.ReadLine();
#pragma warning disable CS8604 // Possible null reference argument.
            bll.Add(name, latinName, shortDesc);
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}
