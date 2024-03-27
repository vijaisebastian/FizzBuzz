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
            Program program = new Program();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(program.PlayFizzBuzz(i));
            }

            Console.ReadLine();
        }

        public string PlayFizzBuzz(int number)
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };

            string response = string.Empty;

            foreach (var condition in conditions)
            {
                if (condition.Validate(number))
                {
                    response = condition.GetResponse();
                }
            }

            if (string.IsNullOrEmpty(response))
            {
                response = number.ToString();
            }

            return response;

        }
    }
}
