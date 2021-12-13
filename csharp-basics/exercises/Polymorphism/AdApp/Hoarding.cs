namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _ratePerDay;
        private int _numDays;
        private int _surCharge;
        private bool _isPrimeLocation;

        public Hoarding(int fee) : base(fee)
        {
        }
        public Hoarding(int fee, int days, int surCharge, bool primeLocation = false) : base(fee)
        {

            _numDays = days;
            _surCharge = surCharge;
            _isPrimeLocation = primeLocation;
        }


        public new int Cost()
        {
            var cost = base.Cost() * _numDays;
            if (_isPrimeLocation)
                cost *= _surCharge;
            return cost;
        }

        public override string ToString()
        {
            return $"{Cost()}";
        }
    }
}