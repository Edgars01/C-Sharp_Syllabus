namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _cm;

        public NewspaperAd(int fee, int column, int cm) : base(fee)
        {
            _column = column;
            _cm = cm;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            fee += _column *= _cm;
            return fee;
        }
    

        public override string ToString()
        {
            return base.ToString();
        }
    }
}