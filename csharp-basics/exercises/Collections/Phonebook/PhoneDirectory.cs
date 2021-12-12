using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> sortedDic;

        public PhoneDirectory()
        {
            sortedDic = new SortedDictionary<string, string>();
        }

        private bool Find(string name)
        {
            return sortedDic.Any(x => x.Key == name);
        }

        public string GetNumber(string name)
        {
            return Find(name) ? sortedDic[name] : "Name could not be found";
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null) throw new Exception("name and number cannot be null");
            sortedDic.Add(name, number);
        }
    }
}