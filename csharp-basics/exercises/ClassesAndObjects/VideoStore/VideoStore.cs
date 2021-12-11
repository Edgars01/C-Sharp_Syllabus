using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class VideoStore
    {
        public static List<Video> _store = new List<Video>();

        public void AddVideo(string title)
        {
            _store.Add((new Video(title)));
        }
        
        public void Checkout(string title)
        {
            foreach (var t in _store)
            {
                if (t.Title == title && t._available == true)
                {
                    t.BeingCheckedOut();
                }
                else if (t.Title == title && t._available == false)
                {
                    Console.WriteLine("Sorry, currently rented out");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Console.ReadKey();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var t in _store)
            {
                if (t.Title == title && t._available == false)
                {
                    t.BeingReturned();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var vid in _store.Where(vid => title == vid.Title))
            {
                vid.ReceivingRating(rating);
            }
        }

        public void ListInventory()
        {
            foreach (var vid in _store)
            {
                Console.WriteLine(vid.ToString());
            }
        }
    }
}
