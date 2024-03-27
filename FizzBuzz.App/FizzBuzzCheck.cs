using System;

namespace FizzBuzz.App
{
    public class FizzBuzzCheck:ICheck
    {
        public bool Validate(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public string GetResponse()
        {
            return "FizzBuzz";
        }
    }
}