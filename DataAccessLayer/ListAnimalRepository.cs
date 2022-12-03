using System.Text;

using DataAccessLayer;

namespace ListRepository
{
    public class ListAnimalRepository : IAnimalRepository
    {
        private List<AnimalCard> _repo = new List<AnimalCard>();
        public void Add(AnimalCard card)
        {
            _repo.Add(card);
        }

        public void AddCardType(AnimalCard card, string type)
        {
            card.AnimalType = type;
        }

        public AnimalCard? Get(string cardName)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName)
                {
                    return i;
                }
            }
            return null;
        }

        public string listAll()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in _repo)
            {
                sb.Append(i.ToString() + "\n");
            }
            return sb.ToString();
        }

        public void Remove(AnimalCard card)
        {
            _repo.Remove(card);
        }
    }
}
