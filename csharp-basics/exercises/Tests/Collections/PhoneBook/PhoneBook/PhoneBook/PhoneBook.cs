using System.Collections.Generic;
using System.Linq;
using PhoneBook.Exception;

namespace PhoneBook
{
    public class PhoneBook : IPhoneBook
    {
        private readonly Dictionary<string, string> _phones;

        public PhoneBook()
        {
            _phones = new Dictionary<string, string>();
        }

        public string FindNumber(string number)
        {
            if (!_phones.ContainsValue(number)) throw new PhoneNumberNotFoundException();

            return number;
        }

        public void AddNumber(string name, string number)
        {
            if (name == null || number == null) throw new InvalidParametersprovidedException();

            if (_phones.Any(s => s.Value == number)) throw new DuplicatePhoneNumberException();

            _phones.Add(name, number);
        }

        public void RemoveNumber(string number)
        {
            foreach (var phone in _phones.Where(phone => phone.Value == number))
            {
                _phones.Remove(phone.Key);
                break;
            }
        }

        public int GetNumbers()
        {
            return _phones.Count();
        }
    }
}
