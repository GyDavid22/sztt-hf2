namespace DataAccessLayer
{
    public interface IAnimalRepository
    {
        /// <summary>
        /// Add new card to the reporitory.
        /// </summary>
        /// <param name="card">New card object to add.</param>
        public void Add(AnimalCard card);
        /// <summary>
        /// Give type to an existing card.
        /// </summary>
        /// <param name="cardName">The name of the card which we would like to add a type to.</param>
        /// <param name="type">The type we would like to set.</param>
        public void AddCardType(string cardName, string type);
        /// <summary>
        /// Remove an already existing card from the repository.
        /// </summary>
        /// <param name="cardName">The name of the card to remove.</param>
        public void Remove(string cardName);
        /// <summary>
        /// List all cards from the repository.
        /// </summary>
        /// <returns>A string containing all elements, divided by \n.</returns>
        string listAll();
        /// <summary>
        /// Method to get AnimalCard object from the repository.
        /// </summary>
        /// <param name="cardName"></param>
        /// <returns>Returns the animal card with the given name. Returns null if not found.</returns>
        public AnimalCard? Get(string cardName);
    }
}