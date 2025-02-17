﻿using System;
namespace BasicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Program");
            bool end = true;
            Console.WriteLine("1.LeapYear\n2.PowerOfTwo\n3.HarmonicNumber\n4.EvenOddNumber\n5.VowelsConsonent\n6.LargestNumber\n7.QuotientRemainder\n8.NumberSwap\n9.FlipCoin\n10.End the Program");
            while (end == true)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckLeapYear();
                        break;

                    case 2:
                        PowerOfTwo powerOfTwo = new PowerOfTwo();
                        powerOfTwo.PowerTable();
                        break;

                    case 3:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Harmonic();
                        break;

                    case 4:
                        EvenOddNumber evenOddNumber = new EvenOddNumber();
                        evenOddNumber.CheckEvenOdd();
                        break;
                    case 5:
                        VowelConsonant vowelConsonant = new VowelConsonant();
                        vowelConsonant.CheckVowelOrConsonant();
                        break;
                    case 6:
                        FindLargestNumber largetNumber = new FindLargestNumber();
                        largetNumber.LargestNumber();
                        break;
                    case 7:
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.QuotientRemainder();
                        break;
                    case 8:
                        TwoNumberSwap Swap = new TwoNumberSwap();
                        Swap.NumberSwap();
                        break;
                    case 9:
                        FlipCoin coin = new FlipCoin();
                        coin.CoinFlip();
                        break;
                    case 10:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;
                }
            }
        }
    }
}