namespace PhoneBook.Exception
{
    public class DuplicatePhoneNumberException : System.Exception
    {
        public DuplicatePhoneNumberException() : base("Provided phone number already exists")
        {
            
        }
    }
}
