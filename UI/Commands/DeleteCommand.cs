using BusinessLogicLayer;
using System.Text;

namespace UI.Commands
{
    public class DeleteCommand : CommandBase
    {
        public DeleteCommand() : base(true)
        {

        }
        public override void Execute(string[] param, AnimalBLL bll)
        {
            StringBuilder name = new StringBuilder();
            for (int i = 1; i < param.Length - 1; i++)
            {
                name.Append($"{param[i]} ");
            }
            name.Append(param[param.Length - 1]);
            bll.Remove(name.ToString());
        }
    }
}
