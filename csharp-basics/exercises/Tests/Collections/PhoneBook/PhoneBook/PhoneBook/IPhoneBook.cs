using System.Collections.Generic;

namespace PhoneBook
{
    public interface IPhoneBook
    {
        public string FindNumber(string number);

        public void AddNumber(string name, string number);

        public void RemoveNumber(string number);

        public int GetNumbers();
    }
}