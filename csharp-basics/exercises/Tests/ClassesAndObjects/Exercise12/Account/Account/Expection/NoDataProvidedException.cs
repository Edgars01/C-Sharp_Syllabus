namespace Account.Expection
{
    public class NoDataProvidedException : System.Exception
    {
        public NoDataProvidedException() : base("provided information has missing details")
        {
            
        }
    }
}
