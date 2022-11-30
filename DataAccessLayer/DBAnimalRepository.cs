using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DBAnimalRepository : IAnimalRepository
    {
        public void Add(AnimalCard card)
        {
            
        }

        public bool AddCardType(string cardName, string type)
        {
            return true;
        }

        public AnimalCard? Get(string cardName)
        {
            return null;
        }

        public string listAll()
        {
            return "";
        }

        public bool Remove(string cardName)
        {
            return true;
        }
    }
}
