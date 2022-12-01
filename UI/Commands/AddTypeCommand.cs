using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Commands
{
    public class AddTypeCommand : CommandBase
    {
        public AddTypeCommand() : base("addtype")
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
            Console.Write("Type in the desired type: ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string type = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            view.AddType(name.ToString(), type);
        }
    }
}
