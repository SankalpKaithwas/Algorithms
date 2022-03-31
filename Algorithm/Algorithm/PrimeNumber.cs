using System;
namespace Algorithm
{
    internal class PrimeNumber
    {
        public void PrimeNumberInRange()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
        }
        public bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else return false;
        }
    }
}