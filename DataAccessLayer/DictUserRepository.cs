using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DictUserRepository : IUserRepository
    {
        private Dictionary<int, string> _users = new Dictionary<int, string>()
        {
            { 1234, "Dávid" }
        };
        public string GetName(int id)
        {
            if (_users.ContainsKey(id))
            {
                return _users[id];
            }
            throw new Exception("User not found");
        }
    }
}
