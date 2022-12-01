using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Commands
{
    public class DeleteCommand : CommandBase
    {
        public DeleteCommand() : base("del")
        {

        }
        public override void Execute(string[] param, View view)
        {
            StringBuilder name = new StringBuilder();
            for (int i = 1; i < param.Length - 1; i++)
            {
                name.Append($"{param[i]} ");
            }
            name.Append(param[param.Length - 1]);
            view.Remove(name.ToString());
        }
    }
}
