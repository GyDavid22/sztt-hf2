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
        public override bool Execute(string[] param, IAnimalRepository rep)
        {
            throw new NotImplementedException();
        }
    }
}
