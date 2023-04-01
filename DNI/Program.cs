using System;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        public static char LetterNIF(int number)
        {
            string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
            return letters[number%23];
        }
    }
}