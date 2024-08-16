using System;
using System.Collections.Generic;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== prime number list application ===\n");
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("Name: Muhammad Raihan Izyan Bayyin");
            Console.WriteLine("NO: 22");
            Console.WriteLine("Class: X PPLG\n");

            int limit = 1000;
            List<int> primes = GeneratePrimes(limit);

            Console.WriteLine($"Prime numbers from 1 to {limit}:\n");
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }
        }

        static List<int> GeneratePrimes(int limit)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}