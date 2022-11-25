using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class MultiUser
    {
        public static MultiUser Instance { get; } = new MultiUser();
        private MultiUser()
        {

        }
        public int GetLoggedInUserId()
        {
            return 1234;
        }
    }
}
