using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Choose the operation you want to perform ");
                WriteLine("Choose 0 for EXIT");
                WriteLine("Choose 1 to fill video store");
                WriteLine("Choose 2 to rent video (as user)");
                WriteLine("Choose 3 to return video (as user)");
                WriteLine("Choose 4 to list inventory");

                int n = Convert.ToByte(ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
                Clear();
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                WriteLine("Enter movie name");
                var movieName = ReadLine();

                WriteLine("Enter rating");
                int rating = Convert.ToInt16(ReadLine());

                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            WriteLine("Enter movie name");
            var movieName = ReadLine();
            _videoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            WriteLine("Enter movie name");
            var movieName = ReadLine();
            _videoStore.ReturnVideo(movieName);
        }
    }
}
