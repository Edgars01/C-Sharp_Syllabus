namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _peakTime;
        private bool _hasPeakTime;
        private int _fee;

        public TVAd(int fee,int seconds, int peakTime, bool hasPeakTime) : base(fee)
        {
            _fee = fee;
            _seconds = seconds;
            _peakTime = peakTime;
            _hasPeakTime = hasPeakTime;
        }
        
        public new int Cost() 
        {
            var fee = base.Cost();
            var price = (_seconds - _peakTime) * _fee;
            if (_hasPeakTime) 
                price += _peakTime * _fee * 2;
            return price;
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}