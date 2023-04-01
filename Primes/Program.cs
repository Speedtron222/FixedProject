using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            string response;
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            num = int.Parse(response);
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(int number)
        {
            bool result = false;
            if(number <= 1)
                return result;
            if (number == 2)
                return !result;
            if (number % 2 == 0)
                return result;
            for(int i = number - 1; i > 1; i--)
            {
                if(number % i == 0)
                    return false;
                else result= true;
            }
            return result;
        }
    }
}