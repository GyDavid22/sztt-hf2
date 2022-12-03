namespace BusinessLogicLayer
{
    public class CardNotFoundException : Exception
    {
        public CardNotFoundException() : base("Card not found!")
        {

        }
    }
}
