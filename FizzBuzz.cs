using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFizzBuzz
{
    public class FizzBuzz
    {
        public string Check(params int[] numbers)
        {
            string returnCheck = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                var checkNumber = numbers[i];

                returnCheck += CheckFizzBuzz(checkNumber);
            }

            return (returnCheck.Length == 0 ? numbers.ToString() : returnCheck.ToString());

        }

        private string CheckFizzBuzz(int checkNumber)
        {
            string returnCheck = string.Empty;

            if (IsDivibleFor(checkNumber, 3) && IsDivibleFor(checkNumber, 5))
                returnCheck = "FizzBuzz";
            else if (IsDivibleFor(checkNumber, 3) || Contain(checkNumber, 3))
                returnCheck = "Fizz";
            else if (IsDivibleFor(checkNumber, 5) || Contain(checkNumber, 5))
                returnCheck = "Buzz";
            else
                returnCheck = checkNumber.ToString();

            return returnCheck;
        }

        private bool Contain(int checkNumber, int number)
        {
            return (checkNumber.ToString().Contains(number.ToString()));
        }

        private static bool IsDivibleFor(int checkNumber, int divisor)
        {
            return checkNumber % divisor == 0;
        }
    }
}
