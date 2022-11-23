using Model;

namespace View
{
    public class View
    {
        private Model.IRepository _rep;

        public View(IRepository rep)
        {
            this._rep = rep;
        }
        /// <summary>
        /// Adds a new animal card to the database. Type can be added with ChangeType()
        /// </summary>
        /// <param name="name">Name of the card</param>
        /// <param name="latinName">Latin name of the card</param>
        /// <param name="shortDesc">Short description of the card</param>
        public void Add(string name, string latinName, string shortDesc)
        {
            if (!(_rep.Get(name) == null) || name.Length < 3 || name == "null" || shortDesc.Length <= 100)
            {
                throw new Exception("A card already exists with this name or the given details don't meet the criterias.");
            }
            _rep.Add(new AnimalCard(name, latinName, shortDesc));
        }
    }
}