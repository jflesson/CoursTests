using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var numberToAdd = numbers.Split(',');
            return numberToAdd.Length == 1?Convert.ToInt32(numbers):
                Convert.ToInt32(numberToAdd[0]) + Convert.ToInt32(numberToAdd[1]);
        }
    }
}
