using System;
using System.Collections.Generic;

namespace MyTechniques.Tests.Others
{
    // Give the numbers 1 to 100
    // For each number found that is evenly divisible by 3, output the word "Wealth". 
    // For each number that is evenly divisible by 5, output the word "Tech".  
    // For each number that is evenly divisible by both 3 AND 5, output the word "WealthTech"

    public class WealthTeach
    {
        public void GetWealthTeach(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (IsEvenlyDivisibleBy3(number) && IsEvenlyDivisibleBy5(number))
                    Print("WealthTech");
                else if (IsEvenlyDivisibleBy3(number))
                    Print("Wealth");
                else if(IsEvenlyDivisibleBy5(number))
                    Print("Tech");
            }
        }

        private bool IsEvenlyDivisibleBy3(int number) => number % 3 == 0;
        private bool IsEvenlyDivisibleBy5(int number) => number % 5 == 0;
        private void Print(string text) => Console.WriteLine(text);
    }
}
