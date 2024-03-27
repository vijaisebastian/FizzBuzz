using System;

namespace FizzBuzz.App
{
    public class FizzCheck
    {

        public bool Validate(int number)
        {
            return number % 3 == 0;
        }

        public string GetString()
        {
            return "Fizz";
        }
    }
}