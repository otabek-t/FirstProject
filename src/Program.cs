﻿namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonni kiriting: ");
            var number = Convert.ToUInt32(Console.ReadLine());
            var birlik = number % 10;
            var onlik = number /10 % 10;
            var yuzlik = number / 100 % 10;
            var minglik = number / 1000;
            var result = birlik + onlik + yuzlik + minglik;
            Console.WriteLine(result);
        }
    }
}
