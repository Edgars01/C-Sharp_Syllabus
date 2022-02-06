namespace PhoneBook.Exception
{
    public class PhoneNumberNotFoundException : System.Exception
    {
        public PhoneNumberNotFoundException() : base("Provided number doesn't exist")
        {
            
        }
    }
}
