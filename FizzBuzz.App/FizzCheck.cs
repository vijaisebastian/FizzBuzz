using System;

namespace FizzBuzz.App
{
    public class FizzCheck : ICheck
    {

        public bool Validate(int number)
        {
            return number % 3 == 0;
        }

        public string GetResponse()
        {
            return "Fizz";
        }
    }
}