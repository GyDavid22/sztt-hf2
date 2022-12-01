using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
