using System;

namespace Exercise_7
{
    public class Dog
    {
        public string _name;
        public string _sex;
        public string _mother;
        public string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _mother = "Unknown";
            _father = "Unknown";
        }

        public bool HasSameMotherAs(Dog oneOfDogs)
        {
            return _mother == oneOfDogs._mother;
        }

        public void ShowDogStats()
        {
            Console.WriteLine($"{_name} {_sex} {_mother} {_father}");
        }
    }
}
