using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DBRepository : IRepository
    {
        public bool Add(AnimalCard card)
        {
            return true;
        }

        public bool AddCardType(string cardName, AnimalCard.Type type)
        {
            return true;
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
