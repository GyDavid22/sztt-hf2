using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class View
    {
        private IAnimalRepository _animalRepository;
        private IUserRepository _userRepository;

        private enum ModifyType
        {
            CREATION, MODIFICATION, DELETION
        }

        public View(IAnimalRepository animalRepository, IUserRepository userRepository)
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
            if (!(_animalRepository.Get(name) == null) || name.Length < 3 || name == "null" || shortDesc.Length <= 100)
            {
                throw new Exception("A card already exists with this name or the given details don't meet the criterias.");
            }
            _animalRepository.Add(new AnimalCard(name, latinName, shortDesc));
        }

        private void logToConsole(ModifyType m, AnimalCard a)
        {
            Console.WriteLine($"{m.ToString().Substring(0, 1).ToUpper() + m.ToString().Substring(1).ToLower()} of {a.Name} by {_userRepository.GetName(MultiUser.Instance.GetLoggedInUserId())}");
        }
    }
}