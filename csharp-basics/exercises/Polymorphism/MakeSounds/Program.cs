using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>();
            sounds.Add(new Radio());
            sounds.Add(new Parrot());

            for (var i = 1; i < 2; i++)
                foreach (var sound in sounds)
                    sound.PlaySound();

            Console.ReadKey();
        }
    }
}