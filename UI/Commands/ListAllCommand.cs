using BusinessLogicLayer;

namespace UI.Commands
{
    public class ListAllCommand : CommandBase
    {
        public ListAllCommand() : base("list", false)
        {

        }

        public override void Execute(string[] param, AnimalBLL view)
        {
            Console.WriteLine(view.ListAll());
        }
    }
}
