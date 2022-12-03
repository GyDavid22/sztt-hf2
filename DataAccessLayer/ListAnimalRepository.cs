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

        public void AddCardType(string cardName, string type)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName && AnimalCard.StringToType.ContainsKey(type.ToLower()))
                {
                    i.AnimalType = type;
                    return;
                }
            }
            throw new Exception("Unsupported type or misspelled name.");
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

        public void Remove(string cardName)
        {
            foreach (var i in _repo)
            {
                if (i.Name == cardName)
                {
                    _repo.Remove(i);
                    return;
                }
            }
            throw new Exception("Not found.");
        }
    }
}
