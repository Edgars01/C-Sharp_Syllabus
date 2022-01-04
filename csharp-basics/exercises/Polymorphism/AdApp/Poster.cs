namespace AdApp
{
    internal class Poster : Advert
    {
        private int _daysOld;
        private int _fee;
        
        public Poster(int fee, int daysOld) : base(fee)
        {
            _fee = fee;
            _daysOld = daysOld;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            var price = (_daysOld * _fee);
            return price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
