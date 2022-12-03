using BusinessLogicLayer;

namespace UI.Commands
{
    public class ListAllCommand : CommandBase
    {
        public ListAllCommand() : base("list", false)
        {

        }

        public override void Execute(string[] param, AnimalBLL bll)
        {
            Console.WriteLine(bll.ListAll());
        }
    }
}
