namespace BusinessLogicLayer
{
    class MultiUser
    {
        public static MultiUser Instance { get; } = new MultiUser();
        private MultiUser()
        {

        }
        public int GetLoggedInUserId()
        {
            return 1234;
        }
    }
}
