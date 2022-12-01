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

        public void AddCardType(string cardName, string type)
        {

        }

        public AnimalCard? Get(string cardName)
        {
            return null;
        }

        public string listAll()
        {
            return "";
        }

        public void Remove(string cardName)
        {

        }
    }
}
