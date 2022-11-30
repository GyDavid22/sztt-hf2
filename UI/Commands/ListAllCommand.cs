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

        public override bool Execute(string[] param, IAnimalRepository rep)
        {
            rep.listAll();
            return true;
        }
    }
}
