using System;

namespace FizzBuzz.App
{
    public class BuzzCheck
    {
        public bool Validate(int number)
        {
            return number % 5 == 0;
        }

        public string GetString()
        {
            return "Buzz";
        }

    }
}