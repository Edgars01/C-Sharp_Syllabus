namespace Exercise1.Exception
{
    public class OneOfValuesNotProvidedException : System.Exception
    {
        public OneOfValuesNotProvidedException() : base("Value not provided")
        {
            
        }
    }
}
