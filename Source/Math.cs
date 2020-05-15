using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            var fibonnaci = new List<int>() { 0, 1 };
            int maxNumber = 233;
            int number = 0;
           
            for (int position = fibonnaci.Count; number < maxNumber; position++)
            {
                number = fibonnaci[position - 1] + fibonnaci[position - 2];

                fibonnaci.Add(number);
            }

            return fibonnaci;
        }
               
        public bool IsFibonacci(int numberToTest)
        {
            var fibonacci = Fibonacci();
            return fibonacci.Contains(numberToTest);
        }
    }
}
