using System;

namespace FizzBuzz.App
{
    public class BuzzCheck:ICheck
    {
        public bool Validate(int number)
        {
            return number % 5 == 0;
        }

        public string GetResponse()
        {
            return "Buzz";
        }

    }
}