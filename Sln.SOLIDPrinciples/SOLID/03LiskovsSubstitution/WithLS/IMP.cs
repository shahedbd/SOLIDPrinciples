using System;

namespace SOLID._03LiskovsSubstitution.WithLS
{
    public static class IMP
    {
        public static void ExecuteWithLS()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            //Stored any subclass reference into a base class variable
            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            //Stored any subclass reference into a base class variable
            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
        }
    }
}
