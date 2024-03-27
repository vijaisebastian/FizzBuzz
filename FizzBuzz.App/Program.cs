using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };

            Game game = new Game(conditions);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(game.PlayFizzBuzz(i));
            }

            Console.ReadLine();
        }
    }
}
