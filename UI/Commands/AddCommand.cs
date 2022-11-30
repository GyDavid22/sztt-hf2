using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Commands
{
    public class AddCommand : CommandBase
    {
        public AddCommand() : base("add")
        {

        }

        public override bool Execute(string[] param, IAnimalRepository rep)
        {
            throw new NotImplementedException();
        }
    }
}
