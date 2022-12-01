using BusinessLogicLayer;

namespace UI.Commands
{
    public class ListAllCommand : CommandBase
    {
        public ListAllCommand() : base("list")
        {

        }

        public override void Execute(string[] param, View view)
        {
            Console.WriteLine(view.ListAll());
        }
    }
}
