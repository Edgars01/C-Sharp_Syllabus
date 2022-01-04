using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Video
    {
        public string _title;
        public bool _available;
        public List<double> _rate;
        internal bool isAvailable;

        public Video(string title)
        {
            _title = title;
            _available = true;
            _rate = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _available = false;
        }

        public void BeingReturned()
        {
            _available = true;
        }

        public void ReceivingRating(double rating)
        {
            _rate.Add(rating);
        }

        public double AverageRating()
        {
            var rateSum = _rate.Sum();
            return rateSum / _rate.Count();
        }

        public bool Available()
        {
            return _available;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Title:{_title}, average rating: {AverageRating()}, is available: {Available()}";
        }
    }
}
