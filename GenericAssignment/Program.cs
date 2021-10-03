using System;

namespace GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericComputation<int> generic = new GenericComputation<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericComputation<double> genericDouble = new GenericComputation<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericComputation<string> genericString = new GenericComputation<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
