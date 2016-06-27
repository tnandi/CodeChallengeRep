using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TwinPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print TWIN PRIMES");
            Console.WriteLine("Enter the Max for the range (Min is Max-1000) : ");
            Int32 maxRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating the Twin Primes......");
            
            Stopwatch clock = new Stopwatch();
            clock.Start();

            ////Repeat for 100 times
            //for (var i = 0; i < 100; i++)
            //{
            //    //call getPrime method
            //    GetTwinPrimes(maxRange);
            //}
            GetTwinPrimes(maxRange);
            clock.Stop();
            Console.WriteLine("Time elapsed in millisec is : " + clock.ElapsedMilliseconds);
        }

        static void GetTwinPrimes(Int32 maxLim)
        {
            var div = Math.Sqrt(maxLim);
            var minLim = (maxLim - 1000);
            List<Int32> res = new List<Int32>();
            var isPrime = false;

            for (var i = maxLim; i >= minLim; i--)
            {
                for (int j = 3; j<=div; j+=2)
                {
                    if ((i % 2 == 0))
                    {
                        isPrime = false;
                        break;
                    }
                    if ((i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }

                    isPrime = true;
                }
                if (isPrime)
                {
                    res.Add(i);

                    if (res.Contains(i + 2))
                    {
                        Console.WriteLine(i + ", " + (i + 2));
                    }
                }
            }

            //foreach (var r in res)
            //{
            //    if (res.Contains(r + 2))
            //    {
            //        Console.WriteLine(r + ", " + (r + 2));
            //    }
            //}

        }
    }
}
