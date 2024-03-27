using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.App
{
    public class Game
    {
        private List<ICheck> _conditions;

        public Game(List<ICheck> conditions)
        {
            _conditions = conditions;
        }

        public string PlayFizzBuzz(int number)
        {
            string response = string.Empty;

            foreach (var condition in _conditions)
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
