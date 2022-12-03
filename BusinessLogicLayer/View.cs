using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AnimalBLL
    {
        private IAnimalRepository _animalRepository;
        private IUserRepository _userRepository;

        public enum ModifyType
        {
            CREATION, MODIFICATION, DELETION
        }

        public AnimalBLL(IAnimalRepository animalRepository, IUserRepository userRepository)
        {
            this._animalRepository = animalRepository;
            this._userRepository = userRepository;
        }
        /// <summary>
        /// Adds a new animal card to the database. Type can be added with ChangeType()
        /// </summary>
        /// <param name="name">Name of the card</param>
        /// <param name="latinName">Latin name of the card</param>
        /// <param name="shortDesc">Short description of the card</param>
        public void Add(string name, string latinName, string shortDesc)
        {
            if (_animalRepository.Get(name) != null || name.Length < 3 || name == "null" || shortDesc.Length > 100)
            {
                throw new Exception("A card already exists with this name or the given details don't meet the criterias.");
            }
            _animalRepository.Add(new AnimalCard(name, latinName, shortDesc));
            LogToConsole(ModifyType.CREATION, name);
        }

        /// <summary>
        /// Prints a line of log to the console.
        /// </summary>
        /// <param name="m">Type of the modification happened</param>
        /// <param name="name">The name of the affected AnimalCard</param>
        public void LogToConsole(ModifyType m, string name)
        {
            Console.WriteLine($"{m.ToString().Substring(0, 1).ToUpper() + m.ToString().Substring(1).ToLower()} of {name} by {_userRepository.GetName(MultiUser.Instance.GetLoggedInUserId())}");
        }

        /// <summary>
        /// Lists all cards.
        /// </summary>
        /// <returns>A string containing all elements, divided by \n</returns>
        public string ListAll()
        {
            return _animalRepository.listAll();
        }

        /// <summary>
        /// Removes a card from the repository.
        /// </summary>
        /// <param name="name">Name of the card to remove</param>
        public void Remove(string name)
        {
            _animalRepository.Remove(name);
            LogToConsole(ModifyType.DELETION, name);
        }

        /// <summary>
        /// Adds/changes the type of the selected card.
        /// </summary>
        /// <param name="name">Name of the card to modify</param>
        /// <param name="type">The type to set to the card</param>
        public void AddType(string name, string type)
        {
            _animalRepository.AddCardType(name, type);
            LogToConsole(ModifyType.MODIFICATION, name);
        }
    }
}